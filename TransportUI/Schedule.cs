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
using Android.Util;
//using SuppActionBar = Android.App.ActionBar;

namespace TransportUI
{
	[Activity]
	public class Schedule: Activity
	{

		Fragment[] _fragments;
		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			SetContentView (Resource.Layout.Schedule);
			ActionBar.NavigationMode = ActionBarNavigationMode.Tabs;
		
			//SetContentView (Resource.Layout.Schedule);


			//Initialise fragments for tabs
			_fragments = new Fragment[]
			{
				new TabFragment1(),
				new TabFragment2()
			};
			AddTabToActionBar (Resource.String.tabBar1);
			AddTabToActionBar (Resource.String.tabBar2);
		}

		void AddTabToActionBar(int tabsName)
		{
			Android.App.ActionBar.Tab tab = ActionBar.NewTab ()
				.SetText (tabsName);
			tab.TabSelected += TabOnTabSelected;
			ActionBar.AddTab (tab);
		}

		void TabOnTabSelected (object sender, Android.App.ActionBar.TabEventArgs e)
		{
			Android.App.ActionBar.Tab tab = (Android.App.ActionBar.Tab)sender;

			Log.Debug("The tab {0} has been selected.", tab.Text);
			Fragment frag = _fragments[tab.Position];
			e.FragmentTransaction.Replace(Resource.Id.scheduleFrameLayout, frag);
		}
	}
}

