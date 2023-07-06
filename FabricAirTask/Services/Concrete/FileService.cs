using AutoMapper;
using AutoMapper.Internal.Mappers;
using FabricAirTask.Data.Abstract;
using FabricAirTask.Dto;
using FabricAirTask.Entity;
using FabricAirTask.Services.Abstract;
using System.Linq;
namespace FabricAirTask.Services.Concrete
{
    public class FileService : IFileService
    {
        private IFileRepo _fileRepo;
        private IMapper _mapper;
        private IUserService _userService;

        public FileService(IFileRepo fileRepo, IMapper mapper, IUserService userService)
        {
            _fileRepo = fileRepo;
            _mapper = mapper;
            _userService = userService;
        }
        public async Task<FileReadDto> AddFile(int userId, FileCreateDto fileCreateDto)
        {
            var file = _mapper.Map<Entity.File>(fileCreateDto);
            file.UserId = userId;
            await _fileRepo.Add(file);
            var fileReadDto = _mapper.Map<FileReadDto>(file);

            return fileReadDto;

        }

        public async Task<List<FileReadDto>> GetAll()
        {
            var files = _mapper.Map<List<FileReadDto>>(await _fileRepo.GetAll());
            return files;
        }

        public async Task<UserFilesDto> GetAllFilesByUserName(string userName)
        {

            var result =await _userService.GetUserByName(userName);
            var files =await _fileRepo.GetFilesByUserId(result.Id);
            var fileRead = _mapper.Map<List<FileReadDto>>(files);

            return new UserFilesDto
            {
                Id = result.Id,
                Email = result.Email,
                Name = result.Name,
                Role = result.Role,
                Files = fileRead
            };
        }

        public async Task<UserFilesDto> GetFilesByUserNameWithSeperateType(FileType fileType, string userName)
        {
            var result =await _userService.GetUserByName(userName);
            var files = await _fileRepo.GetFilesByUserIdAndByFileType(fileType,result.Id);

            var fileRead = _mapper.Map<List<FileReadDto>>(files);

            return new UserFilesDto
            {
                Id = result.Id,
                Email = result.Email,
                Name = result.Name,
                Role = result.Role,
                Files = fileRead
            };
        }
    }
}
