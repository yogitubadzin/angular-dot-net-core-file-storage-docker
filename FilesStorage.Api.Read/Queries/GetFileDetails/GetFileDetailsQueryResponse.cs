namespace FilesStorage.Api.Read.Queries.GetFileDetails
{
    public class GetFileDetailsQueryResponse
    {
        public FileDetails FileDetails { get; }

        public GetFileDetailsQueryResponse(FileDetails fileDetails)
        {
            FileDetails = fileDetails;
        }
    }
}