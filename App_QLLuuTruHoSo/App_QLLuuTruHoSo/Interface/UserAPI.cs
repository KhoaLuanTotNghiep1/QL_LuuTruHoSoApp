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
using System.Threading.Tasks;
using App_QLLuuTruHoSo.Model;

namespace App_QLLuuTruHoSo.Interface
{
   public interface UserAPI
    {
        [Get("/API/userapi")]
        Task<List<User>> GetUsers();
    }
}