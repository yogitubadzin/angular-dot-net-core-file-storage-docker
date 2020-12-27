using System;

namespace FilesStorage.Api.Read.Queries.GetFiles
{
    public class File
    {
        public Guid Id { get; set; }

        public string Name { get; set; }
    }
}