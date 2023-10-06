using Fiap.Web.App.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

//conexao
var connection = builder.Configuration.GetConnectionString("conexao");
builder.Services.AddDbContext<LojaContext>(options => options.UseSqlServer(connection));

// Add services to the container.
builder.Services.AddControllersWithViews();

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
    pattern: "{controller=Produto}/{action=Cadastrar}/{id?}");
    //pattern: "{controller=Cliente}/{action=Index}/{id?}");

app.Run();
