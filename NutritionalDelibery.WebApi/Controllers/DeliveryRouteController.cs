using MediatR;
using Microsoft.AspNetCore.Mvc; 
using NutritionalDelibery.Application.DeliveryRoute.CreateDeliveryRoute;
using NutritionalDelibery.Application.DeliveryRoute.GetDeliveryRoute;

namespace NutritionalDelibery.WebApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DeliveryRouteController : Controller
    { 
        private readonly IMediator _mediator;
        public DeliveryRouteController(IMediator mediator)
        {
            _mediator = mediator;
        }
        [HttpPost]
        public async Task<ActionResult> CreateDeliveryRoute([FromBody] CreateDeliveryRouteCommand command)
        {
            try
            { 
                var id = await _mediator.Send(command);
                SentrySdk.CaptureMessage($"[DeliveryRoute] Ruta creada exitosamente. ID: {id}", SentryLevel.Info); 
                return Ok(id);

            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "POST /api/DeliveryRoute");
                    scope.SetExtra("command", command);
                    scope.Fingerprint = new[] { "delivery_route_create", ex.GetType().ToString() };
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }

        [HttpGet]
        public async Task<ActionResult> GetDeliveryRoute()
        {
            try
            { 
                var result = await _mediator.Send(new GetDeliveryRouteQuery(""));
                SentrySdk.CaptureMessage($"[DeliveryRoute] Consulta realizada. Total resultados: {result.Count()}", SentryLevel.Info);

                return Ok(result);
            }
            catch (Exception ex)
            {
                SentrySdk.CaptureException(ex, scope =>
                {
                    scope.SetTag("endpoint", "GET /api/DeliveryRoute");
                    scope.Fingerprint = new[] { "delivery_route_get", ex.GetType().ToString() };
                });
                return StatusCode(StatusCodes.Status500InternalServerError, ex.Message);
            }
        }
    }
}
