using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Represents a property of the ChromeOS device.</summary>
    public class ChromeOSDeviceProperty : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Name of the property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Whether this property is updatable</summary>
        public bool? Updatable {
            get { return BackingStore?.Get<bool?>(nameof(Updatable)); }
            set { BackingStore?.Set(nameof(Updatable), value); }
        }
        /// <summary>Value of the property</summary>
        public string Value {
            get { return BackingStore?.Get<string>(nameof(Value)); }
            set { BackingStore?.Set(nameof(Value), value); }
        }
        /// <summary>Type of the value</summary>
        public string ValueType {
            get { return BackingStore?.Get<string>(nameof(ValueType)); }
            set { BackingStore?.Set(nameof(ValueType), value); }
        }
        /// <summary>
        /// Instantiates a new chromeOSDeviceProperty and sets the default values.
        /// </summary>
        public ChromeOSDeviceProperty() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"name", n => { Name = n.GetStringValue(); } },
                {"updatable", n => { Updatable = n.GetBoolValue(); } },
                {"value", n => { Value = n.GetStringValue(); } },
                {"valueType", n => { ValueType = n.GetStringValue(); } },
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
