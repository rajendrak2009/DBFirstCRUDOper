using DBFirstCRUDOper.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<DBFirstCRUDOperContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DBFirstCRUDOperContext") ?? throw new InvalidOperationException("Connection string 'DBFirstCRUDOperContext' not found.")));

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddDbContext<ApplicationDBContext>(
    options=>options.UseSqlServer( 
    builder.Configuration.GetConnectionString("DefaultConnection")
));
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
