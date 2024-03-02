namespace DDD.Domain.Models;

public class Pedido : BaseModel
{
    public Pedido(DateTime dataPedido, List<ItemPedido> itens)
    {
        Id = base.GerarIdAleatorio();
        DataPedido = dataPedido;
        Itens = itens;
    }

    public int Id { get; set; }
    public DateTime DataPedido { get; set; }
    public List<ItemPedido> Itens { get; set; }
    public decimal Total => Itens.Sum(item => item.Quantidade * item.PrecoUnitario);
}
