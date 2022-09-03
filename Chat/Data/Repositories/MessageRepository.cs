using Chat.Interfaces;
using Chat.Models.DboModels;

namespace Chat.Data.Repositories
{
    public class MessageRepository : RepositoryBase<Message>, IMessageRepository
    {
        public MessageRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
