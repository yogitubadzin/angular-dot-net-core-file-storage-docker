using System;

namespace FilesStorage.Api.Read.Queries.GetFileDetails
{
    public class FileDetails
    {
        public Guid Id { get; set; }

        public string FileName { get; set; }

        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }
    }
}