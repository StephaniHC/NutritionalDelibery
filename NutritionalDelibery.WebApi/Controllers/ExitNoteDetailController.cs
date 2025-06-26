using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutritionalDelibery.Application.ExitNote.CreateExitNoteDetail;
using NutritionalDelibery.Application.ExitNote.GetExitNoteDetail;

namespace NutritionalDelibery.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExitNoteDetailController : Controller
    { 
        private readonly IMediator _mediator;
        public ExitNoteDetailController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> CreateExitNoteDetail([FromBody] CreateExitNoteDetailCommand command)
        {
            try
            { 
                var id = await _mediator.Send(command);
                SentrySdk.CaptureMessage($"[ExitNoteDetail] Detalle de nota de salida creado. ID: {id}", SentryLevel.Info);

                return Ok(id);

            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "POST /api/ExitNoteDetail");
                    scope.SetExtra("command", command);
                    scope.Fingerprint = new[] { "exit_note_detail_create", ex.GetType().ToString() }; 
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetExitNoteDetail()
        {
            try
            { 
                var result = await _mediator.Send(new GetExitNoteDetailQuery(""));
                SentrySdk.CaptureMessage($"[ExitNoteDetail] Consulta realizada. Total resultados: {result.Count()}", SentryLevel.Info);

                return Ok(result);
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "GET /api/ExitNoteDetail");
                    scope.Fingerprint = new[] { "exit_note_detail_get", ex.GetType().ToString() }; 
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
