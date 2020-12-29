using FluentValidation;

namespace FilesStorage.Api.Write.Commands.AddFile
{
    public class AddFileCommandValidatorCollection : AbstractValidator<AddFileCommand>
    {
        public AddFileCommandValidatorCollection()
        {
            RuleFor(x => x.File)
                .NotNull()
                .WithMessage(x => $"{nameof(x.File)} is required.");

            RuleFor(x => x.Description)
                .NotNull()
                .NotEmpty()
                .WithMessage(x => $"{nameof(x.Description)} is required.");
        }
    }
}