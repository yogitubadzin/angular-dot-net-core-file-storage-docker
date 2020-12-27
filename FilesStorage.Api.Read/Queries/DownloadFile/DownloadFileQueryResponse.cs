namespace FilesStorage.Api.Read.Queries.DownloadFile
{
    public class DownloadFileQueryResponse
    {
        public FileContent FileContent { get; }

        public DownloadFileQueryResponse(FileContent fileContent)
        {
            FileContent = fileContent;
        }
    }
}