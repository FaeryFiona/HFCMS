using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HFCMS.Entity;
using HFCMS.Repository.Interface;
using HFCMS.Service.Interface;

namespace HFCMS.Service
{
    public class CAdviceFeedbackService : ICAdviceFeedbackService
    {
        ICAdviceFeedbackRepository _CAdviceFeedbackRepository;
        public CAdviceFeedbackService(ICAdviceFeedbackRepository cAdviceFeedbackRepository)
        {
            _CAdviceFeedbackRepository = cAdviceFeedbackRepository;

        }

        public object Add(CAdviceFeedback entity)
        {
            return _CAdviceFeedbackRepository.Insert(entity);
        }

        public int Update(CAdviceFeedback entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(CAdviceFeedback entity)
        {
            throw new NotImplementedException();
        }
    }
}
