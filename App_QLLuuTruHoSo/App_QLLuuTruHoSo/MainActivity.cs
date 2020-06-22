using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Widget;
using System;
using Android.Content;
using Android.Support.Design.Widget;
using Android.Views;

namespace App_QLLuuTruHoSo
{


    [Activity(Label = "MainActivity")]
    public class MainActivity : AppCompatActivity
    {
        BottomNavigationView navView;
        EditText search;
       

        [Obsolete]
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            search = FindViewById<EditText>(Resource.Id.search_view);
            navView = FindViewById<BottomNavigationView>(Resource.Id.nav_view);
            
            navView.NavigationItemSelected += BottomNavigation_NavigationItemSelected;

            search.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SearchActivity));
                StartActivity(intent);
            };
            loadFragment(Resource.Id.navigation_tlvb);

        }

        [Obsolete]
        private void BottomNavigation_NavigationItemSelected(object sender, BottomNavigationView.NavigationItemSelectedEventArgs e)
        {
            loadFragment(e.Item.ItemId);
        }

        [Obsolete]
        //public bool OnNavigationItemSelected(IMenuItem item)
        //{
        //    Fragment fragment;
        //    switch (item.ItemId)
        //    {
        //        case Resource.Id.navigation_tlvb:

        //            fragment = new TLVBFragment();
        //            loadFragment(fragment);
        //            return true;
        //        case Resource.Id.navigation_vbmuon:

        //            fragment = new VBMuonFragment();
        //            loadFragment(fragment);
        //            return true;
        //        case Resource.Id.navigation_thongke:

        //            fragment = new ThongKeFragment();
        //            loadFragment(fragment);
        //            return true;

        //        case Resource.Id.navigation_nguoidung:

        //            fragment = new NguoiDungFragment();
        //            loadFragment(fragment);
        //            return true;

        //    }
        //    return false;
        //}

        
        private void loadFragment(int id)
        {
            Fragment fragment = null;
            switch (id)
            {
                case Resource.Id.navigation_tlvb:
                    fragment = TLVBFragment.NewInstance();
                    break;
                //case Resource.Id.navigation_vbmuon:
                //    fragment = VBMuonFragment.NewInstance();
                //    break;
                //case Resource.Id.navigation_thongke:
                //    fragment = ThongKeFragment.NewInstance();
                //    break;
                //case Resource.Id.navigation_nguoidung:
                //    fragment = NguoiDungFragment.NewInstance();
                //    break;
            }

            if (fragment == null)
                return;
            FragmentTransaction transaction = FragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.nav_host_fragment, fragment);
            transaction.AddToBackStack(null);
            transaction.Commit();
        }

    }
}