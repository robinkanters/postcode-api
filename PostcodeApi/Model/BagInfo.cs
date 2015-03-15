using System.Runtime.Serialization;

namespace PostcodeApi.Model
{
    [DataContract]
    public class BagInfo
    {
        /// <summary>
        /// BAG ID corresponding to Dutch Land register's database
        /// </summary>
        [DataMember(Name = "id")]
        public string Id { get; private set; }

        /// <summary>
        /// Type of object (in Dutch)
        /// </summary>
        [DataMember(Name = "type")]
        public string Type { get; private set; }

        /// <summary>
        /// Purpose of the object (shop/office/home) (in Dutch)
        /// </summary>
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