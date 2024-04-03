using GBG.Core.Interfaces.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GBG.Core.DomainModels.Common;
using System.Security.Cryptography;

namespace GBG.Infrastructure.Repository
{
    public class Repository<Entity, ID, Context> : IRepository<Entity, ID> where Entity : class where Context : DbContext
    {

        private readonly Context _dbContext;
        private readonly DbSet<Entity> _dbSet;

        public Repository(Context dbContext)
        {
            _dbContext = dbContext;
            _dbSet = _dbContext.Set<Entity>();
        }
        public async Task<Entity> GetByIdAsync(ID id)
        {
            return await _dbSet.FindAsync(id);
        }
        public virtual async Task CreateAsync(Entity entity)
        {
            await _dbSet.AddAsync(entity);
        }

        public virtual async Task DeleteAsync(ID id)
        {
            Entity entity = await GetByIdAsync(id);
            _dbSet.Remove(entity);
        }

        public virtual async Task<int> SaveChangesAsync()
        {
            return await _dbContext.SaveChangesAsync();
        }

        public virtual void Update(Entity entity)
        {
            _dbSet.Update(entity);
        }
    }
}
