using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Models.DboModels
{
    [Table("Users")]
    public class User
    {
        [Key]
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
