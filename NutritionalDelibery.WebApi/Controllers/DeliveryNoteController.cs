using MediatR;
using Microsoft.AspNetCore.Mvc;
using NutritionalDelibery.Application.DeliveryNote.CreateDeliveryNote;
using NutritionalDelibery.Application.DeliveryNote.GetDeliveryNote;  

namespace NutritionalDelibery.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryNoteController : Controller
    {
        private readonly IMediator _mediator;
        public DeliveryNoteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> CreateDeliveryNote([FromBody] CreateDeliveryNoteCommand command)
        {
            try
            { 
                var id = await _mediator.Send(command);
                SentrySdk.CaptureMessage($"[DeliveryNote] Creación exitosa. ID generado: {id}", SentryLevel.Info); 
                return Ok(id);

            }
            catch (Exception ex)
            { 
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "POST /api/DeliveryNote");
                    scope.SetExtra("command", command); 
                    scope.Fingerprint = new[] { "delivery_note_create", ex.GetType().ToString() };
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetDeliveryNote()
        {
            try
            { 
                var result = await _mediator.Send(new GetDeliveryNoteQuery(""));
                SentrySdk.CaptureMessage($"[DeliveryNote] Consulta exitosa. Total registros: {result.Count()}", SentryLevel.Info);

                return Ok(result);
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "GET /api/DeliveryNote"); 
                    scope.Fingerprint = new[] { "delivery_note_get", ex.GetType().ToString() };
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
