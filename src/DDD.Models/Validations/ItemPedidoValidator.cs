using DDD.Models.Models;
using FluentValidation;

namespace DDD.Models.Validations;

public class ItemPedidoValidator : AbstractValidator<ItemPedido>
{
    public ItemPedidoValidator()
    {
        RuleFor(item => item.ProdutoId).GreaterThan(0).WithMessage("O ID do produto deve ser maior que zero.");

        RuleFor(item => item.NomeProduto).NotEmpty().WithMessage("O nome do produto não pode estar vazio.");

        RuleFor(item => item.PrecoUnitario).GreaterThan(0).WithMessage("O preço unitário do produto deve ser maior que zero.");

        RuleFor(item => item.Quantidade).GreaterThan(0).WithMessage("A quantidade do produto deve ser maior que zero.");
    }
}
