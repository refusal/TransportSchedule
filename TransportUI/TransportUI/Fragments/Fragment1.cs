
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace TransportUI
{
	public class Fragment1 : Android.Support.V4.App.Fragment, View.IOnTouchListener
	{
		private FrameLayout mPullUpFragmentContainer;
		private float mLastPosY;

		public override void OnCreate (Android.OS.Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);
		}

		public override Android.Views.View OnCreateView (Android.Views.LayoutInflater inflater, Android.Views.ViewGroup container, Android.OS.Bundle savedInstanceState)
		{
			View view = inflater.Inflate(Resource.Layout.Fragment1, container, false);

			Button button = view.FindViewById<Button>(Resource.Id.fragment1Btn);
			mPullUpFragmentContainer = view.FindViewById<FrameLayout>(Resource.Id.pullUpFragmentCnt);

			var trans = Activity.SupportFragmentManager.BeginTransaction();
			trans.Add(mPullUpFragmentContainer.Id, new PullUpFragment(), "PullUpFragment");
			trans.Commit();

			button.Click += (object sender, EventArgs e) => 
			{

				if (mPullUpFragmentContainer.TranslationY + 2 >= mPullUpFragmentContainer.Height)
				{
					var interpolator = new Android.Views.Animations.OvershootInterpolator(5);
					mPullUpFragmentContainer.Animate().SetInterpolator(interpolator)
						.TranslationYBy(-200)
						.SetDuration(500);
				}
			};


			mPullUpFragmentContainer.SetOnTouchListener (this);
			return view;
		}

		public bool OnTouch (View v, MotionEvent e)
		{
			switch (e.Action)
			{
			case MotionEventActions.Down:

				mLastPosY = e.GetY();
				return true;

			case MotionEventActions.Move:

				var currentPosition = e.GetY();
				var deltaY = mLastPosY - currentPosition;

				var transY = v.TranslationY;

				transY -= deltaY;

				if (transY < 0)
				{
					transY = 0;
				}

				v.TranslationY = transY;

				return true;

			default:
				return v.OnTouchEvent(e);
			}
		}
	}
}

