using System;
using MediatR;

namespace FilesStorage.Api.Read.Queries.DownloadFile
{
    public class DownloadFileQuery : IRequest<DownloadFileQueryResponse>
    {
        public Guid? FileId { get; }

        public DownloadFileQuery(Guid? fileId)
        {
            FileId = fileId;
        }
    }
}