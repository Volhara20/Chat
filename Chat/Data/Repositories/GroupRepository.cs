using Chat.Interfaces;
using Chat.Models.DboModels;

namespace Chat.Data.Repositories
{
    public class GroupRepository : RepositoryBase<Group>, IGroupRepository
    {
        public GroupRepository(ApplicationContext context) : base(context)
        {

        }
    }
}
