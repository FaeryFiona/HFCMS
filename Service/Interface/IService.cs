using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCMS.Service.Interface
{
    public interface IService<TEntity>
    {
        object Add(TEntity entity);

        int Update(TEntity entity);

        int Delete(TEntity entity);
    }
}
