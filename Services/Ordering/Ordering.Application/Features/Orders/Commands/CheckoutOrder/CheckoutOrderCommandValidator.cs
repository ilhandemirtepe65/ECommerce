using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.CheckoutOrder
{
    public class CheckoutOrderCommandValidator : AbstractValidator<CheckoutOrderCommand>
    {
        public CheckoutOrderCommandValidator()
        {

            RuleFor(p => p.ProductId)
               .NotEmpty().WithMessage("{ProductId} is required.")
               .GreaterThan(0).WithMessage("{ProductId} should be greater than zero.");


            RuleFor(p => p.Quantity)
                .NotEmpty().WithMessage("{Quantity} is required.")
                .GreaterThan(0).WithMessage("{Quantity} should be greater than zero.");
        }
    }
}
