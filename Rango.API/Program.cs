using Microsoft.EntityFrameworkCore;
using Rango.API.DbContexts;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<RecipesDbContext>( 
    o => o.UseSqlite(builder.Configuration["ConnectionStrings:RecipeDbConnectionString"])
);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
