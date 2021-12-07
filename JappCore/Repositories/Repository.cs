using JappCore.Models;
using JappCore.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JappCore.Repositories
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class, new()
    {
        protected readonly JappCoreDatabaseContext _jappCoreDatabaseContext;

        public Repository(JappCoreDatabaseContext jappCoreDatabaseContext)
        {
            _jappCoreDatabaseContext = jappCoreDatabaseContext;
        }

        public async Task<TEntity> GetById(int id)
        {
            try
            {
                return await _jappCoreDatabaseContext.Set<TEntity>().FindAsync(id);
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public IQueryable<TEntity> GetAll()
        {
            try
            {
                return _jappCoreDatabaseContext.Set<TEntity>();
            }
            catch (Exception ex)
            {
                throw new Exception($"Couldn't retrieve entities: {ex.Message}");
            }
        }

        public async Task<TEntity> Create(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Create)} entity must not be null");
            }

            try
            {
                await _jappCoreDatabaseContext.AddAsync(entity);
                await _jappCoreDatabaseContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be saved: {ex.Message}");
            }
        }

        public async Task<TEntity> Update(TEntity entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException($"{nameof(Create)} entity must not be null");
            }

            try
            {
                _jappCoreDatabaseContext.Update(entity);
                await _jappCoreDatabaseContext.SaveChangesAsync();

                return entity;
            }
            catch (Exception ex)
            {
                throw new Exception($"{nameof(entity)} could not be updated: {ex.Message}");
            }
        }

        public async Task<TEntity> Delete(int id)
        {
            var findCategory = await _jappCoreDatabaseContext.Set<TEntity>().FindAsync(id);

            if (findCategory == null)
            {
                throw new ArgumentNullException($"{nameof(Update)} entity must not be null");
            }

            try
            {
                _jappCoreDatabaseContext.Remove(findCategory);
                await _jappCoreDatabaseContext.SaveChangesAsync();

                return findCategory;
            }
            catch (Exception ex)
            {

                throw new Exception($"{nameof(findCategory)} could not be removed: {ex.Message}");
            }
        }
    }
}
