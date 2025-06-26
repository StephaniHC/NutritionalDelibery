using MediatR;
using NutritionalDelibery.Domain.Abstractions;
using NutritionalDelibery.Domain.DeliveryNote; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryNote.CreateDeliveryNote
{
    public class CreateCommandHandler : IRequestHandler<CreateDeliveryNoteCommand, Guid>
    {
        private readonly IDeliveryNoteFactory _deliveryNoteFactory;
        private readonly IDeliveryNoteRepository _deliveryNoteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(
            IDeliveryNoteFactory deliveryNoteFactory,
            IDeliveryNoteRepository deliveryNoteRepository,
            IUnitOfWork unitOfWork)
        {
            _deliveryNoteFactory = deliveryNoteFactory;
            _deliveryNoteRepository = deliveryNoteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateDeliveryNoteCommand request, CancellationToken cancellationToken)
        {
            var deliveryNote = _deliveryNoteFactory.Create(request.Description, request.DeliveryDate, request.State, request.ImagePath, request.PacientId);

            await _deliveryNoteRepository.AddAsync(deliveryNote);

            await _unitOfWork.CommitAsync(cancellationToken);

            return deliveryNote.Id;
        }
    }
}
