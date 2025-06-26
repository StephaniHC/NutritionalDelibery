using MediatR;
using NutritionalDelibery.Application.DeliveryNote.GetDeliveryNote;
using NutritionalDelibery.Infrastructure.StoredModel;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Handlers
{ 
    public class GetDeliveryNoteHandler : IRequestHandler<GetDeliveryNoteQuery, IEnumerable<DeliveryNoteDTO>>
    {
        private readonly StoredDbContext _dbContext;
        public GetDeliveryNoteHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<DeliveryNoteDTO>> Handle(GetDeliveryNoteQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.DeliveryNote.AsNoTracking().
            Select(d => new DeliveryNoteDTO()
            {
                Id = d.Id,
                Description = d.Description,
                DeliveryDate = d.DeliveryDate,
                State = d.State,
                ImagePath = d.ImagePath,
                PacientId = d.PacientId 
            }).
            ToListAsync(cancellationToken);
        }
    }
}
