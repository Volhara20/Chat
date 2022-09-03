using Chat.Data;
using Chat.Data.Repositories;
using Chat.Interfaces;
using Chat.Mapping;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

ApplicationSettings settings = new ApplicationSettings(builder.Configuration);
builder.Services.AddSingleton(settings);

builder.Services.AddDbContext<ApplicationContext>(options =>
{
    options.UseLazyLoadingProxies();
    options.UseSqlServer(settings.DbConnection);
});

builder.Services.AddScoped<IRepositoryWrapper, RepositoryWrapper>();

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
