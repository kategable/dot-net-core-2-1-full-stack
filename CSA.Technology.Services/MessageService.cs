using CSA.Technology.Core;

namespace CSA.Technology.Services
{
    public class MessageService : IMessageService
    {
        private readonly IMessageRepository _repository;

        public MessageService(IMessageRepository repository)
        {
            _repository = repository;
        }  

        public string GetMessage()
        {
            return _repository.GetMessage();
        }
    }
}
