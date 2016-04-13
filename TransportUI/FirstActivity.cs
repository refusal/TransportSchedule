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
	public class FirstActivity:ListActivity
	{
		string[] items;
		protected override void OnCreate(Bundle bundle)
		{
			base.OnCreate(bundle);
			items = new string[] { "number1","number2","number3","number4","number5","number6","number1","number2","number3","number4","number5","number6" };
			ListAdapter = new ArrayAdapter<String>(this, Android.Resource.Layout.SimpleListItem1, items);
		}
	}
}

