using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MobileAppTroubleshootingEvent : DeviceManagementTroubleshootingEvent, IParsable {
        /// <summary>Intune application identifier.</summary>
        public string ApplicationId { get; set; }
        /// <summary>The collection property of AppLogUploadRequest.</summary>
        public List<AppLogCollectionRequest> AppLogCollectionRequests { get; set; }
        /// <summary>Intune Mobile Application Troubleshooting History Item</summary>
        public List<MobileAppTroubleshootingHistoryItem> History { get; set; }
        /// <summary>Device identifier created or collected by Intune.</summary>
        public string ManagedDeviceIdentifier { get; set; }
        /// <summary>Identifier for the user that tried to enroll the device.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicationId", (o,n) => { (o as MobileAppTroubleshootingEvent).ApplicationId = n.GetStringValue(); } },
                {"appLogCollectionRequests", (o,n) => { (o as MobileAppTroubleshootingEvent).AppLogCollectionRequests = n.GetCollectionOfObjectValues<AppLogCollectionRequest>().ToList(); } },
                {"history", (o,n) => { (o as MobileAppTroubleshootingEvent).History = n.GetCollectionOfObjectValues<MobileAppTroubleshootingHistoryItem>().ToList(); } },
                {"managedDeviceIdentifier", (o,n) => { (o as MobileAppTroubleshootingEvent).ManagedDeviceIdentifier = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as MobileAppTroubleshootingEvent).UserId = n.GetStringValue(); } },
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
