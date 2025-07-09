using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerlessTestApi.Infrastructure.IRepositories
{
    public interface IRepositoryGetAllAsync<T>
    {
        /// <summary>
        /// Gets all entities of type T asynchronously.
        /// </summary>
        /// <typeparam name="T">The type of the entities to retrieve.</typeparam>
        /// <returns>A task that represents the asynchronous operation. The task result contains a list of entities of type T.</returns>
        Task<IEnumerable<T>> GetAllAsync();
    }
}
