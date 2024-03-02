using DDD.Domain.Models;
using FluentValidation;

namespace DDD.Domain.Validator;

public class PedidoAgregadoValidator : AbstractValidator<PedidoAgregado>
{
    public PedidoAgregadoValidator()
    {
        RuleFor(pedidoAgregado => pedidoAgregado.Pedido)
            .NotNull().WithMessage("O pedido não pode ser nulo.");

        RuleFor(pedidoAgregado => pedidoAgregado.Itens)
            .NotEmpty().WithMessage("A lista de itens não pode estar vazia.")
            .Must(itens => itens != null && itens.All(item => item != null))
            .WithMessage("A lista de itens não pode conter itens nulos.");
    }
}

