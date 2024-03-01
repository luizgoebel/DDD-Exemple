using DDD.Domain.Services;
using DDD.Domain.Services.Interfaces;
using DDD.Infrastructure.Repositories;
using DDD.Infrastructure.Repositories.Interfaces;
using DDD.Models.Models;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace DDD.Presentation;

public class Program
{
    private readonly IProcessadorPedidoService _pedidoService;

    public Program(IProcessadorPedidoService pedidoService)
    {
        _pedidoService = pedidoService;
    }

    static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();

        // Inicia o processamento de pedidos
        var program = host.Services.GetRequiredService<Program>();
        program.IniciarProcessamentoPedidos();

        host.Run();
    }

    private void IniciarProcessamentoPedidos()
    {
        // Implemente o código para iniciar o processamento de pedidos aqui
        // Por exemplo:
        // _pedidoService.ProcessarPedido(...)

        var pedido = new Pedido
        {
            Id = 1,
            DataPedido = DateTime.Now,
            Itens = new List<ItemPedido>
                {
                    new ItemPedido { ProdutoId = 1, NomeProduto = "Produto 1", PrecoUnitario = 10.00m, Quantidade = 2 },
                    new ItemPedido { ProdutoId = 2, NomeProduto = "Produto 2", PrecoUnitario = 20.00m, Quantidade = 1 }
                }
        };

        _pedidoService.ProcessarPedido(pedido);
    }

    static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((hostContext, services) =>
            {
                // Adicione a configuração de injeção de dependência aqui
                services.AddScoped<IRepository<Pedido>, Repository<Pedido>>();
                services.AddScoped<IProcessadorPedidoService, ProcessadorPedidoService>();
                services.AddScoped<Program>(); // Registrando a classe Program para injeção
            });
}
