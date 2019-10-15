using Business.Models;
using System;
using System.Threading.Tasks;

namespace Business.Interfaces
{
    public interface IService<TEntity> where TEntity : Entity
    {
        Task<bool> Add(TEntity obj);

        Task<bool> Update(TEntity obj);

        Task<bool> Delete(Guid id);
    }
}