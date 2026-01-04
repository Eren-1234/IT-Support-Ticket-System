using Microsoft.EntityFrameworkCore;
using DestekSistemi.Models; // Senin DbContext'in burada

var builder = WebApplication.CreateBuilder(args);

// 1. DEÐÝÞÝKLÝK: RazorPages yerine MVC servisini ekliyoruz
builder.Services.AddControllersWithViews();

// Veritabaný servisi (Senin yazdýðýn aynen kalýyor)
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error"); // Hata olursa Home'a git
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

// 2. DEÐÝÞÝKLÝK: MapRazorPages yerine Controller rotasýný çiziyoruz
// Bu kod, açýlýþta direkt HomeController -> Index aksiyonuna gitmesini saðlar.
app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();