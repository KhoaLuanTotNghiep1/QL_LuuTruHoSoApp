using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace QL_LuuTruHoSo.Model
{
    public class TaiLieuVanBan
    {
        public string Ten { get; set; }
        public string Loai { get; set; }
        public string Dang { get; set; }
        public string SoKyHieu { get; set; }
        public int SoTo { get; set; }
        public string TinhTrang { get; set; }
        public string DuongDan { get; set; }
        public string NoiDung { get; set; }
        public string NguoiGuiHoacNhan { get; set; }
        public string NguoiKy { get; set; }
        public string NguoiDuyet { get; set; }
        public DateTime NgayBanHanh { get; set; }
        public HoSo HoSo { get; set; }
        public NoiBanHanh NoiBanHanh { get; set; }
        public User User { get; set; }
        public string Id { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public bool TrangThai { get; set; }
    }
}