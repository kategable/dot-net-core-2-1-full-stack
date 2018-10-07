using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace multi.layer.web.Facade
{
    public interface IApiFacade
    {
        Task<string> GetMessageAsync();
    }
}
