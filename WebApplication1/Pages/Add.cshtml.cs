using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class AddModel : PageModel
    {
        public List<Film> FilmList { get; set; } = default!;
        public void OnGet()
        {
            FilmList = Program.Movies;
        }
    }
}
