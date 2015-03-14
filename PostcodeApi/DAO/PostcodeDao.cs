using System;
using PostcodeApi.Model;

namespace PostcodeApi.DAO
{
    class PostcodeDao : BaseDao<PostcodeResponse>
    {
        public string ApiKey { private get; set; }

        internal PostcodeDao(string apiKey)
        {
            ApiKey = apiKey;
        }

        internal PostcodeResponse Query(string query)
        {
            return base.Query(ApiKey, query);
        }
    }
}
