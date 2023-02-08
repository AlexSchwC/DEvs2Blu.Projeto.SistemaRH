using Devs2Blu.Projeto.SistemaRH.Domain.IRepositories;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Devs2Blu.Projeto.SistemaRH.Infra.Data.Repositories
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly SQLServerContext _context;

        public Repository(SQLServerContext context)
        {
            _context = context;
        }

        public IQueryable<T> FindAll()
        {
            return _context.Set<T>();
        }

        public async Task<T> FindById(int id)
        {
                return await _context.Set<T>().FindAsync(id);
        }

        public Task<int> Save(T entity)
        {
            _context.Set<T>().AddAsync(entity);
            return _context.SaveChangesAsync();
        }

        public Task<int> Update(T entity)
        {
            try
            {
                _context.Set<T>().Update(entity);
                return _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
        public Task<int> Delete(T entity)
        {
            try
            {
                _context.Set<T>().Remove(entity);
                return _context.SaveChangesAsync();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
