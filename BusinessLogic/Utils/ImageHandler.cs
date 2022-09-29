using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BusinessLogic.Utils
{
    public class ImageHandler : IImageHandler
    {


        private readonly IHostingEnvironment webHostEnvironment;
        public ImageHandler(IHostingEnvironment webhost)
        {
            webHostEnvironment = webhost;
        }
        public void RemoveImage(string imgPath)
        {
            string image = Path.Combine(webHostEnvironment.WebRootPath, "images", imgPath);
            FileInfo fi = new FileInfo(image);
            if (fi != null)
            {
                System.IO.File.Delete(image);
                fi.Delete();
            }
        }

        public string UploadImage(IFormFile imageFile)
        {
            string uniqueFileName = null;

            if (imageFile != null)
            {
                string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + imageFile.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    imageFile.CopyTo(fileStream);
                }
            }

            return uniqueFileName;
        }
    }
}
