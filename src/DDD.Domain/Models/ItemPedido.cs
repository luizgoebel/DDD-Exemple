namespace DDD.Domain.Models;

public class ItemPedido : BaseModel
{
    public ItemPedido(string nomeProduto, decimal precoUnitario, int quantidade)
    {
        ProdutoId = base.GerarIdAleatorio();
        NomeProduto = nomeProduto;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    public int ProdutoId { get; set; }
    public string NomeProduto { get; set; }
    public decimal PrecoUnitario { get; set; }
    public int Quantidade { get; set; }
}