using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Domain.Core.Techno_King.Service
{
    public interface IGeneralService
    {
        #region Upload
        public Task<string> UploadImage(IFormFile FormFile, string folderName, CancellationToken cancellation);
        public Task<string> ProductUploadImage(IFormFile formFile, string folderName, string productName, string customFileName, CancellationToken cancellationToken);
        #endregion
    }
}
