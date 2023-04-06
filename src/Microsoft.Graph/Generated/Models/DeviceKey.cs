using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceKey : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The deviceId property</summary>
        public Guid? DeviceId {
            get { return BackingStore?.Get<Guid?>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The keyMaterial property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public byte[]? KeyMaterial {
            get { return BackingStore?.Get<byte[]?>("keyMaterial"); }
            set { BackingStore?.Set("keyMaterial", value); }
        }
#nullable restore
#else
        public byte[] KeyMaterial {
            get { return BackingStore?.Get<byte[]>("keyMaterial"); }
            set { BackingStore?.Set("keyMaterial", value); }
        }
#endif
        /// <summary>The keyType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? KeyType {
            get { return BackingStore?.Get<string?>("keyType"); }
            set { BackingStore?.Set("keyType", value); }
        }
#nullable restore
#else
        public string KeyType {
            get { return BackingStore?.Get<string>("keyType"); }
            set { BackingStore?.Set("keyType", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deviceKey and sets the default values.
        /// </summary>
        public DeviceKey() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeviceKey CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceKey();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceId", n => { DeviceId = n.GetGuidValue(); } },
                {"keyMaterial", n => { KeyMaterial = n.GetByteArrayValue(); } },
                {"keyType", n => { KeyType = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteGuidValue("deviceId", DeviceId);
            writer.WriteByteArrayValue("keyMaterial", KeyMaterial);
            writer.WriteStringValue("keyType", KeyType);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
