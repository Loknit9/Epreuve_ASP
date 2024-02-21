using Shared_epreuve.Repositories;

namespace ASP_Epreuve
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddControllersWithViews();

            // ajout service par injection de dépendance:
            //BLL
            builder.Services.AddScoped<IProduitRepository<BLL_Epreuve.Entities.Produit>, BLL_Epreuve.Services.ProduitService>();


            //DAL
            builder.Services.AddScoped<IProduitRepository<DAL_Epreuve.Entities.Produit>, DAL_Epreuve.Services.ProduitService>();




            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Home/Error");
            }
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}