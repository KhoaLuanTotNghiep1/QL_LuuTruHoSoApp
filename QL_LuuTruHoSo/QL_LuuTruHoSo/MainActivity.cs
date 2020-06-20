using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System.Collections.Generic;
using System;
using Android.Content;
using Android.Support.Design.Widget;
using Android.Support.Annotation;
using Android.Webkit;
using Android.Views;

namespace QL_LuuTruHoSo
{


    [Activity(Label = "MainActivity")]
    public class MainActivity : AppCompatActivity
    {
        BottomNavigationView navView;
        EditText search;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            Xamarin.Essentials.Platform.Init(this, savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);

            search = FindViewById<EditText>(Resource.Id.search_view);
            navView = FindViewById< BottomNavigationView >(Resource.Id.nav_view);

            search.Click += delegate
            {
                Intent intent = new Intent(this, typeof(SearchActivity));
                StartActivity(intent);
            };


        }
        public Boolean onNavigationItemSelected(IMenuItem item)
        {
            Fragment fragment; 
            switch (item.ItemId)
            {
                case Resource.Id.navigation_tlvb:

                    fragment = new TLVBFragment();
                    loadFragment(fragment);
                    return true;
                case R.id.navigation_home:
                    //                    getSupportActionBar().setTitle("Home");
                    fragment = new HomeFragment();
                    loadFragment(fragment);
                    return true;
                case R.id.navigation_notifications:
                    //                    getSupportActionBar().setTitle("Notification");
                    fragment = new NotificationsFragment();
                    loadFragment(fragment);
                    return true;

            }
            return false;
        }
    };

    private void loadFragment(Fragment fragment)
    {
        // load fragment
        FragmentTransaction transaction = FragmentManager.BeginTransaction();
        transaction.Replace(Resource.Id.nav_host_fragment, fragment);
        transaction.AddToBackStack(null);
        transaction.Commit();
    }