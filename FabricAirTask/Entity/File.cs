using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FabricAirTask.Entity
{
    public class File
    {
        
        public int Id { get; set; }
        public string Name { get; set; }
        public FileType FileType { get; set; }
        public User User { get; set; }
    }
}
