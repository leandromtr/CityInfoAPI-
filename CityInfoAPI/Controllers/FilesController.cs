using CityInfoAPI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfoAPI.Controllers
{
    [ApiController]
    [Authorize]
    [Route("api/files")]
    public class FilesController : Controller
    {
        private readonly FileExtensionContentTypeProvider _fileExtensionContentTypeProvider;

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            // Find city
            var pathToFile = "File.txt";

            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound(); 
            }

            if (!_fileExtensionContentTypeProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stram";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);
            return File(bytes, contentType, Path.GetFileName(pathToFile));
        }
    }
}
