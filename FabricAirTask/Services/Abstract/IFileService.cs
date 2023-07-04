using FabricAirTask.Dto;
using FabricAirTask.Entity;

namespace FabricAirTask.Services.Abstract
{
    public interface IFileService
    {
        public FileReadDto AddFile(int userId,FileCreateDto file);
        public List<FileReadDto> GetAll();
        public UserFilesDto GetAllFilesByUserName(string userName);
        public UserFilesDto GetFilesByUserNameWithSeperateType(FileType fileType, string userName);
    }
}
