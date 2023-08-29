using CoffeeBrand.Infrastructure.Repositories;

namespace CoffeeBrand.Application
{
    public class CoffeeBrandService : ICoffeeBrandService
    {
        private readonly InMemoryCoffeeBrandRepository _repository;

        public CoffeeBrandService(InMemoryCoffeeBrandRepository repository) =>
            _repository = repository;

        public IEnumerable<CoffeeBrandModel> GetCoffeeBrands()
        {
            return _repository.GetAll();
        }
    }
}
