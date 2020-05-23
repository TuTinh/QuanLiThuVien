using QuanLiThuVien.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiThuVien.Models.Function
{
    public class TheLoaiFunction
    {
        private QuanLiThuVienDB db;
        public TheLoaiFunction()
        {
            db = new QuanLiThuVienDB();
        }
        public List<TheLoai> GetTheLoais()
        {
            return db.TheLoais.ToList();
        }

    }
}