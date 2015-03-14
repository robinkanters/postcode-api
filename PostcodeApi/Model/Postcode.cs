using System.Runtime.Serialization;

namespace PostcodeApi.Model
{
    [DataContract]
    internal class PostcodeResponse
    {
        private Postcode _postcode;
        private bool _success;

        [DataMember(Name = "resource")]
        public Postcode Resource
        {
            get { return _postcode; }
            private set { _postcode = value; }
        }

        [DataMember(Name = "success")]
        public bool Success
        {
            get { return _success; }
            private set { _success = value; }
        }
    }

    [DataContract]
    public class Postcode
    {
        [DataMember(Name = "street")]
        public string Street { get; private set; }

        [DataMember(Name = "town")]
        public string Town { get; private set; }

        [DataMember(Name = "municipality")]
        public string Municipality { get; private set; }

        [DataMember(Name = "postcode")]
        public string PostcodeQuery { get; private set; }

        [DataMember(Name = "longitude")]
        public float Longitude { get; private set; }

        [DataMember(Name = "latitude")]
        public float Latitude { get; private set; }

        [DataMember(Name = "bag")]
        public BagInfo BagInfo { get; private set; }

        /// <summary>
        /// Restricting access to constructor
        /// </summary>
//        internal Postcode()
//        {
//        }

        internal Postcode(string postcode, string street, string town, string municipality, float longitude, float latitude)
        {
            Street = street;
            Town = town;
            Municipality = municipality;
            PostcodeQuery = postcode;
            Longitude = longitude;
            Latitude = latitude;
        }

        public override string ToString()
        {
            return string.Format("Street: {0}, Town: {1}, Municipality: {2}, PostcodeQuery: {3}, Longitude: {4}, Latitude: {5}, BagInfo: {6}",
                Street, Town, Municipality, PostcodeQuery, Longitude, Latitude, BagInfo);
        }
    }
}
