using OneOf;
using ServerlessTestApi.Core.Models;
using ServerlessTestApi.Infrastructure.IRepositories;
using Shared.Errors;
using Shared.Interfaces;

namespace ServerlessApplication.ProductsUseCases
{
    public class GetProductsUseCase : IUseCase<GetProductsUseCase, IEnumerable<ProductDTO>>
    {
        private readonly IRepositoryGetAllAsync<Product> _repository;

        public GetProductsUseCase(IRepositoryGetAllAsync<Product> repository)
        {
            _repository = repository ?? throw new ArgumentNullException(nameof(repository));
        }

        public async Task<OneOf<ErrorBase, IEnumerable<ProductDTO>>> ExecuteAsync(GetProductsUseCase request)
        {
            var result = await _repository.GetAllAsync();
                //¿Puede ser considerado un error?
                //if (result == null) return ErrorBase.NotFound();
            
            // Convert IEnumerable<Product> to List<ProductDTO>
            var productDTOs = result.Select(product => product.AsDTO()).ToList();

            return productDTOs;
        }
    }
}
