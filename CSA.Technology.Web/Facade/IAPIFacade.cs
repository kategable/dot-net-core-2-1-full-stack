using System.Threading.Tasks;

namespace CSA.Technology.Web.Facade
{
    public interface IApiFacade
    {
        Task<string> GetMessageAsync();
    }
}
