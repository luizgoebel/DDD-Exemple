using DDD.Models.Models;
using FluentValidation;

namespace DDD.Models.Validations;

public class PedidoAgregadoValidator : AbstractValidator<PedidoAgregado>
{
    public PedidoAgregadoValidator()
    {
        RuleFor(agregado => agregado.Pedido).NotNull().WithMessage("O pedido não pode ser nulo.");
        RuleFor(agregado => agregado.Itens).NotEmpty().WithMessage("A lista de itens não pode estar vazia.");
    }
}