using JobResearchSystem.Application.DTOs.Authentication;
using JobResearchSystem.Domain.Entities.Extend;

namespace JobResearchSystem.Application.IService
{
    public interface IAuthService
    {

        Task<ResponseDto> SeedRolesAsync();
        Task<AuthResponseModel> RegisterAsync(RegisterDto registerDto);
        Task<AuthResponseModel> LoginAsync(LoginDto loginDto);

        Task<IEnumerable<ResponseUserDetailsDto>> GetAllUsersAsync();
        Task<ResponseUserDetailsDto> GetUserByIdAsync(string id);


        Task<ApplicationUser> UpdateUserAsync(ApplicationUser Dto);
        Task DeleteUserAsync(string id);

        Task<bool> ChangePassword(string userId, string password);
        //ChangePassword





    }
}
