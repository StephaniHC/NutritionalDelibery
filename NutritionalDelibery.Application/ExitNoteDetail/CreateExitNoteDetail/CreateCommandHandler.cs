using MediatR; 
using NutritionalDelibery.Domain.Abstractions; 
using NutritionalDelibery.Domain.ExitNoteDetail;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace NutritionalDelibery.Application.ExitNote.CreateExitNoteDetail
{
    public class CreateCommandHandler : IRequestHandler<CreateExitNoteDetailCommand, Guid>
    {
        private readonly IExitNoteDetailFactory _exitNoteDetailFactory;
        private readonly IExitNoteDetailRepository _exitNoteDetailRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(
            IExitNoteDetailFactory exitNoteDetailFactory,
            IExitNoteDetailRepository exitNoteDetailRepository,
            IUnitOfWork unitOfWork)
        {
            _exitNoteDetailFactory = exitNoteDetailFactory;
            _exitNoteDetailRepository = exitNoteDetailRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateExitNoteDetailCommand request, CancellationToken cancellationToken)
        {
            var exitNoteDetail = _exitNoteDetailFactory.Create(request.Quantity, request.PackageId, request.ExitNoteNumber);

            await _exitNoteDetailRepository.AddAsync(exitNoteDetail);

            await _unitOfWork.CommitAsync(cancellationToken);

            return exitNoteDetail.Id;
        }
    }
}
