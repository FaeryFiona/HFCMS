using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NetRube.Data;

namespace HFCMS.Dao
{
    public class DataAccess<TEntity> where TEntity : new()
    {
        Database _db;

        static readonly object lockHelper = new object();

        Database database
        {
            get
            {
                if (_db == null)
                {
                    lock (lockHelper)
                    {
                        if (_db == null)
                        {
                            _db = new Database("HFCMSConnection");
                        }
                    }
                }
                return _db;
            }
        }

        public object Insert(TEntity entity) 
        {
            return database.Insert(entity);
           // return database.Add<TEntity>(entity);
        }
    }
}
