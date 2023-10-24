using LibraryProject.Data.Contexts;
using LibraryProject.Data.Repositories.Abstracts;
using LibraryProject.Models.Entities.Abstracts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryProject.Data.Repositories.Concretes
{
    public class Repository<T> : IRepository<T> where T : BaseEntity, new()
    {
        private readonly LibraryDbContext _context;
        private readonly DbSet<T> _dbSet;

        public Repository()
        {
            _context=new LibraryDbContext();
            _dbSet=_context.Set<T>();
        }

        public void Add(T entity)
        {
            if (entity==null) throw new ArgumentNullException("Data is null");
            _dbSet.Add(entity);
        }

        public void AddRange(ICollection<T> entities)
        {
            if (_dbSet==null||entities.Count==0) throw new ArgumentNullException("Data in null");
            _dbSet.AddRange(entities);
        }

        public ICollection<T> GetAll()
        {
            return _dbSet.ToList();
        }

        public T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChange()
        {
            throw new NotImplementedException();
        }

        public void Update(T entity)
        {
            throw new NotImplementedException();
        }
    }
}
