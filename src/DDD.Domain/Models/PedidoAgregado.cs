namespace DDD.Domain.Models;

public class PedidoAgregado
{
    public PedidoAgregado(Pedido pedido, List<ItemPedido> itens)
    {
        Pedido = pedido;
        Itens = itens.Any() ? itens : [];
    }

    public Pedido Pedido { get; private set; }
    public List<ItemPedido> Itens { get; private set; }

    #region Getters das propriedades de Pedido

    /// <summary>
    /// Obtém a lista de itens do pedido.
    /// </summary>
    /// <returns>A lista de itens do pedido</returns>
    public List<ItemPedido> ObterItens() => Itens;

    /// <summary>
    /// Obtém o objeto Pedido associado.
    /// </summary>
    /// <returns>O objeto Pedido associado</returns>
    public Pedido ObterPedido() => Pedido;

    #endregion Getters das propriedades de Pedido

    #region Setters da propriedades de Pedido

    /// <summary>
    /// Define a lista de itens do pedido.
    /// </summary>
    /// <param name="itens">A nova lista de itens do pedido</param>
    public void DefinirItens(List<ItemPedido> itens) => Itens = itens;

    /// <summary>
    /// Define o objeto Pedido associado.
    /// </summary>
    /// <param name="pedido">O novo objeto Pedido associado</param>
    public void DefinirPedido(Pedido pedido) => Pedido = pedido;

    #endregion Setters da propriedades de Pedido
}