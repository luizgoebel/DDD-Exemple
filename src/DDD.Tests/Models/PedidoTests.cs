using DDD.Domain.Models;
using DDD.Domain.Validator;

namespace DDD.Tests.Models;

[TestFixture]
public class PedidoTests
{
    private PedidoValidator? _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new();
    }

    [Test]
    public void Deve_PassarQuandoTodosOsCamposEstiveremPreenchidosCorretamente()
    {
        // Arrange
        List<ItemPedido> itens =
        [
            new ("Notebook Dell", 5.394m, 1),
            new ("Mouse Logitech", 20m, 2)
        ];

        Pedido pedido = new(DateTime.Now, itens);

        // Act
        var result = _validator.Validate(pedido);

        // Assert
        Assert.That(result.IsValid, Is.True);
    }

    [Test]
    public void Deve_FalharQuandoDataPedidoForPassadaComoDateTimeMinValue()
    {
        // Arrange
        List<ItemPedido> itens =
        [
            new ("Notebook Dell", 5.394m, 1),
            new ("Mouse Logitech", 20m, 2)
        ];

        Pedido pedido = new(DateTime.MinValue, itens);

        // Act
        var result = _validator.Validate(pedido);

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Count, Is.Not.Zero);
    }

    [Test]
    public void Deve_FalharQuandoNaoHouverItens()
    {
        // Arrange
        List<ItemPedido> itens = [];

        Pedido pedido = new(DateTime.Now, itens);

        // Act
        var result = _validator.Validate(pedido);

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Count, Is.Not.Zero);
    }
}