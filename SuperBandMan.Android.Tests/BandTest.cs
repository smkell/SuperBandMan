using System;
using NUnit.Framework;
using Microsoft.Band;

namespace SuperBandMan.Android.Tests
{
    [TestFixture]
    public class BandTest
    {
        [Test]
        public void ConnectedTest()
        {
            IBandClient client = MainActivity.BandClient;
            Assert.IsTrue(client.IsConnected);
        }
    }
}

