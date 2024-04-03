using GBG.Core.DomainModels.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace GBG.Core.Interfaces.Common
{
    public interface IRepository<Entity,ID> where Entity : class
    {
        Task CreateAsync(Entity entity);
        Task<Entity> GetByIdAsync(ID id);
        void Update(Entity entity);
        Task DeleteAsync(ID id);
        Task<int> SaveChangesAsync();
    }
}
