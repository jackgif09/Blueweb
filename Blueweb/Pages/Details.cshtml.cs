using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using Blueweb.Models;
using Blueweb.Data;

namespace Blueweb.Pages.Details
{
    public class DetailsModel : PageModel
    {
        private readonly Context _context;

        public DetailsModel(Context context)
        {
            _context = context;
        }

        public User User { get; set; } = default!;
        public List<UserPost> Posts { get; set; } = new();

        public async Task<IActionResult> OnGetAsync(int id)
        {
            User = await _context.Users
                .Include(u => u.Posts)
                .FirstOrDefaultAsync(u => u.ID == id);

            if (User == null)
            {
                return NotFound();
            }

            Posts = User.Posts
                .OrderByDescending(p => p.CreatedAt)
                .ToList();

            return Page();
        }
    }
}
