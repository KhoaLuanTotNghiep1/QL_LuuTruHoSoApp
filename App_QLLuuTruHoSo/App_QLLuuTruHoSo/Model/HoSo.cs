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

namespace App_QLLuuTruHoSo.Model
{
    public class HoSo
    {
        public string PhongLuuTru { get; set; }
        public int TinhTrang { get; set; }
        public int ThoiGianBaoQuan { get; set; }
        public string GhiChu { get; set; }
        public string BienMucHoSo { get; set; }
        public string Id { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public bool TrangThai { get; set; }
    }
}