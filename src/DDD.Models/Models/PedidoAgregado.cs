namespace DDD.Models.Models;

public class PedidoAgregado
{
    public Pedido Pedido { get; set; }
    public List<ItemPedido> Itens { get; set; }
}