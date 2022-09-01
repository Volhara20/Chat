using Chat.Models.DboModels;
using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Models
{
    public class AppMessage
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid FromUserId { get; set; }
        [ForeignKey("FromUserId")]
        public AppUser FromUser { get; set; }
        public Guid? ToUserId { get; set; }
        [ForeignKey("ToUserId")]
        public AppUser ToUser { get; set; } = null;
        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public AppGroup Group { get; set; } = null;
        public bool IsVisible { get; set; }
        public bool IsVisibleForOwner { get; set; }
        public Guid? ReplyMessageId { get; set; }
        [ForeignKey("ReplyMessageId")]
        public AppMessage ReplyMessage { get; set; } = null;
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
