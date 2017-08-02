using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFCMS.Dao;

namespace HFCMS.Repository.Interface
{
    public interface IRepository<TEntity>
    {
        DataAccess<TEntity> Db { get; }

        object Insert(TEntity entity);

        int Update(TEntity entity);

        int Delete(TEntity entity);
        
    }
}
