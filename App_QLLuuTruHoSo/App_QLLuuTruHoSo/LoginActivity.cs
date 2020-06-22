using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System;
using Android.Content;
using Android.App;
using Android.Runtime;
using System.Net.Http;
using System.Net.Http.Headers;


namespace App_QLLuuTruHoSo
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
   
    public class LoginActivity : AppCompatActivity
    {
        EditText txtusername;
        EditText txtPassword;
        Button btn_login;


        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your application here  
            SetContentView(Resource.Layout.activity_login);
            txtusername = FindViewById<EditText>(Resource.Id.edtuser);
            txtPassword = FindViewById<EditText>(Resource.Id.edtpass);
            btn_login = FindViewById<Button>(Resource.Id.btnlogin);

            btn_login.Click += async delegate
            {
                try
                {
                    HttpClient client = new HttpClient();
                    string url = "http://hethongluutru.somee.com/API/userapi?username=" + txtusername.Text + "&password=" + txtPassword.Text;
                    var uri = new Uri(url);
                    client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                    HttpResponseMessage response;
                    response = await client.GetAsync(uri);
                    if (response.IsSuccessStatusCode == true)
                    {
                        Intent intent = new Intent(this, typeof(MainActivity));
                        StartActivity(intent);
                    }
                        else
                            Toast.MakeText(this, "Tên đăng nhập hoặc mật khẩu không đúng", ToastLength.Short).Show();
                }
                catch (Exception ex)
                {
                    Toast.MakeText(this, "" + ex.Message, ToastLength.Short).Show();
                }
                
               
            };
        }

        
        public override void OnRequestPermissionsResult(int requestCode, string[] permissions, [GeneratedEnum] Android.Content.PM.Permission[] grantResults)
        {
            Xamarin.Essentials.Platform.OnRequestPermissionsResult(requestCode, permissions, grantResults);

            base.OnRequestPermissionsResult(requestCode, permissions, grantResults);
        }

    }
}
