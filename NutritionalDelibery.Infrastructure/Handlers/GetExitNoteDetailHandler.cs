using MediatR;
using Microsoft.EntityFrameworkCore;
using NutritionalDelibery.Application.DeliveryRoute.GetDeliveryRoute;
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
    public class GetExitNoteDetailHandler : IRequestHandler<GetExitNoteDetailQuery, IEnumerable<ExitNoteDetailDTO>>
    {
        private readonly StoredDbContext _dbContext;
        public GetExitNoteDetailHandler(StoredDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<IEnumerable<ExitNoteDetailDTO>> Handle(GetExitNoteDetailQuery request, CancellationToken cancellationToken)
        {
            return await _dbContext.ExitNoteDetail.AsNoTracking().
            Select(e => new ExitNoteDetailDTO()
            {
                Id = e.Id,
                Quantity = e.Quantity,
                PackageId = e.PackageId,
                ExitNoteId = e.ExitNoteId
            }).
            ToListAsync(cancellationToken);
        }  
    }
}
