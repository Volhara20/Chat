namespace Chat.Models
{
    public class AppGroup
    {
        public Guid Id { get; set; }
        public string GroupName { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
    }
}
