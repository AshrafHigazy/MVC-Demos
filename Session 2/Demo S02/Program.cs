namespace Demo_S02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            #region Configure App Services
            builder.Services.AddControllersWithViews();
            #endregion
            var app = builder.Build();

            #region Configure Middlewars
            app.UseRouting();//Middleware for Routing
            app.MapControllerRoute // Get Ready for Read the controllers
                (
                    name: "default",
                    pattern: "{controller=Home}/{action=Index}/{id?}"
                );
            app.UseStaticFiles(); //wwwroot
            ////Route -> Get
            ////Minimal API
            //app.MapGet("/", () => "Hello World!"); 
            ////Static Segement
            //app.MapGet("/Higzo", () => "Hello Higzo!");
            ////Variable Segment
            //app.MapGet("/Higzo/{name}", async contex =>
            //{   
            //    var name = contex.Request.RouteValues["name"];
            //    await contex.Response.WriteAsync($"Hello {name}");
            //});
            #endregion

            app.Run();
        }
    }
}
