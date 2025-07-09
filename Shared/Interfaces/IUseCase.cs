using OneOf;
using Shared.Errors;
namespace Shared.Interfaces
{
    public interface IUseCase<TRequest, TResponse>
    {
        public Task<OneOf<ErrorBase, TResponse>> ExecuteAsync(TRequest request);
    }
}
