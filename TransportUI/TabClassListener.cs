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
using suppActBar = Android.App.ActionBar;
using Android.Util;




namespace TransportUI
{
	[Activity]
	public class TabClassListener: ActionBarActivity, suppActBar.ITabListener
	{
		static readonly string Tag = "ActionBarTabsSupport";

		public void OnTabReselected (suppActBar.Tab tab, FragmentTransaction ft)
		{
			// Optionally refresh/update the displayed tab.
			Log.Debug (Tag, "The tab {0} was re-selected.", tab.Text);
		}

		public void OnTabSelected (suppActBar.Tab tab, FragmentTransaction ft)
		{
			// Display the fragment the user should see
			Log.Debug (Tag, "The tab {0} has been selected.", tab.Text);
		}

		public void OnTabUnselected (suppActBar.Tab tab, FragmentTransaction ft)
		{
			// Save any state in the displayed fragment.
			Log.Debug (Tag, "The tab {0} as been unselected.", tab.Text);
		}

		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);
			//SupportActionBar.NavigationMode = ActionBar.NavigationMode;
			SetContentView (Resource.Layout.Schedule);
		}

//		public void AddTabToActionBar (string labelResourceId)
//		{
//			suppActBar.Tab tab = SupportActionBar.NewTab ()
//				.SetText (labelResourceId)
//
//				.SetTabListener (this);
//			SupportActionBar.AddTab (tab);
//		}
//
	}
}

