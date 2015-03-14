using PostcodeApi.DAO;
using PostcodeApi.Model;

namespace PostcodeApi
{
    public class PostcodeApi
    {
        public string ApiKey { private get; set; }

        public PostcodeApi(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Find information about a postcode by supplying it as a string
        /// </summary>
        /// <param name="query">The postcode to query</param>
        /// <returns></returns>
        public Postcode GetPostcodeInformation(string query)
        {
            PostcodeDao dao = new PostcodeDao(ApiKey);
            return dao.Query(query).Resource;
        }
    }
}
