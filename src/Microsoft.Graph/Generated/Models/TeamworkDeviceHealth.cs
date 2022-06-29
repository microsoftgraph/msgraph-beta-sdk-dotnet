using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class TeamworkDeviceHealth : Entity, IParsable {
        /// <summary>The connection property</summary>
        public TeamworkConnection Connection {
            get { return BackingStore?.Get<TeamworkConnection>(nameof(Connection)); }
            set { BackingStore?.Set(nameof(Connection), value); }
        }
        /// <summary>Identity of the user who created the device health document.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The UTC date and time when the device health document was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Health details about the device hardware.</summary>
        public TeamworkHardwareHealth HardwareHealth {
            get { return BackingStore?.Get<TeamworkHardwareHealth>(nameof(HardwareHealth)); }
            set { BackingStore?.Set(nameof(HardwareHealth), value); }
        }
        /// <summary>Identity of the user who last modified the device health details.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The UTC date and time when the device health detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The login status of Microsoft Teams, Skype for Business, and Exchange.</summary>
        public TeamworkLoginStatus LoginStatus {
            get { return BackingStore?.Get<TeamworkLoginStatus>(nameof(LoginStatus)); }
            set { BackingStore?.Set(nameof(LoginStatus), value); }
        }
        /// <summary>Health details about all peripherals (for example, speaker and microphone) attached to a device.</summary>
        public TeamworkPeripheralsHealth PeripheralsHealth {
            get { return BackingStore?.Get<TeamworkPeripheralsHealth>(nameof(PeripheralsHealth)); }
            set { BackingStore?.Set(nameof(PeripheralsHealth), value); }
        }
        /// <summary>Software updates available for the device.</summary>
        public TeamworkSoftwareUpdateHealth SoftwareUpdateHealth {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateHealth>(nameof(SoftwareUpdateHealth)); }
            set { BackingStore?.Set(nameof(SoftwareUpdateHealth), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkDeviceHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDeviceHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"connection", n => { Connection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"hardwareHealth", n => { HardwareHealth = n.GetObjectValue<TeamworkHardwareHealth>(TeamworkHardwareHealth.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"loginStatus", n => { LoginStatus = n.GetObjectValue<TeamworkLoginStatus>(TeamworkLoginStatus.CreateFromDiscriminatorValue); } },
                {"peripheralsHealth", n => { PeripheralsHealth = n.GetObjectValue<TeamworkPeripheralsHealth>(TeamworkPeripheralsHealth.CreateFromDiscriminatorValue); } },
                {"softwareUpdateHealth", n => { SoftwareUpdateHealth = n.GetObjectValue<TeamworkSoftwareUpdateHealth>(TeamworkSoftwareUpdateHealth.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkConnection>("connection", Connection);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<TeamworkHardwareHealth>("hardwareHealth", HardwareHealth);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<TeamworkLoginStatus>("loginStatus", LoginStatus);
            writer.WriteObjectValue<TeamworkPeripheralsHealth>("peripheralsHealth", PeripheralsHealth);
            writer.WriteObjectValue<TeamworkSoftwareUpdateHealth>("softwareUpdateHealth", SoftwareUpdateHealth);
        }
    }
}
