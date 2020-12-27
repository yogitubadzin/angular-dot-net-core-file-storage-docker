using System;
using MediatR;

namespace FilesStorage.Api.Read.Queries.GetFileDetails
{
    public class GetFileDetailsQuery : IRequest<GetFileDetailsQueryResponse>
    {
        public Guid? FileId { get; }

        public GetFileDetailsQuery(Guid? fileId)
        {
            FileId = fileId;
        }
    }
}