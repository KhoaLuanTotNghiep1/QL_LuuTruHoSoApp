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
using App_QLLuuTruHoSo.Model;

namespace App_QLLuuTruHoSo
{
    [Obsolete]
    public class TaiLieuVanBanAdapter: BaseAdapter<TaiLieuVanBan>
    {
        public List<TaiLieuVanBan> sList;
        private Context sContext;
        
        private TLVBFragment tLVBFragment;
        private List<TaiLieuVanBan> mlist;

        public TaiLieuVanBanAdapter(Context context, List<TaiLieuVanBan> list)
        {
            sList = list;
            sContext = context;
        }

        public TaiLieuVanBanAdapter(TLVBFragment tLVBFragment, List<TaiLieuVanBan> mlist)
        {
            this.tLVBFragment = tLVBFragment;
            this.mlist = mlist;
        }

        public override TaiLieuVanBan this[int position]
        {
            get
            {
                return sList[position];
            }
        }
        public override int Count
        {
            get
            {
                return sList.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            try
            {
                if (row == null)
                {
                    row = LayoutInflater.From(sContext).Inflate(Resource.Layout.layout_item, null, false);
                }
                TextView txtName = row.FindViewById<TextView>(Resource.Id.textViewTenVB);
                txtName.Text = sList[position].Ten;
            }
            catch (Exception ex)
            {
                System.Diagnostics.Debug.WriteLine(ex.Message);
            }
            finally { }
            return row;
        }
    }
}