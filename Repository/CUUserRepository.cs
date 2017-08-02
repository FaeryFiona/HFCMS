using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFCMS.Repository.Interface;
using HFCMS.Entity;


namespace HFCMS.Repository
{
    public class CUUserRepository : ICUUserRepository
    {
        public Dao.DataAccess<CUUser> Db
        {
            get { return new Dao.DataAccess<CUUser>(); }
        }

        public object Insert(CUUser entity)
        {
            return Db.Insert(entity);
        }

        public int Update(CUUser entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CUUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
