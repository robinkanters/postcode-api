using PostcodeApi.Model;

namespace PostcodeApi.DAO
{
    class PostcodeDao : BaseDao<PostcodeResponse>
    {
        private string ApiKey { get; set; }

        internal PostcodeDao(string apiKey)
        {
            ApiKey = apiKey;
        }

        // TODO Throw proper exception (e.g. PostcodeNotFoundException) when postcode not found instead of null
        internal PostcodeResponse Query(string postcode)
        {
            return base.Query(ApiKey, string.Format("{0}?view=bag", postcode));
        }

        // TODO Throw proper exception (e.g. AddressNotFoundException) when address not found instead of null
        internal PostcodeResponse Query(string postcode, string number)
        {
            return base.Query(ApiKey, string.Format("{0}/{1}?view=bag", postcode, number));
        }
        // TODO Throw proper exception (e.g. AddressNotFoundException) when address not found instead of null
        internal PostcodeResponse Query(float latitude, float longitude)
        {
            return base.Query(ApiKey, string.Format("wgs84/{0},{1}?view=bag", latitude, longitude));
        }
    }
}
