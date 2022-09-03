using Chat.Interfaces;
using Chat.Models.DboModels;

namespace Chat.Data.Repositories
{
    public class UserRepository : RepositoryBase<User>, IUserRepository
    {
        public UserRepository(ApplicationContext context) : base(context)
        {
        }
    }
}
