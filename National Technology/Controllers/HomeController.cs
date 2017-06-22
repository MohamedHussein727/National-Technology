using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace National_Technology.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Login(Table T)
        {
            if (ModelState.IsValid)
            {
                using (Accounts_DataBaseEntities A = new Accounts_DataBaseEntities())
                {
                    var x = A.Tables.Where(a => a.UserName.Equals(T.UserName) && a.Password.Equals(T.Password)).FirstOrDefault();
                    if (x != null)
                    {
                        Session["LogedUserID"] = x.UserID.ToString();
                        Session["LogedUserFullname"] = x.UserName.ToString();
                        return RedirectToAction("AfterLogin");
                    }
                }
            }
            return View(T);
        }
        public ActionResult AfterLogin()
        {
            if (Session["LogedUserFullname"] != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index");
            }
        }
    }
}