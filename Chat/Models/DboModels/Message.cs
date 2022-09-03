using System.ComponentModel.DataAnnotations.Schema;

namespace Chat.Models.DboModels
{
    [Table("Messages")]
    public class Message
    {
        public Guid Id { get; set; }
        public string Text { get; set; }
        public Guid FromUserId { get; set; }
        [ForeignKey("FromUserId")]
        public virtual User FromUser { get; set; }
        public Guid? ToUserId { get; set; }
        [ForeignKey("ToUserId")]
        public virtual User ToUser { get; set; } = null;
        public Guid? GroupId { get; set; }
        [ForeignKey("GroupId")]
        public virtual Group Group { get; set; } = null;
        public bool IsVisible { get; set; }
        public bool IsVisibleForOwner { get; set; }
        public Guid? ReplyMessageId { get; set; }
        [ForeignKey("ReplyMessageId")]
        public virtual Message ReplyMessage { get; set; } = null;
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
