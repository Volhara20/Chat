namespace Chat.Interfaces
{
    public interface IRepositoryWrapper
    {
        IUserRepository User { get; }
        IMessageRepository Message { get; }
        IGroupRepository Group { get; }
        void Save();
    }
}
