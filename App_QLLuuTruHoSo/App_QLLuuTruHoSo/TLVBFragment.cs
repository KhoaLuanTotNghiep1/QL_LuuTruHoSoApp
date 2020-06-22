using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using App_QLLuuTruHoSo.Interface;
using App_QLLuuTruHoSo.Model;
using Refit;
using System.Threading.Tasks;


namespace App_QLLuuTruHoSo
{
    [Obsolete]
    public class TLVBFragment : Fragment
    {
        private ListView TLVBlistView;
        private List<TaiLieuVanBan> TLVBlist;
        TaiLieuVanBanAdapter taiLieuVanBanAdapter;
        TaiLieuVanBanAPI taiLieuVanBanAPI;
        public static TLVBFragment NewInstance()
        {
            TLVBFragment fragment = new TLVBFragment();
            return fragment;
        }
        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);

            return inflater.Inflate(Resource.Layout.fragment_vanban, container, false);
           
        }

        public  async void  onViewCreated(View view, Bundle savedInstanceState)
        {
            base.OnViewCreated(view, savedInstanceState);
            TLVBlistView = view.FindViewById<ListView>(Resource.Id.listView);

            taiLieuVanBanAPI = RestService.For<TaiLieuVanBanAPI>("http://hethongluutru.somee.com/");
            List<TaiLieuVanBan> mlist = await taiLieuVanBanAPI.GetTaiLieuVanBans();
            foreach (var item in mlist)
            {
                TLVBlist.Add(new TaiLieuVanBan
                {
                    Ten = item.Ten,
                });
            }

            taiLieuVanBanAdapter = new TaiLieuVanBanAdapter(this, TLVBlist);
            TLVBlistView.SetAdapter(taiLieuVanBanAdapter);
        }
    }
}