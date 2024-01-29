using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class CreateModel : PageModel
    {

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Film Movie { get; set; } = default!;

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid || Movie == null)
            {
                return Page();
            }

            Program.Movies.Add(Movie);

            return RedirectToPage("./Index");
        }
    }
}
