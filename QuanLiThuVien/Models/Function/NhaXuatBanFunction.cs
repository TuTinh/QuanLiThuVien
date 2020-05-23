using QuanLiThuVien.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiThuVien.Models.Function
{
    public class NhaXuatBanFunction
    {
        private QuanLiThuVienDB db;
        public NhaXuatBanFunction()
        {
            db = new QuanLiThuVienDB();
        }
        public List<NhaXuatBan> GetNhaXuatBans()
        {
            return db.NhaXuatBans.ToList();
        }
    }
}