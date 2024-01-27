using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace WebApplication1.Pages
{
    public class CinemaModel : PageModel
    {
        public class Film
        {
            public string? Name { get; set; }
            public string? Author { get; set; }
            public string? Style { get; set; }
			public string? Description { get; set; }
            public List<string>? ShowList { get; set;}
		}

        public static List<Film>? FilmList {  get; set; }

        public void OnGet()
        {
            FilmList = new List<Film>() { new Film() { Name = "Ґолда", Author = "", Style = "", Description = "", ShowList = new List<string>() { "12:10 - 180/200/250 ₴", "18:00 - 180/200/250 ₴" } }, new Film() { Name = "Історія Тіто та Вінні", Author = "", Style = "", Description = "", ShowList = new List<string>(){ "12:10 - 180/200/250 ₴", "14:10 - 180/200/250 ₴" } } };
        }
    }
}
