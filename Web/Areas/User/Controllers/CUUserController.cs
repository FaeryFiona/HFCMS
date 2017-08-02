using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HFCMS.Entity;
using HFCMS.Service.Interface;

namespace HFCMS.Web.Areas.User.Controllers
{
    public class CUUserController : Controller
    {
        ICUUserService _CUUserService { get; set; }

        public CUUserController(ICUUserService cUUserService)
        {
            _CUUserService = cUUserService;
        }

        // GET: User/CUUser
        public ActionResult Index()
        {
            return View();
        }

        // GET: User/CUUser/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: User/CUUser/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: User/CUUser/Create
        [HttpPost]
        public ActionResult Create(CUUser user)
        {
            var pkid = _CUUserService.Add(user);
            return Json(new { pkid = pkid }, JsonRequestBehavior.DenyGet);
        }

        // GET: User/CUUser/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: User/CUUser/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: User/CUUser/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: User/CUUser/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
