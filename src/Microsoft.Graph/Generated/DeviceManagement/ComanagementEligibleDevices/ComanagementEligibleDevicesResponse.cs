using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.ComanagementEligibleDevices {
    public class ComanagementEligibleDevicesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<ComanagementEligibleDevice> Value { get; set; }
        /// <summary>
        /// Instantiates a new comanagementEligibleDevicesResponse and sets the default values.
        /// </summary>
        public ComanagementEligibleDevicesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as ComanagementEligibleDevicesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as ComanagementEligibleDevicesResponse).Value = n.GetCollectionOfObjectValues<ComanagementEligibleDevice>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<ComanagementEligibleDevice>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
