using System.Collections.Generic;

namespace FilesStorage.Api.Read.Queries.GetFiles
{
    public class GetFilesQueryResponse
    {
        public IList<File> Files { get; }

        public GetFilesQueryResponse(IList<File> files)
        {
            Files = files;
        }
    }
}