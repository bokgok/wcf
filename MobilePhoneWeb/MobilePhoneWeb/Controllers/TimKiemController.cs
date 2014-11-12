using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MobilePhoneWeb.Controllers
{
    public class TimKiemController : Controller
    {
        //
        // GET: /TimKiem/
        ServiceSanPham.ServiceSanPhamClient tk = new ServiceSanPham.ServiceSanPhamClient();
        public ActionResult Index()
        {
            return View();
        }
        //public ActionResult TimKiem(string key)
        //{
        //    var pro = tk.TimKiem(key).ToList();
        //    return View(pro);
        //}
        public ActionResult TimkiemCB(string txtsearch)
        {
            ViewBag.txtsearch = txtsearch;
             if (txtsearch == "" || txtsearch == null)
            {
                return RedirectToAction("Ketquatimkiem");
            }
            else
            {
                var pro = tk.TimKiem(txtsearch).ToList();
                return View(pro);
            }
        }
        public ActionResult Ketquatimkiem()
        {
            return View();
        }

    }
}
