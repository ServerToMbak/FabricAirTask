namespace FabricAirTask.Entity
{
    public class File
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public FileType FileType { get; set; }
        public User User { get; set; }      
        public int UserId { get; set; }
    }
}
