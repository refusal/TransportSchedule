using System;
using Android.Widget;
using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;

namespace TransportUI
{
	public class TransportAdapterClass: BaseAdapter<TransportInfo>
	{
		private List<TransportInfo> mItems;
		private Context mContext;


		public TransportAdapterClass (Context context, List<TransportInfo> items)
		{
			mItems = items;
			mContext = context;
		}

		public override int Count
		{ 
			get {return mItems.Count; }
		}

		public override long GetItemId(int position)
		{
			return position;
		}
		public override TransportInfo this[int position]
		{
			get{return mItems [position]; }
		}

		public override View GetView(int position, View convertView, ViewGroup parent)
		{

			View row = convertView;
			if(row==null)
			{
				row=LayoutInflater.From(mContext).Inflate(Resource.Layout.TransportListView ,null,false);
			}

			TextView txtWay = row.FindViewById<TextView> (Resource.Id.transWayName);
			txtWay.Text = mItems [position].TransportNumber.ToString();

			TextView txtNumber = row.FindViewById<TextView> (Resource.Id.transNumber);
			txtNumber.Text = mItems [position].TransportNumber.ToString();

			TextView txtStop = row.FindViewById<TextView> (Resource.Id.transStop);
			txtStop.Text = mItems [position].TransportNumber.ToString();


			//YOu must add others values and made an xml update for new values

			return row;
		}
	}
}

