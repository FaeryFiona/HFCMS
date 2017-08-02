using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HFCMS.Entity;
using HFCMS.Service.Interface;

namespace HFCMS.Web.Controllers
{
    public class CAdviceFeedbackController : Controller
    {
        ICAdviceFeedbackService _CAdviceFeedbackService;

        public CAdviceFeedbackController(ICAdviceFeedbackService cAdviceFeedbackService) {
            _CAdviceFeedbackService = cAdviceFeedbackService;
        }

        // GET: CAdviceFeedback
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Add()
        {
            var obj = new CAdviceFeedback()
            {
                UserId = 1,
                UserName = "张三",
                QQ = "2343234",
                Email = "2343234@qq.com",
                Telphone = "1342342345",
                Content = "sfs fdsfssodfno 的是奇偶发dsx",
                Remark = "生栋覆屋的师父师父",
                IsRead = 0,
                CreateTime = DateTime.Now,
                CreateId = 111
            };

            var id = _CAdviceFeedbackService.Add(obj);
            return Json(new { pkId = id }, JsonRequestBehavior.DenyGet);
        }
    }
}