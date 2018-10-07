using multi.layer.utility;
using System;

namespace multi.layer.dataaccess
{
    public class ValuesRepository : IValuesRepository
    {
        private readonly IConfig _config;

        public ValuesRepository(IConfig config)
        {
            _config = config;
        }

        public string GetById(int id)
        {
            if (string.IsNullOrEmpty(_config.ConnectionString))
            {
                return _config.ShowThis;
            }

            return "data from database";
        }
    }
}
