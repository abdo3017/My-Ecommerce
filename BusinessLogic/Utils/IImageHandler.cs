
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Utils
{
    public interface IImageHandler
    {

        public string UploadImage(IFormFile imagefile);
        public void RemoveImage(string imgPath);


    }
}
