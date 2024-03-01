using FluentValidation;

namespace DDD.Models.Validations;

public class PedidoValidator : AbstractValidator<PedidoValidator>
{
	public PedidoValidator()
	{
        //RuleFor(pedido => pedido.DataPedido).NotEmpty().WithMessage("A data do pedido é obrigatória.");
        //RuleForEach(pedido => pedido.Itens).SetValidator(new ItemPedidoValidator());
    }
}
