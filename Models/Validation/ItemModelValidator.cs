using FluentValidation;
namespace WebApplication.Web.Models.Validation
{
    public class ItemModelValidator : AbstractValidator<ItemModel>
    {
        public ItemModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}