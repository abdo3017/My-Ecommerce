
using Microsoft.AspNetCore.Http;

namespace BusinessLogic.Utils
{
    public interface IImageHandler
    {

        public string UploadImage(IFormFile imagefile,string path);
        public string RemoveImage(string imgPath);


    }
}
