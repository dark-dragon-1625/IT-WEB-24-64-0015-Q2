using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using ABC_Academy.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<ABC_AcademyContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("ABC_AcademyContext") ?? throw new InvalidOperationException("Connection string 'ABC_AcademyContext' not found.")));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
