using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.DeviceManagement.ComanagedDevices.Item.ManagedDeviceMobileAppConfigurationStates {
    public class ManagedDeviceMobileAppConfigurationStatesResponse : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NextLink { get; set; }
        public List<ManagedDeviceMobileAppConfigurationState> Value { get; set; }
        /// <summary>
        /// Instantiates a new managedDeviceMobileAppConfigurationStatesResponse and sets the default values.
        /// </summary>
        public ManagedDeviceMobileAppConfigurationStatesResponse() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"@odata.nextLink", (o,n) => { (o as ManagedDeviceMobileAppConfigurationStatesResponse).NextLink = n.GetStringValue(); } },
                {"value", (o,n) => { (o as ManagedDeviceMobileAppConfigurationStatesResponse).Value = n.GetCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationState>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.nextLink", NextLink);
            writer.WriteCollectionOfObjectValues<ManagedDeviceMobileAppConfigurationState>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
