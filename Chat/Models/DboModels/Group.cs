using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Models.DboModels
{
    [Table("Groups")]
    public class Group
    {
        [Key]
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public ICollection<User> Users { get; set; }
    }
}
