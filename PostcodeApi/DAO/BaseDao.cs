using System;
using System.Diagnostics;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Json;

namespace PostcodeApi.DAO
{
    internal class BaseDao<T>
    {
        internal T Query(string apiKey, string query)
        {
            string url = "http://api.postcodeapi.nu/" + query;

            var restResult = HttpGet(apiKey, url);
            return restResult;
        }

        internal T HttpGet(string apiKey, string url)
        {
            var wrGETURL = WebRequest.Create(url);
            wrGETURL.Headers.Add("Api-Key", apiKey);

            try
            {
                using (var response = wrGETURL.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode != HttpStatusCode.OK)
                        throw new Exception(String.Format(
                            "Server error (HTTP {0}: {1}).",
                            response.StatusCode,
                            response.StatusDescription));

                    var serializer = new DataContractJsonSerializer(typeof(T));
                    var objResponse = (T) serializer.ReadObject(response.GetResponseStream());

                    return objResponse;
                }
            }
            catch (WebException e)
            {
                Debug.WriteLine(string.Format("WebException: {0}", e.Message));
                return default(T);
            }
            catch (NullReferenceException e)
            {
                Debug.WriteLine(string.Format("NullReferenceException: {0}", e.Message));
                return default(T);
            }
        }
    }
}
