using Chat.Data.Repositories;
using Chat.Models.DtoModels.User;
using Chat.Models;
using Microsoft.AspNetCore.Mvc;
using AutoMapper;
using Chat.Models.DtoModels.Message;

namespace Chat.Controllers
{
    [ApiController]
    [Route("[controller]/[action]")]
    public class MessageController
    {
        private readonly MessageRepository _messageRepository;
        private readonly IMapper _mapper;

        public MessageController(MessageRepository messageRepository, IMapper mapper)
        {
            _messageRepository = messageRepository;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<GetMessagesResponse> GetMessages()
        {
            ICollection<Models.DboModels.Message> messages = await _messageRepository.GetMessages();

            GetMessagesResponse response = new GetMessagesResponse
            {
                Messages = _mapper.Map<List<AppMessage>>(messages)
            };

            return response;
        }
    }
}
