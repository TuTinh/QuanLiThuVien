using QuanLiThuVien.Models.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace QuanLiThuVien.Models.Function
{
    public class TacGiaFunction
    {
        private QuanLiThuVienDB db;
        public TacGiaFunction()
        {
            db = new QuanLiThuVienDB();
        }
        public List<TacGia> GetTacGias()
        {
            return db.TacGias.ToList();
        }
    }
}