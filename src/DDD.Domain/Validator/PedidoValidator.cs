using DDD.Domain.Models;
using FluentValidation;

namespace DDD.Domain.Validator;

public class PedidoValidator : AbstractValidator<Pedido>
{
    public PedidoValidator()
    {
        RuleFor(pedido => pedido.DataPedido)
            .NotEmpty().WithMessage("A data do pedido é obrigatória.")
            .GreaterThan(DateTime.MinValue).WithMessage("A data do pedido deve ser maior que a data mínima permitida.");

        RuleFor(pedido => pedido.Itens.Count)
            .GreaterThan(0).WithMessage("O pedido deve conter pelo menos um item.");
    }
}
