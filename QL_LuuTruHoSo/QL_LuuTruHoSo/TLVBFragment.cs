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
using QL_LuuTruHoSo.Interface;
using QL_LuuTruHoSo.Model;
using Refit;

namespace QL_LuuTruHoSo
{
    [Obsolete]
    public class TLVBFragment : Fragment
    {
        private ListView TLVBlistView;
        private List<TaiLieuVanBan> TLVBlist;
        TaiLieuVanBanAdapter taiLieuVanBanAdapter;
        TaiLieuVanBanAPI taiLieuVanBanAPI;

        public TLVBFragment()
        {
            // Required empty public constructor
        }
        public async System.Threading.Tasks.Task<View> OnCreateViewAsync(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            base.OnCreateView(inflater, container, savedInstanceState);
           
            var view = inflater.Inflate(Resource.Layout.fragment_vanban, container, false);
            TLVBlistView = view.FindViewById<ListView>(Resource.Id.listView);

            taiLieuVanBanAPI = RestService.For<TaiLieuVanBanAPI>("http://hethongluutru.somee.com/");
            List<TaiLieuVanBan> mlist = await taiLieuVanBanAPI.GetTaiLieuVanBans();
            List<string> tenTVB = new List<string>();
            foreach (var item in mlist)
            {
                TLVBlist.Add(new TaiLieuVanBan {
                    Ten = item.Ten,
                });
            }

            taiLieuVanBanAdapter = new TaiLieuVanBanAdapter(this, mlist);
            TLVBlistView.SetAdapter(taiLieuVanBanAdapter);

            return view;

        }


    }
}