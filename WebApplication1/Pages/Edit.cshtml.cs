using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class EditModel : PageModel
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

            for(int i = 0; i<Program.Movies.Count; i++)
            {
                if (Program.Movies[i].Name == Movie.Name) { Program.Movies[i] = Movie; }
            }

            return RedirectToPage("./add");
        }
    }
}
