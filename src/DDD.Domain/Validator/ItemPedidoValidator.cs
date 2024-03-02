using DDD.Domain.Models;
using FluentValidation;

namespace DDD.Domain.Validator;

public class ItemPedidoValidator : AbstractValidator<ItemPedido>
{
    public ItemPedidoValidator()
    {
        RuleFor(item => item.NomeProduto).NotEmpty().WithMessage("O nome do produto é obrigatório.");
        RuleFor(item => item.PrecoUnitario).GreaterThan(0).WithMessage("O preço unitário do produto deve ser maior que zero.");
        RuleFor(item => item.Quantidade).GreaterThan(0).WithMessage("A quantidade do produto deve ser maior que zero.");
    }
}
