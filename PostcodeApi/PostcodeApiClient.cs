using PostcodeApi.DAO;
using PostcodeApi.Model;

namespace PostcodeApi
{
    public class PostcodeApiClient
    {
        public string ApiKey { private get; set; }

        /// <summary>
        /// Instantiates ApiClient object
        /// </summary>
        /// <param name="apiKey">Your postcodeapi.nu API key</param>
        public PostcodeApiClient(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Find information about a postcode by supplying it as a string
        /// </summary>
        /// <param name="postcode">The postcode to query</param>
        /// <returns>Information about the postcode queried, null if not found.</returns>
        public Postcode GetPostcodeInformation(string postcode)
        {
            PostcodeDao dao = new PostcodeDao(ApiKey);

            return dao.Query(postcode)?.Resource;
        }

        /// <summary>
        /// Find information about a postcode by supplying it as a string
        /// </summary>
        /// <param name="postcode">The postcode to query</param>
        /// <param name="number">The home number to query</param>
        /// <returns>Information about the address queried, null if not found.</returns>
        public Postcode GetAddressInformation(string postcode, string number)
        {
            PostcodeDao dao = new PostcodeDao(ApiKey);

            return dao.Query(postcode, number)?.Resource;
        }
    }
}
