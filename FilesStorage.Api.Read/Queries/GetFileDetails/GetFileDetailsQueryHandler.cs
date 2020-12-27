using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace FilesStorage.Api.Read.Queries.GetFileDetails
{
    public class GetFileDetailsQueryHandler : IRequestHandler<GetFileDetailsQuery, GetFileDetailsQueryResponse>
    {
        public async Task<GetFileDetailsQueryResponse> Handle(GetFileDetailsQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new GetFileDetailsQueryResponse(new FileDetails())));
        }
    }
}