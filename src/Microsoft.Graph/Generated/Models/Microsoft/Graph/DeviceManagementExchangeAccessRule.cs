using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementExchangeAccessRule : IParsable {
        /// <summary>Access Level for Exchange granted by this rule. Possible values are: none, allow, block, quarantine.</summary>
        public DeviceManagementExchangeAccessLevel? AccessLevel { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Device Class which will be impacted by this rule.</summary>
        public DeviceManagementExchangeDeviceClass DeviceClass { get; set; }
        /// <summary>
        /// Instantiates a new deviceManagementExchangeAccessRule and sets the default values.
        /// </summary>
        public DeviceManagementExchangeAccessRule() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessLevel", (o,n) => { (o as DeviceManagementExchangeAccessRule).AccessLevel = n.GetEnumValue<DeviceManagementExchangeAccessLevel>(); } },
                {"deviceClass", (o,n) => { (o as DeviceManagementExchangeAccessRule).DeviceClass = n.GetObjectValue<DeviceManagementExchangeDeviceClass>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<DeviceManagementExchangeAccessLevel>("accessLevel", AccessLevel);
            writer.WriteObjectValue<DeviceManagementExchangeDeviceClass>("deviceClass", DeviceClass);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
