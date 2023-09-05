using DependencyStore;
using DependencyStore.Extensions;
using DependencyStore.Repositories;
using DependencyStore.Repositories.Contracts;
using DependencyStore.Services;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

//builder.Services.AddSingleton<Configuration>(); Só troca se reiniciar o programa (existe somente uma instancia em memoria)
var connStr = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddConfiguration();
builder.Services.AddSqlConnection(connStr);
builder.Services.AddRepositories();
builder.Services.AddServices();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();