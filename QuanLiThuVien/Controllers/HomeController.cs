using QuanLiThuVien.Models.Entites;
using QuanLiThuVien.Models.Function;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QuanLiThuVien.Controllers
{
    public class HomeController : Controller
    {
        
        public ActionResult Index()
        {
            SachFunction sachFunction = new SachFunction();
            var model = sachFunction.SachChoSlide(2);
            ViewBag.SachMoi = sachFunction.SachMoi(new DateTime(2020, 1, 1));
            ViewBag.SachMuonNhieu = sachFunction.SachMuonNhieu(7);
            ViewBag.TatCaSach = sachFunction.TatCaSach();
            return View(model);
        }

        //Menu
        [ChildActionOnly]
        public ActionResult Menu()
        {
            ViewBag.ListTheLoai = new TheLoaiFunction().GetTheLoais();
            ViewBag.ListNXB = new NhaXuatBanFunction().GetNhaXuatBans();
            ViewBag.ListTacGia = new TacGiaFunction().GetTacGias();
            return PartialView();
        }
        
    }
}