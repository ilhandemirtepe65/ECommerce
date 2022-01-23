using FluentValidation;

namespace Ordering.Application.Features.Orders.Commands.UpdateOrder
{
    public class UpdateOrderCommandValidator : AbstractValidator<UpdateOrderCommand>
    {
        public UpdateOrderCommandValidator()
        {
            RuleFor(p => p.Id)
               .NotEmpty().WithMessage("{Id} is required.")
               .GreaterThan(0).WithMessage("{Id} should be greater than zero.");


            RuleFor(p => p.Quantity)
                .NotEmpty().WithMessage("{Quantity} is required.")
                .GreaterThan(0).WithMessage("{Quantity} should be greater than zero.");
        }
    }
}
