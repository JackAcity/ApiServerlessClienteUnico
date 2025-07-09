namespace ServerlessTestApi.Infrastructure.IRepositories
{
    public interface IRepositoryAddAsync<T>
    {
        Task<int> AddAsync(T entity);
    }
}
