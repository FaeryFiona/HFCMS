using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFCMS.Dao;
using HFCMS.Entity;
using HFCMS.Repository.Interface;

namespace HFCMS.Repository
{
    public class CAdviceFeedbackRepository : ICAdviceFeedbackRepository
    {
  
        public object Insert(CAdviceFeedback entity)
        {
            return Db.Insert(entity);
        }

        public int Update(CAdviceFeedback entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CAdviceFeedback entity)
        {
            throw new NotImplementedException();
        }

        public DataAccess<CAdviceFeedback> Db
        {
            get { return new DataAccess<CAdviceFeedback>(); }
        }
    }
}
