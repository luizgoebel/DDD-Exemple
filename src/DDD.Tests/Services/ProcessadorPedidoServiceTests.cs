using DDD.Domain.Exceptions;
using DDD.Domain.Models;
using DDD.Domain.Services;
using DDD.Infrastructure.Repositories.Interfaces;
using Moq;

namespace DDD.Tests.Services;

[TestFixture]
public class ProcessadorPedidoServiceTests
{
    [Test]
    public void ProcessarPedido_DeveChamarMetodoSalvarDoRepositorio()
    {
        // Arrange
        Pedido pedido = new(DateTime.Now,
        [
            new ("Notebook Dell", 5.394m, 1),
            new ("Mouse Logitech", 20m, 2)

        ]); // Criando um objeto de pedido fictício para o teste

        var mockRepository = new Mock<IRepository<Pedido>>();
        var service = new ProcessadorPedidoService(mockRepository.Object);

        // Act
        service.ProcessarPedido(pedido);

        // Assert
        Assert.That(pedido, Is.Not.Null);
        mockRepository.Verify(r => r.Salvar(pedido), Times.Once);
    }
    [Test]
    public void ProcessarPedido_DeveChamarMetodoSalvarDoRepositorioRetornarServiceException()
    {
        // Arrange
        Pedido pedido = null;

        var mockRepository = new Mock<IRepository<Pedido>>();
        var service = new ProcessadorPedidoService(mockRepository.Object);

        // Act & Assert
        Assert.Throws<ServiceException>(() => service.ProcessarPedido(pedido));
        mockRepository.Verify(r => r.Salvar(pedido), Times.Never);
    }
}
