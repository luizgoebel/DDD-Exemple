using DDD.Domain.Models;
using DDD.Domain.Services.Interfaces;
using DDD.Infrastructure.Repositories.Interfaces;

namespace DDD.Domain.Services;

public class ProcessadorPedidoService : IProcessadorPedidoService
{
    private readonly IRepository<Pedido> _pedidoRepository;

    public ProcessadorPedidoService(IRepository<Pedido> pedidoRepository)
    {
        _pedidoRepository = pedidoRepository;
    }

    public void ProcessarPedido(Pedido pedido)
    {
        _pedidoRepository.Salvar(pedido);
    }
}