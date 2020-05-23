using QuanLiThuVien.Models.Function;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiThuVien.Controllers
{
    public class StoreProcController : Controller
    {
        // GET: StoreProc
        public ActionResult Index()
        {
            

            return View();
        }

        public ActionResult SachMuonNhhieuTrongThang()
        {           
            return View();
        }

        [HttpPost]
        public ActionResult SachMuonNhieuTrongThang(DateTime date)
        {
            if (date != null)
            {
                ViewBag.SachDaMuonTrongThang = new SachFunction().SachDaMuonTrongThang(date);

                return RedirectToAction("Index", "StoreProc");
            }
            
            return View();
        }
    }
}