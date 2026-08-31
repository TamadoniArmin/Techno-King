using App.Domain.Core.Techno_King.Service;
using Microsoft.AspNetCore.Http;
using System.Net.Http.Headers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Techno_KingService.Techno_King.Techno_GeneralService
{
    public class GeneralService : IGeneralService
    {
        #region Upload
        public async Task<string> UploadImage(IFormFile FormFile, string folderName, CancellationToken cancellation)
        {
            string filePath;
            string fileName;
            if (FormFile != null)
            {
                fileName = Guid.NewGuid().ToString() +
                           ContentDispositionHeaderValue.Parse(FormFile.ContentDisposition).FileName.Trim('"');
                filePath = Path.Combine($"wwwroot/images/{folderName}", fileName);
                try
                {
                    using (var stream = System.IO.File.Create(filePath))
                    {
                        await FormFile.CopyToAsync(stream, cancellation);
                    }
                }
                catch
                {
                    throw new Exception("Upload files operation failed");
                }
                return $"/images/{folderName}/{fileName}";
            }
            else
                fileName = "";

            return fileName;
        }
        public async Task<string> ProductUploadImage(IFormFile formFile,string folderName,string productName,string customFileName,CancellationToken cancellationToken)
        {
            if (formFile == null || formFile.Length == 0)
                return string.Empty;

            string safeProductName = string.Join("_", productName.Split(Path.GetInvalidFileNameChars()));


            string folderPath = Path.Combine($"wwwroot/images/{folderName}", safeProductName);


            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
            }


            string extension = Path.GetExtension(formFile.FileName);
            string fullFileName = $"{customFileName}{extension}";


            string filePath = Path.Combine(folderPath, fullFileName);

            try
            {
                using (var stream = System.IO.File.Create(filePath))
                {
                    await formFile.CopyToAsync(stream, cancellationToken);
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"Upload file operation failed for {fullFileName}", ex);
            }


            return $"/images/{folderName}/{safeProductName}/{fullFileName}";
        }


        #endregion
    }
}
