using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Services.Abstract
{
    public interface IFileService
    {
        public Task<FileReadDto> AddFile(int userId,FileCreateDto file);
        public Task<List<FileReadDto>> GetAll();
        public Task<UserFilesDto> GetAllFilesByUserName(string userName);
        public Task<UserFilesDto> GetFilesByUserNameWithSeperateType(FileType fileType, string userName);
    }
}
