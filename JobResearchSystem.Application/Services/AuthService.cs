using AutoMapper;
using JobResearchSystem.Application.DTOs.Authentication;
using JobResearchSystem.Application.IService;
using JobResearchSystem.Domain.Entities.Extend;
using JobResearchSystem.Infrastructure.Database;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JobResearchSystem.Application.Services
{
    public class AuthService : IAuthService
    {
        private readonly ApplicationContext _db;
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;

        public AuthService(
            ApplicationContext db,
            UserManager<ApplicationUser> userManager,
            RoleManager<IdentityRole> roleManager,
            IConfiguration configuration,
            IMapper mapper
            )
        {
            _db = db;
            _userManager = userManager;
            _roleManager = roleManager;
            _configuration = configuration;
            this._mapper = mapper;
        }
        public async Task<ResponseDto> SeedRolesAsync()
        {
            bool isCustomerRoleExists = await _roleManager.RoleExistsAsync("JOBSEEKER");
            bool isCompanyRoleExists = await _roleManager.RoleExistsAsync("COMPANY");
            bool isAdminRoleExists = await _roleManager.RoleExistsAsync("ADMIN");
            bool isSupperAdminRoleExists = await _roleManager.RoleExistsAsync("SUPERADMIN");

            if (isCustomerRoleExists && isCompanyRoleExists && isAdminRoleExists && isSupperAdminRoleExists)
                return new ResponseDto()
                {
                    IsSuccess = true,
                    DisplayMessage = "Roles Seeding is Already Done"
                };

            //await _roleManager.CreateAsync(new IdentityRole("USER"));
            await _roleManager.CreateAsync(new IdentityRole("JOBSEEKER"));
            await _roleManager.CreateAsync(new IdentityRole("COMPANY"));
            await _roleManager.CreateAsync(new IdentityRole("ADMIN"));
            await _roleManager.CreateAsync(new IdentityRole("SUPERADMIN"));

            return new ResponseDto()
            {
                IsSuccess = true,
                DisplayMessage = "Role Seeding Done Successfully"
            };
        }


        public async Task<AuthResponseModel> LoginAsync(LoginDto model)
        {
            var authModel = new AuthResponseModel();

            var user = await _userManager.FindByEmailAsync(model.Email);

            if (user is null || !await _userManager.CheckPasswordAsync(user, model.Password))
            {
                authModel.Message = "Email or Password is incorrect!";
                return authModel;
            }

            var jwtSecurityToken = await CreateJwtToken(user);
            var rolesList = await _userManager.GetRolesAsync(user);

            authModel.IsAuthenticated = true;
            authModel.Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken);
            authModel.Email = user.Email;
            authModel.Username = user.UserName;
            authModel.ExpiresOn = jwtSecurityToken.ValidTo;
            authModel.Roles = rolesList.ToList();

            return authModel;

        }
        public async Task<AuthResponseModel> RegisterAsync(RegisterDto model)
        {
            if (await _userManager.FindByEmailAsync(model.Email) is not null)
                return new AuthResponseModel { Message = "Email is already registered!" };

            if (await _userManager.FindByNameAsync(model.UserName) is not null)
                return new AuthResponseModel { Message = "Username is already registered!" };

            var user = new ApplicationUser
            {
                UserName = model.UserName,
                Email = model.Email,
                FirstName = model.FirstName,
                LastName = model.LastName,
                UserTypeId = model.UserTypeId
            };

            var result = await _userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                var errors = new StringBuilder();
                foreach (var error in result.Errors)
                    errors.Append($"{error.Description},");

                return new AuthResponseModel { Message = errors.ToString() };
            }

            if (model.UserTypeId == 1)
            {
                await _userManager.AddToRoleAsync(user, "JOBSEEKER");
            }
            else if (model.UserTypeId == 2)
            {
                await _userManager.AddToRoleAsync(user, "COMPANY");
            }


            var jwtSecurityToken = await CreateJwtToken(user);

            return new AuthResponseModel
            {
                Email = user.Email,
                ExpiresOn = jwtSecurityToken.ValidTo,
                IsAuthenticated = true,
                Roles = model.UserTypeId == 1 ?
                            new List<string> { "JOBSEEKER" } :
                            model.UserTypeId == 2 ?
                            new List<string> { "COMPANY" } :
                            new List<string>(),
                Token = new JwtSecurityTokenHandler().WriteToken(jwtSecurityToken),
                Username = user.UserName
            };
        }

        private async Task<JwtSecurityToken> CreateJwtToken(ApplicationUser user)
        {
            var userClaims = await _userManager.GetClaimsAsync(user);
            var userRoles = await _userManager.GetRolesAsync(user);

            var roleClaims = userRoles.Select(r => new Claim("roles", r)).ToList();

            var claims = new[]
            {
                new Claim(JwtRegisteredClaimNames.Sub, user.UserName),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                new Claim(JwtRegisteredClaimNames.Email, user.Email),
                new Claim("uid", user.Id)
            }
            .Union(userClaims)
            .Union(roleClaims);

            var symmetricSecurityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["JWT:Key"]!));
            var signingCredentials = new SigningCredentials(symmetricSecurityKey, SecurityAlgorithms.HmacSha256);

            var jwtSecurityToken = new JwtSecurityToken(
                issuer: _configuration["JWT:ValidIssuer"],
                audience: _configuration["JWT:ValidAudience"],
                claims: claims,
                expires: DateTime.Now.AddDays(int.Parse(_configuration["JWT:DurationInDays"]!)),
                signingCredentials: signingCredentials);

            return jwtSecurityToken;
        }



        public async Task<bool> DeleteUserAsync(string id)
        {
            var result = await _db.Users.Where(x => x.IsDeleted == false).Where(x => x.Id == id).FirstOrDefaultAsync();

            if (result is null) return false;

            result.IsDeleted = true;
            result.DateDeleted = DateTime.Now;
            var count = await _db.SaveChangesAsync();

            return count >0 ? true : false;
        }

        public async Task<IEnumerable<ResponseUserDetailsDto>> GetAllUsersAsync()
        {
            var users = await _db.Users.Where(x => x.IsDeleted == false).ToListAsync();

            var usersResponseDto = _mapper.Map<IEnumerable<ResponseUserDetailsDto>>(users);

            return usersResponseDto;
        }

        public async Task<ResponseUserDetailsDto?> GetUserByIdAsync(string id)
        {
            var user = await _db.Users.Where(x => x.IsDeleted == false).Where(x => x.Id == id).FirstOrDefaultAsync();

            var userResponseDto = _mapper.Map<ResponseUserDetailsDto>(user);

            return userResponseDto;
        }

        public async Task<ResponseUserDetailsDto?> UpdateUserAsync(UpdateUserDetailsDto Dto)
        {
            var currentUser = await _db.Users.Where(x => x.IsDeleted == false).FirstOrDefaultAsync(x => x.Id == Dto.Id);

            if (currentUser is null) return null;

            currentUser.FirstName = Dto.FirstName;
            currentUser.LastName = Dto.LastName;
            currentUser.UserName = Dto.UserName;
            currentUser.PhoneNumber = Dto.PhoneNumber;

            _db.Entry(currentUser).State = EntityState.Modified;

            await _db.SaveChangesAsync();

            var responseUserDto = _mapper.Map<ResponseUserDetailsDto>(currentUser);

            return responseUserDto;
        }

        public Task<bool> ChangePassword(string userId, string password)
        {
            throw new NotImplementedException();
        }
    }
}
