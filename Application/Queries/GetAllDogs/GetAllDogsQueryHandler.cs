using Domain.Models;
using Infrastructure.Database;
using MediatR;


namespace Application.Queries.GetAllDogs
{
    internal class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllDogsQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> getAllDogsFromDb = _mockDatabase.allDogs;
            return Task.FromResult(getAllDogsFromDb);
        }
    }
}
