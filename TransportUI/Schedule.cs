using System;

using System.Collections.Generic;
using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V4.Widget;
using Android.Support.V7.App;
using Android.Views;
using Android.Widget;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;

namespace TransportUI
{
	[Activity]
	public class Schedule: TabActivity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Schedule);

//			TabHost th=new TabHost();
//			th.
			//TabHost th= TabHost;
//			TabHost th = (TabHost)FindViewById (Resource.Id.tabhost);
//			th.Setup ();
//
//
//			TabHost.TabSpec ts;
//
//			ts = th.NewTabSpec ("tag1");
//			ts.SetIndicator ("Вкладка1");
//			ts.SetContent(new Intent(this,typeof(FirstActivity)));
//			th.AddTab (ts);
//
//			ts = th.NewTabSpec ("tag2");
//			ts.SetIndicator ("Вкладка2");
//			ts.SetContent(new Intent(this,typeof(SecondActivity)));
//			th.AddTab (ts);
//			///



		}
	}
}

