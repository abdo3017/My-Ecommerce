using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System.IO;

namespace BusinessLogic.Utils
{
    public class ImageHandler : IImageHandler
    {
        public string RemoveImage(string imgPath)
        {
            try
            {
                string DeletedPath = Directory.GetCurrentDirectory() + Constants.LOCAL_PATH + imgPath;
                if (System.IO.File.Exists(DeletedPath))
                {
                    System.IO.File.Delete(DeletedPath);
                }
                return  "Deleted";
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }

        public string UploadImage(IFormFile imageFile,string path)
        {

            try
            {
                // 1 ) Get Directory
                string FilePath = Directory.GetCurrentDirectory() + Constants.LOCAL_PATH + path;


                //2) Get File Name
                string FileName = Guid.NewGuid() + Path.GetFileName(imageFile.FileName);


                // 3) Merge Path with File Name
                string FinalPath = Path.Combine(FilePath, FileName);


                //4) Save File As Streams "Data Overtime"

                using (var Stream = new FileStream(FinalPath, FileMode.Create))
                {
                    imageFile.CopyTo(Stream);
                }


                return FileName;

            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
}
