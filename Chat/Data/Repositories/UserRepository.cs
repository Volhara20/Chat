using Chat.Models.DboModels;
using Microsoft.EntityFrameworkCore;

namespace Chat.Data.Repositories
{
    public class UserRepository
    {
        private readonly ApplicationContext _context;

        public UserRepository(ApplicationContext context)
        {
            _context = context;
        }

        public async Task<ICollection<User>> GetUsers()
        {
            return await _context.Users.Include("Groups").ToListAsync();
        }

        public async Task<User> CreateUser(User user)
        {
            var createdUser = await _context.Users.AddAsync(user);
            return createdUser.Entity;
        }

        public Task<User> UpdateUser(User user)
        {
            var updatedUser = _context.Users.Update(user);
            return Task.FromResult(updatedUser.Entity);
        }

        public Task DeleteUser(User user)
        {
            _context.Users.Remove(user);
            return Task.CompletedTask;
        }
    }
}
