using System;
using PostcodeApi.DAO;
using PostcodeApi.Model;

namespace PostcodeApi
{
    public class PostcodeApiClient
    {
        public string ApiKey { private get; set; }

        public PostcodeApiClient(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Find information about a postcode by supplying it as a string
        /// </summary>
        /// <param name="postcode">The postcode to postcode</param>
        /// <returns></returns>
        public Postcode GetPostcodeInformation(string postcode)
        {
            PostcodeDao dao = new PostcodeDao(ApiKey);

            return dao.Query(postcode)?.Resource;
        }

        /// <summary>
        /// Find information about a postcode by supplying it as a string
        /// </summary>
        /// <param name="postcode">The postcode to postcode</param>
        /// <returns></returns>
        public Postcode GetAddressInformation(string postcode, string number)
        {
            PostcodeDao dao = new PostcodeDao(ApiKey);

            return dao.Query(postcode, number)?.Resource;
        }
    }
}
