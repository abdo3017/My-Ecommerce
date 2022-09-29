using System;
using Microsoft.AspNetCore.Hosting;
using System.IO;

namespace BusinessLogic.Utils
{
    public class ImageHandler : IImageHandler
    {


        private readonly Microsoft.AspNetCore.Hosting.IWebHost webHostEnvironment;
        public ImageHandler(IWebHost webhost)
        {
            webHostEnvironment = webhost;

        }
        public void RemoveImage(string imgPath)
        {
            string image = Path.Combine(webHostEnvironment., "images", imgPath);
            FileInfo fi = new FileInfo(image);
            if (fi != null)
            {
                System.IO.File.Delete(image);
                fi.Delete();
            }
        }

        public string UploadImage(string product)
        {
            string uniqueFileName = null;

            //if (product.ImageFile != null)
            //{
            //    string uploadsFolder = Path.Combine(webHostEnvironment.WebRootPath, "images");
            //    uniqueFileName = Guid.NewGuid().ToString() + "_" + product.ImageFile.FileName;
            //    string filePath = Path.Combine(uploadsFolder, uniqueFileName);
            //    using (var fileStream = new FileStream(filePath, FileMode.Create))
            //    {
            //        product.ImageFile.CopyTo(fileStream);

            //    }

            //}

            return uniqueFileName;
        }
    }
}
