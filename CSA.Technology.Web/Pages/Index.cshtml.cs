using System.Threading.Tasks;
using CSA.Technology.Web.Facade;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace multi.layer.web.Pages
{
    public class IndexModel : PageModel
    {
        private readonly IApiFacade _facade;

        public IndexModel(IApiFacade facade)
        {
            _facade = facade;
        }
        public string Message { get; private set; } = "Message from API: ";
        public async Task OnGet()
        {
            Message += await _facade.GetMessageAsync().ConfigureAwait(false);
        }
    }
}
