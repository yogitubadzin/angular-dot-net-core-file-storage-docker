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

        [HttpGet]
        public async Task<IActionResult> Get()
        {
            var result = await Task.FromResult("test");
            return Ok(result);
        }

        [HttpPost]
        public async Task<IActionResult> Post(AddFileCommand command)
        {
            return await HandleAsync(command);
        }
    }
}