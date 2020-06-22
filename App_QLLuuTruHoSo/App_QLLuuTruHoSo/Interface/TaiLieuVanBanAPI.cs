using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Refit;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App_QLLuuTruHoSo.Model;
using System.Threading.Tasks;

namespace App_QLLuuTruHoSo.Interface
{
    public interface TaiLieuVanBanAPI
    {
        [Get("/api/tailieuvanban")]
        Task<List<TaiLieuVanBan>> GetTaiLieuVanBans();
    }
}