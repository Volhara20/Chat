using Chat.Data;
using Chat.Data.Repositories;
using Chat.Mapping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ApplicationSettings settings = new ApplicationSettings(builder.Configuration);
builder.Services.AddSingleton(settings);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseSqlServer(settings.DbConnection);
});

builder.Services.AddScoped<UserRepository>();
builder.Services.AddScoped<MessageRepository>();

builder.Services.AddControllers();

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddAutoMapper(typeof(MappingConfiguration));

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
