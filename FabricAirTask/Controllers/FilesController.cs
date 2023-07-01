using FabricAirTask.Data;
using FabricAirTask.Dto;
using FabricAirTask.Services;
using Microsoft.AspNetCore.Mvc;

namespace FabricAirTask.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class FilesController :ControllerBase
    {
        private IFileService _fileService;

        public FilesController(IFileService fileService)
        {
            _fileService = fileService;
        }

        [HttpPost]
        public ActionResult<Entity.File> AddFile(FileCreateDto file) 
        {
            var response = _fileService.AddFile(file);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult<List<FileReadDto>> GetFiles()
        {
            return Ok(_fileService.GetAll());
        }
        [HttpGet("getbyusername")]
        public ActionResult GetFilesByUserName(string name)
        {
            return Ok(_fileService.GetAllFilesByUserName(name));
        }
    }
}
