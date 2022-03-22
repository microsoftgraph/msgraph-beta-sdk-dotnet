using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PostalAddressType : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string City { get; set; }
        public string CountryLetterCode { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Street { get; set; }
        /// <summary>
        /// Instantiates a new postalAddressType and sets the default values.
        /// </summary>
        public PostalAddressType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PostalAddressType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PostalAddressType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"city", (o,n) => { (o as PostalAddressType).City = n.GetStringValue(); } },
                {"countryLetterCode", (o,n) => { (o as PostalAddressType).CountryLetterCode = n.GetStringValue(); } },
                {"postalCode", (o,n) => { (o as PostalAddressType).PostalCode = n.GetStringValue(); } },
                {"state", (o,n) => { (o as PostalAddressType).State = n.GetStringValue(); } },
                {"street", (o,n) => { (o as PostalAddressType).Street = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("countryLetterCode", CountryLetterCode);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
