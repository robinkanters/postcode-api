using System.Runtime.Serialization;

namespace PostcodeApi.Model
{
    [DataContract]
    public class BagInfo
    {
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        [DataMember(Name = "type")]
        public string Type { get; private set; }

        [DataMember(Name = "purpose")]
        public string Purpose { get; private set; }

        internal BagInfo()
        {
        }
    }
}