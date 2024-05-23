using ForumRepositoryLayer.Repositories.Interfaces;
using ForumRepositoryLayer.Repositories;
using ForumRepositoryLayer.Services.Interfaces;
using ForumServiceLayer.Services.Interfaces;
using ForumServiceLayer.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddScoped<IPostService, PostService>();
builder.Services.AddScoped<IforumService, ForumService>();
builder.Services.AddScoped<ILikeService, LikeService>();
builder.Services.AddScoped<IResponseService, ResponseService>();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();
