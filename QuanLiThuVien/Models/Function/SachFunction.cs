using QuanLiThuVien.Models.Entites;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;

namespace QuanLiThuVien.Models.Function
{
    public class SachFunction
    {
        private QuanLiThuVienDB db;
        public SachFunction()
        {
            db = new QuanLiThuVienDB();
        }

        //get sach for slide
        public List<Sach> SachChoSlide(int top)
        {
            return db.Saches.Where(x => x.Namxuatban > DateTime.Now).Take(top).ToList();
        }

        //
        public List<Sach> SachMoi(DateTime dateTime)
        {
            return db.Saches.Where(x => x.Namxuatban >= dateTime).ToList();
        }

        //Lay top cac cuon sach muon nhieu
        public List<Sach> SachMuonNhieu(int top)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@Top", top)
            };
            return db.Saches.SqlQuery("SachMuonNhieu @Top", sqlParameters).ToList();
        }

        // Lay tat ca sach
        public List<Sach> TatCaSach()
        {
            return db.Saches.SqlQuery("TatCaSach").ToList();
        }

        // Sach da muon trong thang
        public List<Sach> SachDaMuonTrongThang(DateTime date)
        {
            SqlParameter[] sqlParameters =
            {
                new SqlParameter("@date", date)
            };
            return db.Saches.SqlQuery("SachDaMuonTrongThang @date", sqlParameters).ToList();
        }

    }
}