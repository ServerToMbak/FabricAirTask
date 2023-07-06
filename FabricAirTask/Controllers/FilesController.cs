using FabricAirTask.Data;
using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services.Abstract;
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
        public async Task<ActionResult<FileReadDto>> AddFile(int userId, FileCreateDto file) 
        {
            var response =await _fileService.AddFile(userId,file);
            return Ok(response);
        }
        [HttpGet]
        public async Task<ActionResult<List<FileReadDto>>> GetFiles()//Get All Group of files request
        {
            return Ok(await _fileService.GetAll());
        }
        //[Authorize(Roles = "Admin")]
        [HttpGet("getbyusername")]
        public async Task<ActionResult<UserFilesDto>> GetFilesByUserName(string name)
        {
            var response =await _fileService.GetAllFilesByUserName(name);

            return Ok(response);
        }
        [HttpGet("userFilebyfiletype")]
        public async Task<ActionResult<UserFilesDto>> GetFilesByUserNameWithSeperateType(FileType fileType, string userName)
        {
            var response =await _fileService.GetFilesByUserNameWithSeperateType(fileType, userName);
            return Ok(response);
        }
    }
}
