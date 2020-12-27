using System.Threading.Tasks;
using FilesStorage.Api.Write.Commands.AddFile;
using FilesStorage.Infrastructure.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilesStorage.Api.Write.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FilesController : ApiControllerBase
    {
        public FilesController(IMediator mediator) : base(mediator)
        {
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFileCommand command)
        {
            return await HandleAsync(command);
        }
    }
}