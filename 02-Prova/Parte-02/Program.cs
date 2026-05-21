using Microsoft.EntityFrameworkCore;
using DC.Contexts;
using DC.Endpoints;
using DC.Services;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<DCContext>(options =>
{

    var host = Environment.GetEnvironmentVariable("DB_HOST");
    var port = Environment.GetEnvironmentVariable("DB_PORT");
    var dtbs = Environment.GetEnvironmentVariable("DB_DB");
    var user = Environment.GetEnvironmentVariable("DB_USER");
    var pass = Environment.GetEnvironmentVariable("DB_PASS");
    
    var sqlConn = $"Server={host},{port};Database={dtbs};User Id={user};Password={pass};TrustServerCertificate=True";
    options.UseSqlServer(sqlConn);
});

builder.Services.AddTransient<HeroService>();

var app = builder.Build();
using (var scope = app.Services.CreateScope())
{
    var db = scope.ServiceProvider.GetRequiredService<DCContext>();
    db.Database.Migrate();
}

app.ConfigureHeroEndpoints();
app.Run();