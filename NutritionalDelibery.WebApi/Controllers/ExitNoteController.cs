using MediatR;
using Microsoft.AspNetCore.Mvc; 
using NutritionalDelibery.Application.ExitNoteDetail.CreateExitNote;
using NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote;

namespace NutritionalDelibery.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExitNoteController : Controller
    { 
        private readonly IMediator _mediator;
        public ExitNoteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> CreateExitNote([FromBody] CreateExitNoteCommand command)
        {
            try
            { 
                var id = await _mediator.Send(command);
                SentrySdk.CaptureMessage($"[ExitNote] Nota de salida creada exitosamente. ID: {id}", SentryLevel.Info);

                return Ok(id);

            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "POST /api/ExitNote");
                    scope.SetExtra("command", command);
                    scope.Fingerprint = new[] { "exit_note_create", ex.GetType().ToString() };
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetExitNote()
        {
            try
            { 
                var result = await _mediator.Send(new GetExitNoteQuery(""));
                SentrySdk.CaptureMessage($"[ExitNote] Consulta realizada. Total resultados: {result.Count()}", SentryLevel.Info);

                return Ok(result);
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "GET /api/ExitNote");
                    scope.Fingerprint = new[] { "exit_note_get", ex.GetType().ToString() };
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
