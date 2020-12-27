using System;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace FilesStorage.Infrastructure.Controllers
{
    public class ApiControllerBase : ControllerBase
    {
        private readonly IMediator _mediator;

        public ApiControllerBase(IMediator mediator)
        {
            this._mediator = mediator;
        }

        protected async Task<IActionResult> HandleAsync<TReturn>(IRequest<TReturn> request)
        {
            if (request == null)
            {
                var error = new ErrorResponseWrapper
                {
                    Message = "Bad request."
                };

                return BadRequest(error);
            }

            try
            {
                var response = await _mediator.Send(request);

                return Ok(response);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return BadRequest("Bad request.");
            }
        }
    }
}