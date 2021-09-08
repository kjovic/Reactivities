using MediatR;
using System.Collections.Generic;
using Domain;
using Persistence;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System;





namespace Application.Activities
{
    public class Delete
    {
        public class Command : IRequest

        {

            public Guid Id {get; set;}
        }

        public class Handler : IRequestHandler<Command>

        {

            private readonly DataContext _context;
            public Handler(DataContext context)
            {
            _context = context;
            }

             public async Task<Unit> Handle(Command request, CancellationToken CancellationToken)
             {
              var activity = await _context.Activities.FindAsync(request.Id); 

              _context.Remove(activity);

              await _context.SaveChangesAsync();
              return Unit.Value;
             }


        }
    }
}