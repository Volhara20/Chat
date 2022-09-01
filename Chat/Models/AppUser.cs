namespace Chat.Models
{
    public class AppUser
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public DateTime Created { get; set; }
        public DateTime? Updated { get; set; }
        public ICollection<AppGroup> Groups { get; set; }
    }
}
