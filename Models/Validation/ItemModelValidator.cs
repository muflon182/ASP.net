﻿using FluentValidation;
namespace NewBrandingStyle.Web.Models.Validation
{
    public class ItemModelValidator : AbstractValidator<ItemModel>
    {
        public ItemModelValidator()
        {
            RuleFor(x => x.Name).NotEmpty();
        }
    }
}