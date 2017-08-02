using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HFCMS.Dao
{
    public class DbHelper<TEntity>
    {
        static PetaPoco.Database _db;
        static readonly object lockHelper = new object();

        PetaPoco.Database DB
        {
            get
            {
                if (_db == null)
                {
                    lock (lockHelper)
                    {
                        if (_db == null)
                        {
                            _db = new PetaPoco.Database("HFCMSConnection");
                        }
                    }
                }         
                return _db;
            }
        }

        public object Insert(TEntity entity)
        {
            return DB.Insert(entity);
        }
    }
}
