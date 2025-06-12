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

        public IList<User> Users { get; set; } = new List<User>();

        public void OnGet()
        {
            Users = _context.Users.ToList();
        }
    }
}
