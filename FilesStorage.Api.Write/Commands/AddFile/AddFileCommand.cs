using MediatR;
using Microsoft.AspNetCore.Http;

namespace FilesStorage.Api.Write.Commands.AddFile
{
    public class AddFileCommand : IRequest<Unit>
    {
        public IFormFile File { get; set; }

        public string Description { get; set; }
    }
}