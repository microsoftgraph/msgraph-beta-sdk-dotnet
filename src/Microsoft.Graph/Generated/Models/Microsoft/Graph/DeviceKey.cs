using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceKey : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string DeviceId { get; set; }
        public byte[] KeyMaterial { get; set; }
        public string KeyType { get; set; }
        /// <summary>
        /// Instantiates a new deviceKey and sets the default values.
        /// </summary>
        public DeviceKey() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceId", (o,n) => { (o as DeviceKey).DeviceId = n.GetStringValue(); } },
                {"keyMaterial", (o,n) => { (o as DeviceKey).KeyMaterial = n.GetByteArrayValue(); } },
                {"keyType", (o,n) => { (o as DeviceKey).KeyType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteByteArrayValue("keyMaterial", KeyMaterial);
            writer.WriteStringValue("keyType", KeyType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
