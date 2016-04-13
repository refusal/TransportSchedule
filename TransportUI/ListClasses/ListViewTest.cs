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

namespace TransportUI
{
	[Activity]
	public class ListViewTest: ListActivity
	{
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			string[] items = new string[] { "asdsdg", "asddsgd", "dfgfg", "asdsa" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem2, items);
		}

	}
}

