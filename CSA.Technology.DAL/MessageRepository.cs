using CSA.Technology.Core;

namespace CSA.Technology.DAL
{
    public class MessageRepository : IMessageRepository
    {
        private readonly IConfig _config;

        public MessageRepository(IConfig config)
        {
            _config = config;
        }

        public string GetMessage()
        {
            if (string.IsNullOrEmpty(_config.ConnectionString))
            {
                return _config.ShowThis;
            }

            return "data from database";
        }
    }
}
