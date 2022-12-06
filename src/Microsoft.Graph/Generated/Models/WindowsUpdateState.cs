using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class WindowsUpdateState : Entity, IParsable {
        /// <summary>Device display name.</summary>
        public string DeviceDisplayName {
            get { return BackingStore?.Get<string>("deviceDisplayName"); }
            set { BackingStore?.Set("deviceDisplayName", value); }
        }
        /// <summary>The id of the device.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The current feature update version of the device.</summary>
        public string FeatureUpdateVersion {
            get { return BackingStore?.Get<string>("featureUpdateVersion"); }
            set { BackingStore?.Set("featureUpdateVersion", value); }
        }
        /// <summary>The date time that the Windows Update Agent did a successful scan.</summary>
        public DateTimeOffset? LastScanDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastScanDateTime"); }
            set { BackingStore?.Set("lastScanDateTime", value); }
        }
        /// <summary>Last date time that the device sync with with Microsoft Intune.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The Quality Update Version of the device.</summary>
        public string QualityUpdateVersion {
            get { return BackingStore?.Get<string>("qualityUpdateVersion"); }
            set { BackingStore?.Set("qualityUpdateVersion", value); }
        }
        /// <summary>Windows update for business configuration device states</summary>
        public WindowsUpdateStatus? Status {
            get { return BackingStore?.Get<WindowsUpdateStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>The id of the user.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>User principal name.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsUpdateState CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsUpdateState();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceDisplayName", n => { DeviceDisplayName = n.GetStringValue(); } },
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"featureUpdateVersion", n => { FeatureUpdateVersion = n.GetStringValue(); } },
                {"lastScanDateTime", n => { LastScanDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"qualityUpdateVersion", n => { QualityUpdateVersion = n.GetStringValue(); } },
                {"status", n => { Status = n.GetEnumValue<WindowsUpdateStatus>(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceDisplayName", DeviceDisplayName);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("featureUpdateVersion", FeatureUpdateVersion);
            writer.WriteDateTimeOffsetValue("lastScanDateTime", LastScanDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("qualityUpdateVersion", QualityUpdateVersion);
            writer.WriteEnumValue<WindowsUpdateStatus>("status", Status);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
