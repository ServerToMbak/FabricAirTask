using FabricAirTask.Data;
using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Data;

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

        [HttpPost("{userId}")]
        public ActionResult<FileReadDto> AddFile(int userId, FileCreateDto file) 
        {
            var response = _fileService.AddFile(userId,file);
            return Ok(response);
        }
        [HttpGet]
        public ActionResult<List<FileReadDto>> GetFiles()//Get All Group of files request
        {
            return Ok(_fileService.GetAll());
        }
        [Authorize(Roles = "Admin")]
        [HttpGet("getbyusername")]
        public ActionResult<UserFilesDto> GetFilesByUserName(string name)
        {
            var response = _fileService.GetAllFilesByUserName(name);

            return Ok(response);
        }
        [HttpGet("userFilebyfiletype")]
        public ActionResult<UserFilesDto> GetFilesByUserNameWithSeperateType(FileType fileType, string userName)
        {
            var response = _fileService.GetFilesByUserNameWithSeperateType(fileType, userName);
            return Ok(response);
        }
    }
}
