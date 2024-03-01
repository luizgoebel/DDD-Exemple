namespace DDD.Models.Models;

public class Pedido
{
    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public List<ItemPedido> Itens { get; set; }
    public decimal Total => Itens.Sum(item => item.Quantidade * item.PrecoUnitario);
}
