using LibraryProject.Models.Entities.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Repositories.Abstracts
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        T GetById(int id);
        void Add(T entity);
        void AddRange(ICollection<T> entities);
        void Update(T entity);
        void Remove(T entity);
        ICollection<T> GetAll();
        void SaveChange();

    }
}
