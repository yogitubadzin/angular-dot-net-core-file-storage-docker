using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace FilesStorage.Api.Write.Commands.AddFile
{
    public class AddFileCommandHandler : IRequestHandler<AddFileCommand>
    {
        public async Task<Unit> Handle(AddFileCommand request, CancellationToken cancellationToken)
        {
            return await Unit.Task;
        }
    }
}