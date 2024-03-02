using DDD.Domain.Models;
using DDD.Domain.Validator;

namespace DDD.Tests.Models;

[TestFixture]
public class PedidoAgregadoTests
{
    private PedidoAgregadoValidator? _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new();
    }

    [Test]
    public void Deve_PassarQuandoPedidoEItensEstiveremPreenchidosCorretamente()
    {
        // Arrange
        Pedido pedido = new(DateTime.Now, new List<ItemPedido>
        {
            new("Notebook Dell", 5.394m, 1),
            new("Mouse Logitech", 20m, 2)
        });

        // Act
        var result = _validator.Validate(new PedidoAgregado(pedido, pedido.Itens));

        // Assert
        Assert.That(result.IsValid, Is.True);
    }

    [Test]
    public void Deve_FalharQuandoPedidoForNulo()
    {
        // Act
        var result = _validator.Validate(new PedidoAgregado(null, new List<ItemPedido>()));

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Count, Is.Not.Zero);
    }

    [Test]
    public void Deve_FalharQuandoItensForVazio()
    {
        // Arrange
        var pedido = new Pedido(DateTime.Now, new List<ItemPedido>());

        // Act
        var result = _validator.Validate(new PedidoAgregado(pedido, new List<ItemPedido>()));

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Count, Is.Not.Zero);
    }
}