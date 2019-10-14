using Carona.Business.Models;
using System;
using System.Threading.Tasks;

namespace Carona.Business.Interfaces
{
    public interface IService<TEntity> where TEntity : Entity
    {
        Task<bool> Add(TEntity obj);

        Task<bool> Update(TEntity obj);

        Task<bool> Delete(Guid id);
    }
}