using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Represents a property of the ChromeOS device.</summary>
    public class ChromeOSDeviceProperty : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of the property</summary>
        public string Name { get; set; }
        /// <summary>Whether this property is updatable</summary>
        public bool? Updatable { get; set; }
        /// <summary>Value of the property</summary>
        public string Value { get; set; }
        /// <summary>Type of the value</summary>
        public string ValueType { get; set; }
        /// <summary>
        /// Instantiates a new chromeOSDeviceProperty and sets the default values.
        /// </summary>
        public ChromeOSDeviceProperty() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ChromeOSDeviceProperty CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChromeOSDeviceProperty();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"name", (o,n) => { (o as ChromeOSDeviceProperty).Name = n.GetStringValue(); } },
                {"updatable", (o,n) => { (o as ChromeOSDeviceProperty).Updatable = n.GetBoolValue(); } },
                {"value", (o,n) => { (o as ChromeOSDeviceProperty).Value = n.GetStringValue(); } },
                {"valueType", (o,n) => { (o as ChromeOSDeviceProperty).ValueType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("name", Name);
            writer.WriteBoolValue("updatable", Updatable);
            writer.WriteStringValue("value", Value);
            writer.WriteStringValue("valueType", ValueType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
