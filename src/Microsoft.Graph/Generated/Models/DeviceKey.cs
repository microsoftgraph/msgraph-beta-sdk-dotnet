using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceKey : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceId property</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The keyMaterial property</summary>
        public byte[] KeyMaterial {
            get { return BackingStore?.Get<byte[]>(nameof(KeyMaterial)); }
            set { BackingStore?.Set(nameof(KeyMaterial), value); }
        }
        /// <summary>The keyType property</summary>
        public string KeyType {
            get { return BackingStore?.Get<string>(nameof(KeyType)); }
            set { BackingStore?.Set(nameof(KeyType), value); }
        }
        /// <summary>
        /// Instantiates a new deviceKey and sets the default values.
        /// </summary>
        public DeviceKey() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"keyMaterial", n => { KeyMaterial = n.GetByteArrayValue(); } },
                {"keyType", n => { KeyType = n.GetStringValue(); } },
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
