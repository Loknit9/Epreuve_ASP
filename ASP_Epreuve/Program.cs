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
            builder.Services.AddScoped<IMediaRepository<BLL_Epreuve.Entities.Media>, BLL_Epreuve.Services.MediaService>();
            builder.Services.AddScoped < DAL_Epreuve.Services.CategorieService>();


            //DAL
            builder.Services.AddScoped<IProduitRepository<DAL_Epreuve.Entities.Produit>, DAL_Epreuve.Services.ProduitService>();
            builder.Services.AddScoped<IMediaRepository<DAL_Epreuve.Entities.Media>, DAL_Epreuve.Services.MediaService>();
            builder.Services.AddScoped<BLL_Epreuve.Services.CategorieService>();





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