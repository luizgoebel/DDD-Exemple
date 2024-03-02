namespace DDD.Tests.Models;

using DDD.Domain.Models;
using DDD.Domain.Validator;
using NUnit.Framework;

[TestFixture]
public class ItemPedidoTests
{
    private ItemPedidoValidator? _validator;

    [SetUp]
    public void Setup()
    {
        _validator = new ItemPedidoValidator();
    }

    #region Testes com dados válidos
    [Test]
    public void Deve_ValidarNomeProdutoNaoVazio()
    {
        // Arrange
        ItemPedido itemPedido = new("Notebook Dell", 5.394m, 1);

        // Act & Assert
        var result = _validator.Validate(itemPedido);

        Assert.That(result.IsValid, Is.True);
        Assert.That(result.Errors.Exists(x => x.PropertyName == nameof(itemPedido.NomeProduto)), Is.False);
    }

    [Test]
    public void Deve_ValidarPrecoUnitarioMaiorQueZero()
    {
        // Arrange
        ItemPedido itemPedido = new("Notebook Dell", 5.394m, 1);

        // Act
        var result = _validator.Validate(itemPedido);

        // Assert
        Assert.That(result.IsValid, Is.True);
        Assert.That(result.Errors.Exists(x => x.PropertyName == nameof(itemPedido.PrecoUnitario)), Is.False);
    }

    [Test]
    public void Deve_ValidarQuantidadeMaiorQueZero()
    {
        // Arrange
        ItemPedido itemPedido = new("Notebook Dell", 5.394m, 1);

        // Act
        var result = _validator.Validate(itemPedido);

        // Assert
        Assert.That(result.IsValid, Is.True);
        Assert.That(result.Errors.Exists(x => x.PropertyName == nameof(itemPedido.PrecoUnitario)), Is.False);
    }

    [Test]
    public void Deve_PassarQuandoTodosOsCamposEstiveremPreenchidosCorretamente()
    {
        // Arrange
        ItemPedido itemPedido = new("Notebook Dell", 5.394m, 1);

        // Act
        var result = _validator.Validate(itemPedido);

        // Assert
        Assert.That(result.IsValid, Is.True);
    }
    #endregion Testes com dados válidos

    #region Testes com dados inválidos
    [Test]
    public void Deve_FalharQuandoNomeProdutoVazio()
    {
        // Arrange
        ItemPedido itemPedido = new("", 5.394m, 1);

        // Act
        var result = _validator.Validate(itemPedido);

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Exists(x => x.PropertyName == nameof(itemPedido.NomeProduto)), Is.True);
    }

    [Test]
    public void Deve_FalharQuandoPrecoUnitarioMenorOuIgualAZero()
    {
        // Arrange
        ItemPedido itemPedido = new("Notebook Dell", 0m, 1);

        // Act
        var result = _validator.Validate(itemPedido);

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Exists(x => x.PropertyName == nameof(itemPedido.PrecoUnitario)), Is.True);
    }

    [Test]
    public void Deve_FalharQuandoQuantidadeMenorOuIgualAZero()
    {
        // Arrange
        ItemPedido itemPedido = new("Notebook Dell", 5.394m, 0);

        // Act
        var result = _validator.Validate(itemPedido);

        // Assert
        Assert.That(result.IsValid, Is.False);
        Assert.That(result.Errors.Exists(x => x.PropertyName == nameof(itemPedido.Quantidade)), Is.True);
    }
    #endregion Testes com dados inválidos
}