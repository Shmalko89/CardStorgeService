using CardStorageService.Data;
using CardStorgeService.Models;
using CardStorgeService.Services;
using CardStorgeService.Services.Impl;
using Microsoft.AspNetCore.HttpLogging;
using Microsoft.EntityFrameworkCore;
using NLog.Web;

var builder = WebApplication.CreateBuilder(args);
#region Configure Options Service

builder.Services.Configure<DataBaseOptions>(options =>
{
    builder.Configuration.GetSection("Settings:DataBaseOptions").Bind(options);
});

#endregion


#region   Logging service

builder.Services.AddHttpLogging(logging =>
{
    logging.LoggingFields = HttpLoggingFields.All | HttpLoggingFields.RequestQuery;
    logging.RequestBodyLogLimit = 4096;
    logging.ResponseBodyLogLimit = 4096;
    logging.RequestHeaders.Add("Authorisation");
    logging.RequestHeaders.Add("X-Real-IP");
    logging.RequestHeaders.Add("X-Forwarded-For");
});

builder.Host.ConfigureLogging(logging =>
{
    logging.ClearProviders();
    logging.AddConsole();

}).UseNLog(new NLogAspNetCoreOptions() { RemoveLoggerFactoryFilter = true });

#endregion

#region Configure EF DBContext Service (CardStorgeService DataBase)

builder.Services.AddDbContext<CardStorgeServiceDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["Settings:DatabaseOptions:ConnectionString"]);
});

#endregion

#region Configure Repository Services

builder.Services.AddScoped<IClientRepositoryService, IClientRepository>();
builder.Services.AddScoped<ICardRepositoryService, CardRepository>();

#endregion
// Add services to the container.

builder.Services.AddControllers();
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

app.UseAuthorization();
app.UseHttpLogging();
app.MapControllers();

app.Run();
