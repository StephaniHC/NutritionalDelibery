using MediatR; 
using NutritionalDelibery.Domain.Abstractions;
using NutritionalDelibery.Domain.DeliveryRoute; 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Application.DeliveryRoute.CreateDeliveryRoute
{
    public class CreateCommandHandler : IRequestHandler<CreateDeliveryRouteCommand, Guid>
    {
        private readonly IDeliveryRouteFactory _deliveryRouteFactory;
        private readonly IDeliveryRouteRepository _deliveryRouteRepository;
        private readonly IUnitOfWork _unitOfWork;

        public CreateCommandHandler(
            IDeliveryRouteFactory deliveryRouteFactory,
            IDeliveryRouteRepository deliveryRouteRepository,
            IUnitOfWork unitOfWork)
        {
            _deliveryRouteFactory = deliveryRouteFactory;
            _deliveryRouteRepository = deliveryRouteRepository;
            _unitOfWork = unitOfWork;
        }

        public async Task<Guid> Handle(CreateDeliveryRouteCommand request, CancellationToken cancellationToken)
        {
            var deliveryRoute = _deliveryRouteFactory.Create(request.Name, request.LatitudeOrigin, request.LongitudeOrigin, request.LatitudeDestination, request.LongitudeDestination);

            await _deliveryRouteRepository.AddAsync(deliveryRoute);

            await _unitOfWork.CommitAsync(cancellationToken);

            return deliveryRoute.Id;
        }
    }
}
