using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Domain;
using MediatR;
using Persistence;
using Microsoft.EntityFrameworkCore;

namespace Application.Activities
{
    public class List
    {
        public class Query : IRequest<List<Activity>> { }

        public class Handeler : IRequestHandler<Query, List<Activity>>
        {
            private readonly DataContext _dataContext;
            public Handeler(DataContext dataContext)
            {
                _dataContext = dataContext;

            }
            public async Task<List<Activity>> Handle(Query request, CancellationToken cancellationToken)
            {
                var activities =  await _dataContext.Activities.ToListAsync();
                return activities;
            }
        }
    }
}