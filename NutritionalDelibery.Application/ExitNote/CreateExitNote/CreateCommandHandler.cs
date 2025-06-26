using MediatR;
using NutritionalDelibery.Domain.Abstractions;
using NutritionalDelibery.Domain.ExitNote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.ExitNoteDetail.CreateExitNote
{
    public class CreateCommandHandler : IRequestHandler<CreateExitNoteCommand, Guid>
    {
        private readonly IExitNoteFactory _exitNoteFactory;
        private readonly IExitNoteRepository _exitNoteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(
            IExitNoteFactory exitNoteFactory,
            IExitNoteRepository exitNoteRepository,
            IUnitOfWork unitOfWork)
        {
            _exitNoteFactory = exitNoteFactory;
            _exitNoteRepository = exitNoteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateExitNoteCommand request, CancellationToken cancellationToken)
        { 
            var exitNote = _exitNoteFactory.Create(request.Number, request.Description, request.ExitDate, request.DeliveryPersonId);

            await _exitNoteRepository.AddAsync(exitNote);

            await _unitOfWork.CommitAsync(cancellationToken);

            return exitNote.Id;
        }
    }
}
