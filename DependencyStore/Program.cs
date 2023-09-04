using DependencyStore;
using DependencyStore.Repositories;
using DependencyStore.Repositories.Contracts;
using DependencyStore.Services;
using Microsoft.Data.SqlClient;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddSingleton<Configuration>(); // Só troca se reiniciar o programa (existe somente uma instancia em memoria)
builder.Services.AddScoped(x => new SqlConnection("CONN_STRING")); // Unico por requisição (só existe um)
builder.Services.AddTransient<ICustomerRepository, CustomerRepository>(); // Sempre cira uma nova instancia
builder.Services.AddTransient<IPromoCodeRepository, PromoCodeRepository>();
builder.Services.AddTransient<IDeliveryFeeService, DeliveryFeeService>();

builder.Services.AddControllers();

var app = builder.Build();

app.MapControllers();

app.Run();