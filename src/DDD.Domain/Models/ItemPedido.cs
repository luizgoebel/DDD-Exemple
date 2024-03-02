namespace DDD.Domain.Models;

public class ItemPedido : BaseModel
{
    public int ProdutoId { get; protected set; }
    public string NomeProduto { get; private set; }
    public decimal PrecoUnitario { get; private set; }
    public int Quantidade { get; private set; }

    public ItemPedido(string nomeProduto, decimal precoUnitario, int quantidade)
    {
        ProdutoId = base.GerarIdAleatorio();
        NomeProduto = nomeProduto;
        PrecoUnitario = precoUnitario;
        Quantidade = quantidade;
    }

    #region Setters das propriedades de ItemPedido

    /// <summary>
    /// Define o nome do produto do Item Pedido.
    /// </summary>
    /// <param name="value">O novo nome do produto</param>
    public void DefinirNomeProduto(string value) => this.NomeProduto = value;

    /// <summary>
    /// Define o preço unitário do Item Pedido.
    /// </summary>
    /// <param name="value">O novo preço unitário do produto</param>
    public void DefinirPrecoUnitario(decimal value) => this.PrecoUnitario = value;

    /// <summary>
    /// Define a quantidade do Item Pedido.
    /// </summary>
    /// <param name="value">A nova quantidade do produto</param>
    public void DefinirQuantidade(int value) => this.Quantidade = value;

    #endregion Setters das propriedades de ItemPedido

    #region Getters das propriedades de ItemPedido

    /// <summary>
    /// Obtém o ProdutoId do Item Pedido.
    /// </summary>
    /// <returns>O ProdutoId</returns>
    public int ObterProdutoId() => this.ProdutoId;

    /// <summary>
    /// Obtém o Nome Produto de Item Pedido.
    /// </summary>
    /// <returns>O nome do produto</returns>
    public string ObterNomeProduto() => this.NomeProduto;

    /// <summary>
    /// Obtém o Preço Unitário de Item Pedido.
    /// </summary>
    /// <returns>O preço unitário do produto</returns>
    public decimal ObterPrecoUnitario() => this.PrecoUnitario;

    /// <summary>
    /// Obtém a Quantidade de Item Pedido.
    /// </summary>
    /// <returns>A quantidade do produto</returns>
    public int ObterQuantidade() => this.Quantidade;

    #endregion Getters das propriedades de ItemPedido
}