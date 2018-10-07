using System;
using System.Threading.Tasks;
using Flurl;
using Flurl.Http;

namespace CSA.Technology.Web.Facade
{
    public class ApiFacade : IApiFacade
    {
        public async Task<string> GetMessageAsync()
        {
            try
            {
                var result = await "https://localhost:44341"
                    .AppendPathSegments("api")
                    .AppendPathSegments("values", 2).GetStringAsync();
                return result;
            }
            catch (Exception e)
            {

                return e.Message;
            }

        }
    }
}