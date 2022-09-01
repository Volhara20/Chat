using Chat.Models.DboModels;
using Microsoft.EntityFrameworkCore;

namespace Chat.Data.Repositories
{
    public class MessageRepository
    {
        private readonly ApplicationContext _context;

        public MessageRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<ICollection<Message>> GetMessages()
        {
            return await _context.Messages
                .Include(x => x.FromUser)
                .Include(x => x.FromUser.Groups)
                .Include(x => x.ToUser)
                .Include(x => x.Group)
                .Include(x => x.ReplyMessage)
                .ToListAsync();
        }

        public async Task<Message> CreateUser(Message message)
        {
            var createdMessage = await _context.Messages.AddAsync(message);
            return createdMessage.Entity;
        }

        public Task<Message> UpdateUser(Message message)
        {
            var updatedMessage = _context.Messages.Update(message);
            return Task.FromResult(updatedMessage.Entity);
        }

        public Task DeleteUser(Message message)
        {
            _context.Messages.Remove(message);
            return Task.CompletedTask;
        }
    }
}
