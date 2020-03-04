using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Piranha;

namespace Test.Models
{
    public class LoginPageModel : Microsoft.AspNetCore.Mvc.RazorPages.PageModel
    {
        private readonly ISecurity security;
        [BindProperty]
        public string Username { get; set; }
        [BindProperty]
        public string Password { get; set; }

        public LoginPageModel(ISecurity security) : base()
        {
            this.security = security;
        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid && await security.SignIn(HttpContext, Username, Password))
                return new RedirectResult("/");

            return Page();
        }
    }
}