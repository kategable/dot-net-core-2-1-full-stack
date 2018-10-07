using Microsoft.Extensions.Configuration;

namespace multi.layer.utility
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
