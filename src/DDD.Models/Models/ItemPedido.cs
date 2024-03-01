namespace DDD.Models.Models;

public class ItemPedido
{
    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}