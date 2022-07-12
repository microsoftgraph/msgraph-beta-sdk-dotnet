using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Define the rule when the admin wants the devices to be cleaned up.</summary>
    public class ManagedDeviceCleanupSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of days when the device has not contacted Intune.</summary>
        public string DeviceInactivityBeforeRetirementInDays {
            get { return BackingStore?.Get<string>("deviceInactivityBeforeRetirementInDays"); }
            set { BackingStore?.Set("deviceInactivityBeforeRetirementInDays", value); }
        }
        /// <summary>
        /// Instantiates a new managedDeviceCleanupSettings and sets the default values.
        /// </summary>
        public ManagedDeviceCleanupSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ManagedDeviceCleanupSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceCleanupSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"deviceInactivityBeforeRetirementInDays", n => { DeviceInactivityBeforeRetirementInDays = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("deviceInactivityBeforeRetirementInDays", DeviceInactivityBeforeRetirementInDays);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
