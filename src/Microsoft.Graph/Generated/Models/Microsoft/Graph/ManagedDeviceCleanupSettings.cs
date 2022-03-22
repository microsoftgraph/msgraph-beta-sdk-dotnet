using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Define the rule when the admin wants the devices to be cleaned up.</summary>
    public class ManagedDeviceCleanupSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of days when the device has not contacted Intune.</summary>
        public string DeviceInactivityBeforeRetirementInDays { get; set; }
        /// <summary>
        /// Instantiates a new managedDeviceCleanupSettings and sets the default values.
        /// </summary>
        public ManagedDeviceCleanupSettings() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"deviceInactivityBeforeRetirementInDays", (o,n) => { (o as ManagedDeviceCleanupSettings).DeviceInactivityBeforeRetirementInDays = n.GetStringValue(); } },
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
