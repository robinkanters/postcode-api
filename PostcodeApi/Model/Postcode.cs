using System.Runtime.Serialization;

namespace PostcodeApi.Model
{
    [DataContract]
    internal class PostcodeResponse
    {
        /// <summary>
        /// The actual result of the query
        /// </summary>
        [DataMember(Name = "resource")]
        public Postcode Resource { get; private set; }

        /// <summary>
        /// Whether or not the query was successful
        /// </summary>
        [DataMember(Name = "success")]
        public bool Success { get; private set; }
    }

    [DataContract]
    public class Postcode
    {
        /// <summary>
        /// Name of the street
        /// </summary>
        [DataMember(Name = "street")]
        public string Street { get; private set; }

        /// <summary>
        /// What town the postcode is in
        /// </summary>
        [DataMember(Name = "town")]
        public string Town { get; private set; }

        /// <summary>
        /// The municipality the postcode is in
        /// </summary>
        [DataMember(Name = "municipality")]
        public string Municipality { get; private set; }

        /// <summary>
        /// The postcode that was queried
        /// </summary>
        [DataMember(Name = "postcode")]
        public string PostcodeQuery { get; private set; }

        /// <summary>
        /// The longitude of the postcode for geomapping
        /// </summary>
        [DataMember(Name = "longitude")]
        public float Longitude { get; private set; }

        /// <summary>
        /// The latitude of the postcode for geomapping
        /// </summary>
        [DataMember(Name = "latitude")]
        public float Latitude { get; private set; }

        /// <summary>
        /// BAG (Basisregistraties Adressen en Gebouwen) information (purpose/type/id) 
        /// </summary>
        [DataMember(Name = "bag")]
        public BagInfo BagInfo { get; private set; }

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
            return string.Format("{{Street: '{0}', Town: '{1}', Municipality: '{2}', PostcodeQuery: '{3}', Longitude: '{4}', Latitude: '{5}', BagInfo: {{{6}}}}}",
                Street, Town, Municipality, PostcodeQuery, Longitude, Latitude, BagInfo);
        }
    }
}
