using MentorAppTask.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
   
// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<MentorAppDbContext>(options =>
{
    options.UseSqlServer("Server=DESKTOP-OE316RB;Database=MentorApp;TrustServerCertificate=True;Trusted_Connection=True;");
});

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapDefaultControllerRoute();

app.Run();
