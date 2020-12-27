using FluentValidation;

namespace FilesStorage.Api.Read.Queries.GetFileDetails
{
    public class GetFileDetailsValidatorCollection : AbstractValidator<GetFileDetailsQuery>
    {
        public GetFileDetailsValidatorCollection()
        {
            RuleFor(x => x.FileId)
                .NotNull()
                .WithMessage(x => $"{nameof(x.FileId)} is required.");
        }
    }
}