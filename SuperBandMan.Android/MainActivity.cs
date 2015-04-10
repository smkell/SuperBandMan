using Android.App;
using Android.OS;
using Android.Support.V4.App;
using Android.Support.V4.View;
using Android.Views;
using Android.Widget;
using Fragment = Android.Support.V4.App.Fragment;
using FragmentTransaction = Android.Support.V4.App.FragmentTransaction;

namespace SuperBandMan.Android
{
    [Activity(Label = "SuperBandMan.Android", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : FragmentActivity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            if (bundle == null)
            {
                FragmentTransaction transaction = SupportFragmentManager.BeginTransaction();
                SlidingTabsBasicFragment fragment = new SlidingTabsBasicFragment();
                transaction.Replace(Resource.Id.SampleContentFragment, fragment);
                transaction.Commit();
            }
        }

        public override bool OnCreateOptionsMenu(IMenu menu)
        {
            MenuInflater.Inflate(Resource.Menu.Main, menu);
            return true;
        }
    }

    public class SlidingTabsBasicFragment : Fragment
    {
        private ViewPager mViewPager;

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.SampleFragment, container, false);
        }

        public override void OnViewCreated(View view, Bundle savedInstanceState)
        {
            mViewPager = view.FindViewById<ViewPager>(Resource.Id.ViewPager);
        }
    }
}

