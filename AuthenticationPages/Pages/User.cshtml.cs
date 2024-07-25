using AuthenticationPages.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Identity.Client;

namespace AuthenticationPages.Pages;

[Authorize]
public class UserModel : PageModel
{
    private readonly UserManager<ApplicationUser> _userManager;

    public ApplicationUser? appUser;

    public UserModel(UserManager<ApplicationUser> userManager)
    {
        _userManager = userManager;
    }
    public void OnGet()
    {
        //Lê os detalhes do usuário
        var task = _userManager.GetUserAsync(User);
        task.Wait();
        appUser = task.Result;
    }
}
