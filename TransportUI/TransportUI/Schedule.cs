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
//using SuppActionBar = Android.App.ActionBar;

namespace TransportUI
{
	[Activity]
	public class Schedule: Activity
	{
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;


			SetContentView (Resource.Layout.Schedule);

			Android.App.ActionBar.Tab tab = ActionBar.NewTab();
			tab.SetText(Resources.GetString(Resource.String.tabBar1));
			tab.TabSelected += (sender, args) => {
				// Do something when tab is selected
//				var trans = SupportFragmentManager.BeginTransaction();
//				trans.Add(Resource.Id.fragmentContainer, new TabFragment1(), "Fragment1");
//				trans.Commit ();
			};
				ActionBar.AddTab(tab);

			tab = ActionBar.NewTab();

			tab.SetText(Resources.GetString(Resource.String.tabBar2));
			tab.TabSelected += (sender, args) => {
				// Do something when tab is selected
//				var trans = SupportFragmentManager.BeginTransaction();
//				trans.Add(Resource.Id.fragmentContainer, new TabFragment2(), "Fragment2");
//				trans.Commit ();
			};
				ActionBar.AddTab(tab);
			////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//			protected override void OnCreate(Bundle bundle)
//			{
//				ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
//				SetContentView(Resource.Layout.Main);
//
//				ActionBar.Tab tab = ActionBar.NewTab();
//				tab.SetText(Resources.GetString(Resource.String.tab1_text));
//				tab.SetIcon(Resource.Drawable.tab1_icon);
//				tab.TabSelected += (sender, args) => {
//					// Do something when tab is selected
//				}
//					ActionBar.AddTab(tab);
//
//				tab = ActionBar.NewTab();
//				tab.SetText(Resources.GetString(Resource.String.tab2_text));
//				tab.SetIcon(Resource.Drawable.tab2_icon);
//				tab.TabSelected += (sender, args) => {
//					// Do something when tab is selected
//				}
//					ActionBar.AddTab(tab);
//			}









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

