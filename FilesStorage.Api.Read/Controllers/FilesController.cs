using System;
using System.Threading.Tasks;
using FilesStorage.Api.Read.Queries.DownloadFile;
using FilesStorage.Api.Read.Queries.GetFileDetails;
using FilesStorage.Api.Read.Queries.GetFiles;
using FilesStorage.Infrastructure.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilesStorage.Api.Read.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ApiControllerBase
    {
        public FilesController(IMediator mediator) : base(mediator)
        {
        }

        [Route("files")]
        [HttpGet]
        public async Task<IActionResult> GetFiles()
        {
            return await HandleAsync(new GetFilesQuery());
        }

        [Route("files/{id}")]
        [HttpGet]
        public async Task<IActionResult> GetFileDetails(Guid? id)
        {
            return await HandleAsync(new GetFileDetailsQuery(id));
        }

        [Route("files/{id}/download")]
        [HttpGet]
        public async Task<IActionResult> DownloadFile(Guid? id)
        {
            return await HandleAsync(new DownloadFileQuery(id));
        }
    }
}