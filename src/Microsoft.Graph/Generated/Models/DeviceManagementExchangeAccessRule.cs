using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Access Rules in Exchange.</summary>
    public class DeviceManagementExchangeAccessRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Access Level for Exchange granted by this rule. Possible values are: none, allow, block, quarantine.</summary>
        public DeviceManagementExchangeAccessLevel? AccessLevel {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessLevel?>(nameof(AccessLevel)); }
            set { BackingStore?.Set(nameof(AccessLevel), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device Class which will be impacted by this rule.</summary>
        public DeviceManagementExchangeDeviceClass DeviceClass {
            get { return BackingStore?.Get<DeviceManagementExchangeDeviceClass>(nameof(DeviceClass)); }
            set { BackingStore?.Set(nameof(DeviceClass), value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementExchangeAccessRule and sets the default values.
        /// </summary>
        public DeviceManagementExchangeAccessRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceManagementExchangeAccessRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementExchangeAccessRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessLevel", n => { AccessLevel = n.GetEnumValue<DeviceManagementExchangeAccessLevel>(); } },
                {"deviceClass", n => { DeviceClass = n.GetObjectValue<DeviceManagementExchangeDeviceClass>(DeviceManagementExchangeDeviceClass.CreateFromDiscriminatorValue); } },
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
