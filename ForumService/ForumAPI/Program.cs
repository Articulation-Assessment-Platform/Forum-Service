using ForumRepositoryLayer.Entities;
using ForumRepositoryLayer.Repositories;
using ForumRepositoryLayer.Repositories.Interfaces;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Services;
using ForumServiceLayer.Services.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IforumService, ForumService>();
builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<IResponseService, ResponseService>();

builder.Services.AddScoped<IPostRepository, PostRepository>();
builder.Services.AddScoped<IForumRepository, ForumRepository>();
builder.Services.AddScoped<ILikeRepository, LikeRepository>();
builder.Services.AddScoped<IResponseRepository, ResponseRepository>();
builder.Services.AddControllers();


// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(c =>
{
    c.SwaggerDoc("v1", new() { Title = "Forum Service API", Version = "v1" });

});
builder.Services.AddDbContext<ForumContext>(options =>
{
    options.UseNpgsql(builder.Configuration.GetConnectionString("PostgreSqlConnection"));
});

var app = builder.Build();

app.UseHealthChecks("/health");

// Configure the HTTP request pipeline.

app.UseSwagger();
app.UseSwaggerUI();


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
