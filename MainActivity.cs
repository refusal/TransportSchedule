using Android.App;
using Android.Widget;
using Android.OS;
using Android.Gms.Maps;
using Android.Locations;
using System.Collections.Generic;
using System.Linq;
using Android.Gms.Maps.Model;

namespace TransportTime
{
	[Activity (Label = "Transport", MainLauncher = true, Icon = "@mipmap/icon")]
	public class MainActivity : Activity
	{

		private GoogleMap mMap;
		private Location location;
		private MapFragment _mapFragment;
		//private string _locationProvider;
		//private LocationManager _locationManager;
		protected override void OnCreate (Bundle savedInstanceState)
		{
			base.OnCreate (savedInstanceState);

			SetContentView (Resource.Layout.Main);
			InitMap ();
			addPolyLine ();

		}
		private void InitMap()
		{
			_mapFragment = FragmentManager.FindFragmentById<MapFragment> (Resource.Id.map);
			mMap = _mapFragment.Map;
			mMap.MyLocationEnabled=true;
			mMap.UiSettings.MyLocationButtonEnabled = true;
			if (_mapFragment == null) {
				GoogleMapOptions mapOptions = new GoogleMapOptions ()
					.InvokeMapType (GoogleMap.MapTypeSatellite)
					.InvokeCompassEnabled (true)
					.InvokeZoomControlsEnabled (true);


				FragmentTransaction fragTR = FragmentManager.BeginTransaction ();
				_mapFragment = MapFragment.NewInstance(mapOptions);
				fragTR.Add (Resource.Id.map,_mapFragment,"map");
				fragTR.Commit ();
			}
		}
		private void addPolyLine()
		{
			PolylineOptions rectOptions = new PolylineOptions()
				.Add(new LatLng(53.9327, 30.25))
				.Add(new LatLng(53.9175, 30.31));

			// Get back the mutable Polyline
			Polyline polyline = mMap.AddPolyline(rectOptions);
		}
		//		private void InitLoc()
		//		{
		//			LocationManager _locationManager = (LocationManager)GetSystemService (LocationService);
		//			Criteria criteriaForLocationService = new Criteria
		//			{
		//				Accuracy = Accuracy.Fine
		//			};
		//			IList<string> acceptableLocationProviders = _locationManager.GetProviders(criteriaForLocationService, true);
		//			if (acceptableLocationProviders.Any())
		//			{
		//				_locationProvider = acceptableLocationProviders.First();
		//			}
		//			else
		//			{
		//				_locationProvider = string.Empty;
		//			}
		//		}

		protected override void OnResume()
		{
			base.OnResume();
		}
		protected override void OnPause()
		{
			base.OnPause();
		}
	}
}


