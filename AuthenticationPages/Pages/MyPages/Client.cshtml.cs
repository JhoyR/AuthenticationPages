using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AuthenticationPages.Pages
{
    [Authorize(Roles = "viewer, admin")]
    public class ClientModel : PageModel
    {
        public void OnGet()
        {
        }
    }
}
