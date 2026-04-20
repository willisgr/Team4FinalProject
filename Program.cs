using Team4FinalProject.Data;
using Team4FinalProject.Interfaces;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddOpenApiDocument();
builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
builder.Services.AddControllers();
builder.Services.AddScoped<IGameContextDAO, GameContextDAO>();
<<<<<<< HEAD
builder.Services.AddScoped<ITeamMemberContextDAO, TeamMemberContextDAO>();
=======
builder.Services.AddScoped<IHobbyContextDAO, HobbyContextDAO>();

// Builders for adding the Interfaces and DAOs
//builder.Services.AddScoped<IGameContextDAO, GameContextDAO>();
//builder.Services.AddScoped<IGameContextDAO, GameContextDAO>();


>>>>>>> 550d4f63c236c7e4b115bbd264089b0e308fc060
var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var dbContext = scope.ServiceProvider.GetRequiredService<ApplicationDbContext>();
    await dbContext.Database.MigrateAsync();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseOpenApi();
    app.UseSwaggerUi();
}

app.UseHttpsRedirection();
app.MapControllers();
app.Run();