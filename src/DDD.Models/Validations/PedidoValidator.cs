using DDD.Models.Models;
using FluentValidation;

namespace DDD.Models.Validations;

public class PedidoValidator : AbstractValidator<Pedido>
{
    public PedidoValidator()
    {
        RuleFor(pedido => pedido.Id).GreaterThan(0).WithMessage("O ID do pedido deve ser maior que zero.");

        RuleFor(pedido => pedido.DataPedido).NotEmpty().WithMessage("A data do pedido deve ser fornecida.");

        RuleForEach(pedido => pedido.Itens).SetValidator(new ItemPedidoValidator());
    }
}
