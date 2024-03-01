using DDD.Domain.Services;
using DDD.Domain.Services.Interfaces;
using DDD.Infrastructure.Repositories;
using DDD.Infrastructure.Repositories.Interfaces;
using DDD.Models.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

internal static class ProgramHelpers
{
    static IHostBuilder CreateHostBuilder(string[] args) =>
    Host.CreateDefaultBuilder(args)
        .ConfigureServices((hostContext, services) =>
        {
            // Adicione a configuração de injeção de dependência aqui
            services.AddScoped<IRepository<Pedido>, Repository<Pedido>>();
            services.AddScoped<IProcessadorPedidoService, ProcessadorPedidoService>();
        });
}