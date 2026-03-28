using System;
using FluentValidation;

namespace GameStore.Api.Dtos;

public class UpdateGameDtoValidator : AbstractValidator<UpdateGameDto>
{
    public UpdateGameDtoValidator()
    {
        RuleFor(x => x.Name).NotEmpty().WithMessage("Name cannot be empty.")
                            .MaximumLength(50).WithMessage("This field must be a string with a maximum length of 50");

        RuleFor(x => x.GenreId).InclusiveBetween(1,50)
                                .WithMessage("Id must be between 1 & 50");

        RuleFor(x => x.Price).InclusiveBetween(1,100)
                                .WithMessage("Price must be between 1 & 100");
    }
}
