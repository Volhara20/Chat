using AutoMapper;
using Chat.Interfaces;
using Chat.Models;
using Chat.Models.DtoModels.User;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public UserController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repository = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<GetUsersResponse> GetUsers()
        {
            ICollection<Models.DboModels.User> users = await _repository.User.GetAll();

            GetUsersResponse response = new GetUsersResponse
            {
                Users = _mapper.Map<List<AppUser>>(users)
            };

            return response;
        }
    }
}