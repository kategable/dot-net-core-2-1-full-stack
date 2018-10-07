using CSA.Technology.Core;
using Microsoft.Extensions.Configuration;

namespace CSA.Technology.Utility
{
    public class Config : IConfig
    {
        public Config(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        readonly IConfiguration _configuration;
        public string ShowThis => _configuration["ShowThis"];
        public string ConnectionString => _configuration["ConnectionString"];
        


    }
}
