namespace DDD.Domain.Models;

public class Pedido : BaseModel
{
    public Pedido(DateTime dataPedido, List<ItemPedido> itens)
    {
        Id = base.GerarIdAleatorio();
        DataPedido = dataPedido;
        Itens = itens;
    }

    public int Id { get; protected set; }
    public DateTime DataPedido { get; private set; }
    public List<ItemPedido> Itens { get; private set; }
    public decimal Total => Itens.Sum(item => item.Quantidade * item.PrecoUnitario);

    #region Getters das propriedades de Pedido

    /// <summary>
    /// Obtém o identificador do produto associado ao item do pedido.
    /// </summary>
    /// <returns>O identificador do produto</returns>
    public int ObterProdutoId() => this.Id;

    /// <summary>
    /// Obtém a data do pedido.
    /// </summary>
    /// <returns>A data do pedido</returns>
    public DateTime ObterDataPedido() => DataPedido;

    /// <summary>
    /// Obtém a lista de itens do pedido.
    /// </summary>
    /// <returns>A lista de itens do pedido</returns>
    public List<ItemPedido> ObterItens() => Itens;

    #endregion Getters das propriedades de Pedido

    #region Setters da propriedades de Pedido

    // Método setter para a DataPedido (se necessário)
    // Este método permite definir a DataPedido posteriormente, caso seja necessário
    /// <summary>
    /// Define a data do pedido.
    /// </summary>
    /// <param name="dataPedido">A nova data do pedido</param>
    public void DefinirDataPedido(DateTime dataPedido) => DataPedido = dataPedido;

    /// <summary>
    /// Define a lista de itens do pedido.
    /// </summary>
    /// <param name="itens">A nova lista de itens do pedido</param>
    public void DefinirItens(List<ItemPedido> itens) => Itens = itens;

    #endregion Setters da propriedades de Pedido
}