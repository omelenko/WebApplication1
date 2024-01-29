using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Permissions;

namespace WebApplication1.Pages
{
    public class CinemaModel : PageModel
    {

        public static List<Film>? FilmList { get; set; } = default!;

        public void OnGet()
        {
            FilmList = Program.Movies;

            var movies = FilmList;
            if (!string.IsNullOrEmpty(SearchString))
            {
                movies = movies.Where(s => s.Name!.Contains(SearchString) || s.Author!.Contains(SearchString) || s.Style!.Contains(SearchString) || s.Description!.Contains(SearchString) || s.ShowList!.Contains(SearchString)).ToList();
            }

            FilmList = movies;
        }

        [BindProperty(SupportsGet = true)]
        public string? SearchString { get; set; }

        public SelectList? Genres { get; set; }

        [BindProperty(SupportsGet = true)]
        public string? MovieGenre { get; set; }
    }
}
