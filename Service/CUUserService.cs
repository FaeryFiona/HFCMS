using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFCMS.Service.Interface;
using HFCMS.Entity;
using HFCMS.Repository.Interface;

namespace HFCMS.Service
{
    public class CUUserService : ICUUserService
    {
        ICUUserRepository _CUUserRepository { get; set; }

        public CUUserService(ICUUserRepository cUUserRepository) 
        { 
            _CUUserRepository = cUUserRepository; 
        }

        
        public object Add(CUUser entity)
        {
            return _CUUserRepository.Insert(entity);
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
