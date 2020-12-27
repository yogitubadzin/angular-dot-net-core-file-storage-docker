using FluentValidation;

namespace FilesStorage.Api.Read.Queries.DownloadFile
{
    public class DownloadFileQueryValidatorCollection : AbstractValidator<DownloadFileQuery>
    {
        public DownloadFileQueryValidatorCollection()
        {
            RuleFor(x => x.FileId)
                .NotNull()
                .WithMessage(x => $"{nameof(x.FileId)} is required.");
        }
    }
}