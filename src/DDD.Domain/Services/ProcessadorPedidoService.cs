using DDD.Domain.Exceptions;
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
        try
        {
            if (pedido is null) throw new ServiceException("Pedido não pode ser nulo.");

            _pedidoRepository.Salvar(pedido);
        }
        catch (ServiceException)
        {
            throw new ServiceException("Ocorreu um erro ao processar o pedido.");
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);
        }
    }
}