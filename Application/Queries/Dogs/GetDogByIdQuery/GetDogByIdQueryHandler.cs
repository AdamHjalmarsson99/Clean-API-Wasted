using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.GetDogByIdQuery
{
    internal class GetDogByIdQueryHandler : IRequestHandler<GetDogByIdQuery, Dog>
    {
        private readonly MockDatabase _mockDatabase;

        public GetDogByIdQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<Dog> Handle(GetDogByIdQuery request, CancellationToken cancellationToken)
        {
            Dog dogByIdInDb = _mockDatabase.allDogs.Where(x => x.Animalid == request.Id).FirstOrDefault()!;
            if (dogByIdInDb == null) 
            {
                throw new ArgumentException($"No dog with this id {dogByIdInDb} was found!");
            }    
            return Task.FromResult(dogByIdInDb);
        }
    }
}
