using Microsoft.EntityFrameworkCore;
using Pratik_CodeFirstBasic.Data;

var builder = WebApplication.CreateBuilder(args);

// Add DbContext with Dependency Injection
builder.Services.AddDbContext<PatikaFirstDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")
                         ?? "Server=DESKTOP-MQI8H1N\\SQLEXPRESS;Database=PatikaCodeFirstDb1;Trusted_Connection=True;"));

var app = builder.Build();

// Initialize Database (optional migration step)
using (var scope = app.Services.CreateScope())
{
    var context = scope.ServiceProvider.GetRequiredService<PatikaFirstDbContext>();
    context.Database.Migrate();
}

app.Run();
