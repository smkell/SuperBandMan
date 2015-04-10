using System.Reflection;

using Android.App;
using Android.OS;
using Xamarin.Android.NUnitLite;
using Microsoft.Band;
using NUnit.Framework;

namespace SuperBandMan.Android.Tests
{
    [Activity(Label = "SuperBandMan.Android.Tests", MainLauncher = true)]
    public class MainActivity : TestSuiteActivity
    {
        public static IBandClient BandClient { get; private set; }

        protected async override void OnCreate(Bundle bundle)
        {
            // tests can be inside the main assembly
            AddTest(Assembly.GetExecutingAssembly());
            // or in any reference assemblies
            // AddTest (typeof (Your.Library.TestClass).Assembly);

            // Once you called base.OnCreate(), you cannot add more assemblies.
            base.OnCreate(bundle);

            IBandDeviceInfo[] pairedBands = BandClientManager.Instance.GetPairedBands();
            if (pairedBands.Length < 1)
            {
                Assert.Inconclusive("No Microsoft Bands available!");
            }
            IBandClient bandClient = BandClientManager.Instance.Create(this, pairedBands[0]);
            ConnectionResult result = await bandClient.ConnectTaskAsync();
            Assert.AreEqual(ConnectionResult.Ok, result);

            BandClient = bandClient;
        }
    }
}

