using DDD.Domain.Models;

namespace DDD.Domain.Services.Interfaces;

public interface IProcessadorPedidoService
{
    void ProcessarPedido(Pedido pedido);
}