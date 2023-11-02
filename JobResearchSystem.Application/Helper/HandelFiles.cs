using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace JobResearchSystem.Application.Helper
{
    public static class HandelFiles
    {
        // private static readonly IConfiguration config;

        public static async Task<(bool, string)> UploadImage(IFormFile file)
        {
            try
            {
                string FolderPath = Directory.GetCurrentDirectory();
                string FileName = Guid.NewGuid() + Path.GetFileName(file.FileName);

                var imageAllowedExtensions = new string[] { ".jpg", ".jpeg", ".png" };
                var cvAllowedExtensions = new string[] { ".pdf" };

                //Upload Image
                if ((!imageAllowedExtensions.Contains(Path.GetExtension(file.FileName))) || (!cvAllowedExtensions.Contains(Path.GetExtension(file.FileName)))) //Check Extention
                {
                    return (false, "Unsupported file extension");
                }
                if (!(file.Length <= 5 * 1024 * 1024)) //Check Image Size
                {
                    return (false, "Image size Can't be Greater than 5 MB");
                }

                using IHost host = Host.CreateDefaultBuilder().Build();
                IConfiguration config = host.Services.GetRequiredService<IConfiguration>();

                if (!imageAllowedExtensions.Contains(Path.GetExtension(file.FileName)))
                {
                    FolderPath = FolderPath + config["FilePaths:ImagesPath"]; // get Storage Location from App Setting
                }

                if (!cvAllowedExtensions.Contains(Path.GetExtension(file.FileName)))
                {
                    FolderPath = FolderPath + config["FilePaths:CvsPath"]; // get Storage Location from App Setting
                }




                var FinalPath = Path.Combine(FolderPath, FileName);

                using (var stream = new FileStream(FinalPath, FileMode.Create))
                {
                    file.CopyTo(stream);
                }
                return (true, FileName);
            }
            catch (Exception ex)
            { return (false, ex.Message); }
        }

        ////////////////////////////////////////////////////////////////////////

        public static async Task RemoveImage(string FileName)
        {
            string CurrentDirectory = Directory.GetCurrentDirectory();

            //Remove Image
            using IHost host = Host.CreateDefaultBuilder().Build();

            IConfiguration config = host.Services.GetRequiredService<IConfiguration>();
            string FolderPath = config["FilePaths:BookImagePath"];

            var path = CurrentDirectory + Path.Combine(FolderPath, FileName);

            if (File.Exists(path))
            {
                File.Delete(path);
            }
        }

    }
}
