using Domain.Entities;
using Domain.Service;

namespace Application
{
    public class CoffeeBrandService : ICoffeeBrandService
    {
        private readonly ICoffeeBrandRepository _repository;

        public CoffeeBrandService(ICoffeeBrandRepository repository) =>
            _repository = repository;

        public IEnumerable<CoffeeBrandModel> GetCoffeeBrands()
        {
            return _repository.GetAll();
        }
    }
}
