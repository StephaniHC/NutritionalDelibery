using Joseco.Communication.External.Contracts.Services;
using MediatR;
using NutritionalDelibery.Application.ExitNote.CreateExitNoteDetail;
using NutritionalDelibery.Application.ExitNoteDetail.CreateExitNote;
using NutritionalDelibery.Domain.ExitNote;
using NutritionalDelibery.Integration.Package;

namespace NutritionalDelibery.Infrastructure.RabbitMQ.Consumers
{
    public class LabeledPackageConsumer(IMediator mediator) : IIntegrationMessageConsumer<LabeledPackage>
    {
        public async Task HandleAsync(LabeledPackage message, CancellationToken cancellationToken)
        {
            Random random = new Random();

            CreateExitNoteCommand command = new CreateExitNoteCommand(
                random.Next(),
                "",
                DateTime.UtcNow,
                Guid.NewGuid()
            );

            var exitNoteId = await mediator.Send(command, cancellationToken);

            CreateExitNoteDetailCommand commandDetail = new CreateExitNoteDetailCommand(
                1, 
                message.PackageId, 
                exitNoteId
            );

            await mediator.Send(commandDetail, cancellationToken);
        }
    }
}
