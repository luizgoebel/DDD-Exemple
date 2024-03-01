using DDD.Models.Models;
using DDD.Models.Validations;

namespace DDD.Tests.Models;

[TestFixture]
public class PedidoTests
{
    private PedidoValidator _pedidoValidator;

    [SetUp]
    public void Setup()
    {
        _pedidoValidator = new PedidoValidator();
    }

    [Test]
    public void Pedido_IdGreaterThanZero_ShouldNotHaveValidationError()
    {
        Setup();
        // Arrange
        var pedido = new Pedido { Id = 1 };

        // Act & Assert
        var result = _pedidoValidator.Validate(pedido);
        Assert.That(result.IsValid, Is.True);

    }

    [Test]
    public void Pedido_DataPedidoNotEmpty_ShouldNotHaveValidationError()
    {
        // Arrange
        var pedido = new Pedido { DataPedido = DateTime.Now };

        // Act & Assert
        var result = _pedidoValidator.Validate(pedido);
        Assert.That(result.IsValid, Is.True);
    }
}
