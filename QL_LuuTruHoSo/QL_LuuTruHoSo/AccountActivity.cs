using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;

namespace QL_LuuTruHoSo
{
    public class AccountActivity : AppCompatActivity
    {
        private ListView listView;
        private List<string> mTitle;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_account);
            listView = FindViewById<ListView>(Resource.Id.listview);

            mTitle = new List<string>();
            mTitle.Add("Tên Đăng Nhập");
            mTitle.Add("Số Điện Thoại");
            mTitle.Add("Tên Của Bạn");
            mTitle.Add("Email");
            mTitle.Add("Giới Tính");
            mTitle.Add("Ngày Sinh");
            mTitle.Add("Địa Chỉ");

        }
    }
}