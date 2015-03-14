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

        public override string ToString()
        {
            return string.Format("Id: {0}, Type: {1}, Purpose: {2}", Id, Type, Purpose);
        }
    }
}