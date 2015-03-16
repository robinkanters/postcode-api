using System.Net;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;
using PostcodeApi.Model;
using Assert = NUnit.Framework.Assert;

namespace PostcodeApi.Test
{
    [TestFixture]
    public class PostcodeDaoTest
    {
        private string apiKey = "20c5839823dafd1231ccd0a556e3c11ce80a2483";

        [Test]
        [TestCase("5062KT")]
        [TestCase("5674CD")]
        [TestCase("5061CE")]
        [TestCase("5038TK")]
        public void CanGetExistingPostcodeInformation(string postcode)
        {
            Postcode result = Client.GetPostcodeInformation(postcode);

            Assert.IsNotNull(result);

            // Print postcode info to output
            System.Diagnostics.Debug.WriteLine(result.ToString());
        }

        [Test]
        [TestCase("5062KT")]
        [TestCase("5674CD")]
        [TestCase("5061CE")]
        [TestCase("5038TK")]
        public void PostcodeHasNoBagInformation(string postcode)
        {
            Postcode result = Client.GetPostcodeInformation(postcode);

            Assert.IsNull(result.BagInfo);
            Assert.IsNull(result.BagInfo?.Purpose);
            Assert.IsNull(result.BagInfo?.Type);
        }

        [Test]
        [TestCase("5062KT", "136")]
        [TestCase("5674CD", "4a")]
        [TestCase("5061CE", "78")]
        [TestCase("5038TK", "49")]
        public void PostcodeWithNumberHasBagInformation(string postcode, string number)
        {
            Postcode result = Client.GetAddressInformation(postcode, number);

            Assert.IsNotNull(result.BagInfo);
            Assert.IsNotEmpty(result.BagInfo.Purpose);
            Assert.IsNotEmpty(result.BagInfo.Type);

            // Print address info to output
            System.Diagnostics.Debug.WriteLine(result.ToString());
        }

        [Test]
        [TestCase("1000AA")]
        public void CanNotGetFakePostcodeInformation(string postcode)
        {
            Postcode result = Client.GetPostcodeInformation(postcode);

            Assert.IsNull(result);
        }

        [Test]
        [TestCase(51.5664f, 5.07718f)]
        public void CanGetAddressFromCoordinates(float latitude, float longitude)
        {
            Postcode result = Client.GetAddressFromCoordinates(latitude, longitude);

            Assert.NotNull(result);

            Assert.IsNotEmpty(result.BagInfo.Purpose);
            Assert.IsNotEmpty(result.BagInfo.Type);

            Assert.AreEqual(result.Street, "Wilhelminapark");

            System.Diagnostics.Debug.WriteLine(result.ToString());
        }

        private PostcodeApiClient _api;
        private PostcodeApiClient Client
        {
            get
            {
                if (_api == null) _api = new PostcodeApiClient(apiKey);
                return _api;
            }
        }
    }
}
