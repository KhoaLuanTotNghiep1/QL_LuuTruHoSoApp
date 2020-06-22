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
    public class NoiBanHanh
    {
        public string Ten { get; set; }
        public string Id { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayCapNhat { get; set; }
        public bool TrangThai { get; set; }
    }
}