using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>History Item contained in the Mobile App Troubleshooting Event.</summary>
    public class MobileAppTroubleshootingHistoryItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Time when the history item occurred.</summary>
        public DateTimeOffset? OccurrenceDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("occurrenceDateTime"); }
            set { BackingStore?.Set("occurrenceDateTime", value); }
        }
        /// <summary>Object containing detailed information about the error and its remediation.</summary>
        public DeviceManagementTroubleshootingErrorDetails TroubleshootingErrorDetails {
            get { return BackingStore?.Get<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails"); }
            set { BackingStore?.Set("troubleshootingErrorDetails", value); }
        }
        /// <summary>The type property</summary>
        public string Type {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new mobileAppTroubleshootingHistoryItem and sets the default values.
        /// </summary>
        public MobileAppTroubleshootingHistoryItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            Type = "#microsoft.graph.mobileAppTroubleshootingHistoryItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MobileAppTroubleshootingHistoryItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.mobileAppTroubleshootingAppPolicyCreationHistory" => new MobileAppTroubleshootingAppPolicyCreationHistory(),
                "#microsoft.graph.mobileAppTroubleshootingAppStateHistory" => new MobileAppTroubleshootingAppStateHistory(),
                "#microsoft.graph.mobileAppTroubleshootingAppTargetHistory" => new MobileAppTroubleshootingAppTargetHistory(),
                "#microsoft.graph.mobileAppTroubleshootingAppUpdateHistory" => new MobileAppTroubleshootingAppUpdateHistory(),
                "#microsoft.graph.mobileAppTroubleshootingDeviceCheckinHistory" => new MobileAppTroubleshootingDeviceCheckinHistory(),
                _ => new MobileAppTroubleshootingHistoryItem(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"occurrenceDateTime", n => { OccurrenceDateTime = n.GetDateTimeOffsetValue(); } },
                {"troubleshootingErrorDetails", n => { TroubleshootingErrorDetails = n.GetObjectValue<DeviceManagementTroubleshootingErrorDetails>(DeviceManagementTroubleshootingErrorDetails.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { Type = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("occurrenceDateTime", OccurrenceDateTime);
            writer.WriteObjectValue<DeviceManagementTroubleshootingErrorDetails>("troubleshootingErrorDetails", TroubleshootingErrorDetails);
            writer.WriteStringValue("@odata.type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
