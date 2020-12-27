using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace FilesStorage.Api.Read.Queries.GetFiles
{
    public class GetFilesQueryHandler : IRequestHandler<GetFilesQuery, GetFilesQueryResponse>
    {
        public Task<GetFilesQueryResponse> Handle(GetFilesQuery request, CancellationToken cancellationToken)
        {
            return Task.FromResult(new GetFilesQueryResponse(new List<File>()));
        }
    }
}