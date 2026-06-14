using System;
using System.Collections.Generic;
using System.Linq;

namespace QuanLySinhVien
{
    public static class DatabaseHelper
    {
        public static string ConnectionString =
            @"Data Source=.\SQLEXPRESS;Initial Catalog=qlsv;Integrated Security=True";

        private static Qlsv GetDb()
        {
            return new Qlsv(ConnectionString);
        }

        // ===== LỚP HỌC =====
        public static List<Tbl_lophoc> GetAllLop(string keyword = "")
        {
            using (var db = GetDb())
            {
                var q = db.Tbl_lophoc.AsQueryable();
                if (!string.IsNullOrWhiteSpace(keyword))
                    q = q.Where(l => l.Id.ToString().Contains(keyword)
                               || l.Malop.Contains(keyword)
                               || l.Tenlop.Contains(keyword));
                return q.OrderBy(l => l.Id).ToList();
            }
        }

        public static void ThemLop(string malop, string tenlop, string ghichu)
        {
            using (var db = GetDb())
            {
                db.Tbl_lophoc.InsertOnSubmit(new Tbl_lophoc { Malop = malop, Tenlop = tenlop, Ghichu = ghichu });
                db.SubmitChanges();
            }
        }

        public static void SuaLop(int id, string malop, string tenlop, string ghichu)
        {
            using (var db = GetDb())
            {
                var lop = db.Tbl_lophoc.FirstOrDefault(l => l.Id == id);
                if (lop == null) return;
                lop.Malop = malop;
                lop.Tenlop = tenlop;
                lop.Ghichu = ghichu;
                db.SubmitChanges();
            }
        }

        public static void XoaLop(int id)
        {
            using (var db = GetDb())
            {
                var lop = db.Tbl_lophoc.FirstOrDefault(l => l.Id == id);
                if (lop == null) return;
                db.Tbl_lophoc.DeleteOnSubmit(lop);
                db.SubmitChanges();
            }
        }

        // ===== SINH VIÊN =====
        public static List<Tbl_sinhviens> GetAllSV(string keyword = "", string filterMalop = "")
        {
            using (var db = GetDb())
            {
                var q = db.Tbl_sinhviens.AsQueryable();
                if (!string.IsNullOrWhiteSpace(filterMalop))
                    q = q.Where(s => s.Malop == filterMalop);
                else if (!string.IsNullOrWhiteSpace(keyword))
                    q = q.Where(s => s.Hoten.Contains(keyword)
                               || s.Id.ToString().Contains(keyword)
                               || s.Malop.Contains(keyword));
                return q.OrderBy(s => s.Id).ToList();
            }
        }

        public static void ThemSV(string hoten, string gioitinh, DateTime? ngaysinh, string malop)
        {
            using (var db = GetDb())
            {
                db.Tbl_sinhviens.InsertOnSubmit(new Tbl_sinhviens
                {
                    Hoten = hoten,
                    Gioitinh = gioitinh,
                    Ngaysinh = ngaysinh,
                    Malop = malop
                });
                db.SubmitChanges();
            }
        }

        public static void SuaSV(int id, string hoten, string gioitinh, DateTime? ngaysinh, string malop)
        {
            using (var db = GetDb())
            {
                var sv = db.Tbl_sinhviens.FirstOrDefault(s => s.Id == id);
                if (sv == null) return;
                sv.Hoten = hoten;
                sv.Gioitinh = gioitinh;
                sv.Ngaysinh = ngaysinh;
                sv.Malop = malop;
                db.SubmitChanges();
            }
        }

        public static void XoaSV(int id)
        {
            using (var db = GetDb())
            {
                var sv = db.Tbl_sinhviens.FirstOrDefault(s => s.Id == id);
                if (sv == null) return;
                db.Tbl_sinhviens.DeleteOnSubmit(sv);
                db.SubmitChanges();
            }
        }
    }
}