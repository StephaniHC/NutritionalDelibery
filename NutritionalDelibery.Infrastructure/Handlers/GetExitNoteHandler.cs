using MediatR;
using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Application.ExitNote.GetExitNoteDetail;
using NutritionalDelibery.Application.ExitNoteDetail1.GetExitNote;
using NutritionalDelibery.Infrastructure.StoredModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NutritionalDelibery.Infrastructure.Handlers
{
    public class GetExitNoteHandler : IRequestHandler<GetExitNoteQuery, IEnumerable<ExitNoteDTO>>
    {
        private readonly StoredDbContext _dbContext;
        public GetExitNoteHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ExitNoteDTO>> Handle(GetExitNoteQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.ExitNote.AsNoTracking().
            Select(e => new ExitNoteDTO()
            {
                Id = e.Id,
                Number = e.Number,
                Description = e.Description,
                ExitDate = e.ExitDate,
                DeliveryPersonId = e.DeliveryPersonId 
            }).
            ToListAsync(cancellationToken);
        }
    }  
}
