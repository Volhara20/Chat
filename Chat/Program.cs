using Chat.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ApplicationSettings settings = new ApplicationSettings(builder.Configuration);
builder.Services.AddSingleton(settings);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(settings.DbConnection);
});


builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();