namespace FabricAirTask.Entity
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public DateTime DateCreated { get; set; } = DateTime.UtcNow;
        public string Role { get; set; } = "SalesPeople";
         public List<File> Files { get; set; } //when the user deleted all files will be deleted that's the purpose of this property
    }
}
