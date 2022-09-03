using Chat.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Chat.Models.DtoModels.Message;
using Chat.Interfaces;

namespace Chat.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MessageController
    {
        private readonly IRepositoryWrapper _repository;
        private readonly IMapper _mapper;

        public MessageController(IRepositoryWrapper repositoryWrapper, IMapper mapper)
        {
            _repository = repositoryWrapper;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<GetMessagesResponse> GetMessages()
        {
            ICollection<Models.DboModels.Message> messages = await _repository.Message.GetAll();

            GetMessagesResponse response = new GetMessagesResponse
            {
                Messages = _mapper.Map<List<AppMessage>>(messages)
            };

            return response;
        }
    }
}
