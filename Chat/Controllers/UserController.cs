using AutoMapper;
using Chat.Data.Repositories;
using Chat.Models;
using Chat.Models.DtoModels.User;
using Microsoft.AspNetCore.Mvc;

namespace Chat.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class UserController : ControllerBase
    {
        private readonly UserRepository _userRepository;
        private readonly IMapper _mapper;

        public UserController(UserRepository userRepository, IMapper mapper)
        {
            _userRepository = userRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<GetUsersResponse> GetUsers()
        {
            ICollection<Models.DboModels.User> users = await _userRepository.GetUsers();

            GetUsersResponse response = new GetUsersResponse
            {
                Users = _mapper.Map<List<AppUser>>(users)
            };

            return response;
        }
    }
}