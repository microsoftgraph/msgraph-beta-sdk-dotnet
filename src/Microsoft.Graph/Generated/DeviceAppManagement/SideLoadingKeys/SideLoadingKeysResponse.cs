using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceAppManagement.SideLoadingKeys {
    public class SideLoadingKeysResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<SideLoadingKey> Value { get; set; }
        /// <summary>
        /// Instantiates a new sideLoadingKeysResponse and sets the default values.
        /// </summary>
        public SideLoadingKeysResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as SideLoadingKeysResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as SideLoadingKeysResponse).Value = n.GetCollectionOfObjectValues<SideLoadingKey>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<SideLoadingKey>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
