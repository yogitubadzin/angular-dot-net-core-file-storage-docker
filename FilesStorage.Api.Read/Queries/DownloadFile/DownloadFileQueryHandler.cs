using System.Threading;
using System.Threading.Tasks;
using MediatR;

namespace FilesStorage.Api.Read.Queries.DownloadFile
{
    public class DownloadFileQueryHandler : IRequestHandler<DownloadFileQuery, DownloadFileQueryResponse>
    {
        public async Task<DownloadFileQueryResponse> Handle(DownloadFileQuery request, CancellationToken cancellationToken)
        {
            return await Task.FromResult(new DownloadFileQueryResponse(new FileContent()));
        }
    }
}