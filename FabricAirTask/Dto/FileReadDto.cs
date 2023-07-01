using FabricAirTask.Entity;

namespace FabricAirTask.Dto
{
    public class FileReadDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string FileType { get; set; }     
        public int UserId { get; set; }
    }
}
