using Blueweb.Data;
using Blueweb.Models;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace Blueweb.Pages
{
    public class UsersPage : PageModel
    {
        private readonly Context _context;

        public UsersPage(Context context)
        {
            _context = context;
        }

        public IList<UsersPage> Users { get; set; }

        public void OnGet()
        {
            Users = (IList<UsersPage>)_context.Users.ToList();
        }
    }
}
