using System;

using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using SupportToolbar = Android.Support.V7.Widget.Toolbar;
using Android.Support.V7.App;
using Android.Support.V4.Widget;
using System.Collections.Generic;



namespace TransportUI
{
	[Activity (Label = "TransportUI", MainLauncher = true, Icon = "@mipmap/icon", Theme="@style/MyTheme")]
	public class MainActivity : ActionBarActivity
	{
		
		private SupportToolbar mToolbar;
		private MyActionBarDrawerToggle mDrawerToggle;
		private DrawerLayout mDrawerLayout;
		private ListView mLeftDrawer;
		private ArrayAdapter mLeftAdapter;
		private List<string> mLeftDataSet;
		private int lastSelectedSection = -1;

		//ublic override void OnItemClick(AdapterView parent, View view, int position, long id){
			

       




		protected override void OnCreate (Bundle bundle)
		{
			base.OnCreate (bundle);

			// Set our view from the "main" layout resource
			SetContentView (Resource.Layout.Main);

			mToolbar = FindViewById<SupportToolbar> (Resource.Id.toolbar);
			mDrawerLayout = FindViewById<DrawerLayout> (Resource.Id.drawer_layout);
			mLeftDrawer = FindViewById<ListView> (Resource.Id.left_drawer);


			SetSupportActionBar(mToolbar);



			mLeftDataSet = new List<string> ();
			mLeftDataSet.Add ("Избранное");
			mLeftDataSet.Add ("Расписание");
			mLeftAdapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1,mLeftDataSet);
			mLeftDrawer.Adapter = mLeftAdapter;

			//////////NEWNEWNENW
//			mLeftDataSet = new List<string> ();
//			mLeftDataSet.Add ();
//			mLeftDataSet.Add ("Расписание");
//			mLeftAdapter = new ArrayAdapter<string> (this, Android.Resource.Layout.SimpleListItem1,mLeftDataSet);
//			mLeftDrawer.Adapter = mLeftAdapter;
			////////////NEWNEWNEW

			mLeftDrawer.ItemClick += (sender, args) => ListItemClicked(args.Position);

			//drawerListView.ItemClick += (sender, args) => ListItemClicked(args.Position);


			mDrawerToggle = new MyActionBarDrawerToggle(
				this,              //Host Activity
				mDrawerLayout,     //Drawer Layout
				Resource.String.openDrawer,  //Open Message
				Resource.String.closeDrawer  //Closed Message
			);

			mDrawerLayout.SetDrawerListener(mDrawerToggle);
			SupportActionBar.SetHomeButtonEnabled(true);
			SupportActionBar.SetDisplayHomeAsUpEnabled (true);
			mDrawerToggle.SyncState();

			if (bundle != null) 
			{
				if (bundle.GetString ("DrawerState") == "Opened") {
					
					SupportActionBar.SetTitle (Resource.String.openDrawer);
				}
				else {
				
					SupportActionBar.SetTitle (Resource.String.closeDrawer);
				}
			}
			else 
			{
				//First time activity ran
				SupportActionBar.SetTitle(Resource.String.closeDrawer);
			}





		}
		private void ListItemClicked(int position)
		{
			if (lastSelectedSection == position)
				return;

			lastSelectedSection = position;

			switch (position)
			{
				case 0:
//						fragment = Fragment1.NewInstance();
						StartActivity (typeof(Schedule));
						break;
				case 1:
//						fragment = Fragment2.NewInstance();
						StartActivity (typeof(Schedule));
						break;
			}
		}
			

		public override bool OnOptionsItemSelected (IMenuItem item)
		{
            switch(item.ItemId)
            {
                case (Resource.Id.drawer_layout):
            	StartActivity (typeof(BaseLayout));
            	return true;


             	case (Resource.Id.schedule_menu):
            	StartActivity (typeof(BaseLayout));
            	return true;

            	default:
            	mDrawerToggle.OnOptionsItemSelected (item);
            	return base.OnOptionsItemSelected (item);
            }

//			if (mDrawerToggle.OnOptionsItemSelected(item:))
//            {
//                //Intent intent = new Intent(this, typeof(Schedule));
//                Intent intent = new Intent(this, typeof(Schedule));
//                StartActivity(intent);
//            }
//            mDrawerToggle.OnOptionsItemSelected(item);
//            return base.OnOptionsItemSelected(item);
        }

		protected override void OnSaveInstanceState (Bundle outState)
		{
			if (mDrawerLayout.IsDrawerOpen ((int)GravityFlags.Left)) {
			
				outState.PutString ("DrawerState", "Opened");
			}
			else {
			
				outState.PutString ("DrawerState", "Closed");
			}
			base.OnSaveInstanceState (outState);
		}


		protected override void OnPostCreate (Bundle savedInstanceState)
		{
			base.OnPostCreate (savedInstanceState);
			mDrawerToggle.SyncState ();
		}
		public override bool OnCreateOptionsMenu (IMenu menu)
		{
			MenuInflater.Inflate (Resource.Menu.action_menu, menu);
			return base.OnCreateOptionsMenu (menu);
		}

    }
}


