using WebApplication1;

internal class Program
{
    public static List<Film> Movies = new List<Film>() { new Film() { Name = "Ґолда", Author = "", Style = "", Description = "", ShowList = "12:10 - 180/200/250 ₴, 18:00 - 180/200/250 ₴" }, new Film() { Name = "Історія Тіто та Вінні", Author = "", Style = "", Description = "", ShowList = "12:10 - 180/200/250 ₴, 14:10 - 180/200/250 ₴" } };
    private static void Main(string[] args)
    {
        
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        builder.Services.AddRazorPages();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();

        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapRazorPages();

        //app.MapGet("/cinema", () => { return Results.Content(File.ReadAllText("Pages/Cinema.cshtml"), "text/cshtml"); });

        app.Run();
    }
}