using Microsoft.EntityFrameworkCore;
using PolovniAutomobiliMVC.Models;
using Microsoft.AspNetCore.Identity;

namespace PolovniAutomobiliMVC
{
    public class Program
	{
		public static void Main(string[] args)
		{
			var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddDbContext<AppDbContext>(options => options.UseSqlServer(
			builder.Configuration.GetConnectionString("DefaultConnection")
			));

            // Dodavanje osnovne autentikacije
            builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
                            .AddEntityFrameworkStores<AppDbContext>();

            builder.Services.AddScoped<ICarRepository,CarRepository>();
			builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
            builder.Services.AddScoped<IOrderRepository, OrderRepository>();

            builder.Services.AddScoped<ShoppingCart>(sp => ShoppingCart.GetCart(sp));
            builder.Services.AddHttpContextAccessor();
            builder.Services.AddSession(); // Dodavanje sesija za praæenje stanja korpe

            // Add services to the container.
            builder.Services.AddControllersWithViews();
			builder.Services.AddRazorPages();

			var app = builder.Build();

			// Configure the HTTP request pipeline.
			if (!app.Environment.IsDevelopment())
			{
				app.UseExceptionHandler("/Home/Error");
				// The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
				app.UseHsts();
			}

			app.UseHttpsRedirection();
			app.UseStaticFiles();
			app.UseSession();
			app.UseRouting();

			app.UseAuthentication();
			app.UseAuthorization();

			app.MapControllerRoute(
				name: "default",
				pattern: "{controller=Home}/{action=Index}/{id?}");

			app.MapRazorPages();

			app.Run();
		}
	}
}