using Chat.Data.Repositories;
using Chat.Interfaces;
using System.Security.Principal;

namespace Chat.Data
{
    public class RepositoryWrapper : IRepositoryWrapper
    {
        private ApplicationContext _applicationContext;
        private IUserRepository _user;
        private IMessageRepository _message;
        private IGroupRepository _group;

        public IUserRepository User
        {
            get
            {
                if (_user == null)
                {
                    _user = new UserRepository(_applicationContext);
                }
                return _user;
            }
        }

        public IMessageRepository Message
        {
            get
            {
                if (_message == null)
                {
                    _message = new MessageRepository(_applicationContext);
                }
                return _message;
            }
        }

        public IGroupRepository Group
        {
            get
            {
                if (_group == null)
                {
                    _group = new GroupRepository(_applicationContext);
                }
                return _group;
            }
        }

        public RepositoryWrapper(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }

        public void Save()
        {
            _applicationContext.SaveChanges();
        }
    }
}
