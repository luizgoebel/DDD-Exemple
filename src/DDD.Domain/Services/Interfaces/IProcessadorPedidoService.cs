using DDD.Models.Models;

namespace DDD.Domain.Services.Interfaces;

public interface IProcessadorPedidoService
{
    void ProcessarPedido(Pedido pedido);
}