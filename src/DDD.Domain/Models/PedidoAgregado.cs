﻿namespace DDD.Domain.Models;

public class PedidoAgregado
{
    public PedidoAgregado(Pedido pedido, List<ItemPedido> itens)
    {
        Pedido = pedido;
        Itens = itens.Any() ? itens : [];
    }

    public Pedido Pedido { get; private set; }
    public List<ItemPedido> Itens { get; private set; }
}