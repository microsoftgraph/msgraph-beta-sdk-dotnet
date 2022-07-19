using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device Access Rules in Exchange.</summary>
    public class DeviceManagementExchangeAccessRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Access Level in Exchange.</summary>
        public DeviceManagementExchangeAccessLevel? AccessLevel {
            get { return BackingStore?.Get<DeviceManagementExchangeAccessLevel?>("accessLevel"); }
            set { BackingStore?.Set("accessLevel", value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Device Class which will be impacted by this rule.</summary>
        public DeviceManagementExchangeDeviceClass DeviceClass {
            get { return BackingStore?.Get<DeviceManagementExchangeDeviceClass>("deviceClass"); }
            set { BackingStore?.Set("deviceClass", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new deviceManagementExchangeAccessRule and sets the default values.
        /// </summary>
        public DeviceManagementExchangeAccessRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.deviceManagementExchangeAccessRule";
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
