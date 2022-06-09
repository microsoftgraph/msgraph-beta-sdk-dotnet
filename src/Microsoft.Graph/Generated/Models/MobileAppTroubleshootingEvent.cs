using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MobileAppTroubleshootingEvent : DeviceManagementTroubleshootingEvent, IParsable {
        /// <summary>Intune application identifier.</summary>
        public string ApplicationId {
            get { return BackingStore?.Get<string>(nameof(ApplicationId)); }
            set { BackingStore?.Set(nameof(ApplicationId), value); }
        }
        /// <summary>The collection property of AppLogUploadRequest.</summary>
        public List<AppLogCollectionRequest> AppLogCollectionRequests {
            get { return BackingStore?.Get<List<AppLogCollectionRequest>>(nameof(AppLogCollectionRequests)); }
            set { BackingStore?.Set(nameof(AppLogCollectionRequests), value); }
        }
        /// <summary>Intune Mobile Application Troubleshooting History Item</summary>
        public List<MobileAppTroubleshootingHistoryItem> History {
            get { return BackingStore?.Get<List<MobileAppTroubleshootingHistoryItem>>(nameof(History)); }
            set { BackingStore?.Set(nameof(History), value); }
        }
        /// <summary>Device identifier created or collected by Intune.</summary>
        public string ManagedDeviceIdentifier {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceIdentifier)); }
            set { BackingStore?.Set(nameof(ManagedDeviceIdentifier), value); }
        }
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MobileAppTroubleshootingEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MobileAppTroubleshootingEvent();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicationId", n => { ApplicationId = n.GetStringValue(); } },
                {"appLogCollectionRequests", n => { AppLogCollectionRequests = n.GetCollectionOfObjectValues<AppLogCollectionRequest>(AppLogCollectionRequest.CreateFromDiscriminatorValue).ToList(); } },
                {"history", n => { History = n.GetCollectionOfObjectValues<MobileAppTroubleshootingHistoryItem>(MobileAppTroubleshootingHistoryItem.CreateFromDiscriminatorValue).ToList(); } },
                {"managedDeviceIdentifier", n => { ManagedDeviceIdentifier = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("applicationId", ApplicationId);
            writer.WriteCollectionOfObjectValues<AppLogCollectionRequest>("appLogCollectionRequests", AppLogCollectionRequests);
            writer.WriteCollectionOfObjectValues<MobileAppTroubleshootingHistoryItem>("history", History);
            writer.WriteStringValue("managedDeviceIdentifier", ManagedDeviceIdentifier);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
