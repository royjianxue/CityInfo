using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.StaticFiles;

namespace CityInfo.API.Controllers
{
    [Route("api/files")]
    [ApiController]
    public class FilesController : ControllerBase
    {

        private readonly FileExtensionContentTypeProvider _fileExtensionContentProvider;

        public FilesController(FileExtensionContentTypeProvider fileExtensionContentProvider)
        {
            _fileExtensionContentProvider = fileExtensionContentProvider ?? throw new System.ArgumentException(nameof(fileExtensionContentProvider));
        }

        [HttpGet("{fileId}")]
        public ActionResult GetFile(string fileId)
        {
            //look up the actual file, depending on the fileId...
            //demo code
            var pathToFile = "test.pdf";

            //check whether the file exist
            if (!System.IO.File.Exists(pathToFile))
            {
                return NotFound();
            }

            if (!_fileExtensionContentProvider.TryGetContentType(pathToFile, out var contentType))
            {
                contentType = "application/octet-stream";
            }

            var bytes = System.IO.File.ReadAllBytes(pathToFile);

            return File(bytes, contentType, Path.GetFileName(pathToFile));

        }
    }
}
