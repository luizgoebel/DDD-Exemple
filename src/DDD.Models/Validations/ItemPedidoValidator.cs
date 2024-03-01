using DDD.Models.Models;
using FluentValidation;

namespace DDD.Models.Validations;

public class ItemPedidoValidator : AbstractValidator<ItemPedido>
{
    public ItemPedidoValidator()
    {
        //RuleFor(item => item.Quantidade).GreaterThan(0).WithMessage("A quantidade do item deve ser maior que zero.");
        //RuleFor(item => item.PrecoUnitario).GreaterThan(0).WithMessage("O preço unitário do item deve ser maior que zero.");
    }
}
