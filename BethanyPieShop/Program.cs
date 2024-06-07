using BethanyPieShop.Models;


namespace BethanyPieShop
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            //registering with DI container
            builder.Services.AddScoped<ICategoryRepository, MockCategoryRepository>();
            builder.Services.AddScoped<IPieRepository, MockPieRepository>();

            builder.Services.AddControllersWithViews(); //enabling ASP.NET Core MVC

            var app = builder.Build();// making application ready

            //middleware
            app.UseStaticFiles(); //look for incoming request for static files and returns

            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage(); //show exception page that user can not see
            }

            app.MapDefaultControllerRoute(); //sets some defaults used in MVC to route to the pages/views - endpoint middleware
            

            app.Run();
        }
    }
}
