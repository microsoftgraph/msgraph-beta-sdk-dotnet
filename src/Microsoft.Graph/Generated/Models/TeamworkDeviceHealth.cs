using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDeviceHealth : Entity, IParsable {
        /// <summary>The connection property</summary>
        public TeamworkConnection Connection { get; set; }
        /// <summary>Identity of the user who created the device health document.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The UTC date and time when the device health document was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Health details about the device hardware.</summary>
        public TeamworkHardwareHealth HardwareHealth { get; set; }
        /// <summary>Identity of the user who last modified the device health details.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The UTC date and time when the device health detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The login status of Microsoft Teams, Skype for Business, and Exchange.</summary>
        public TeamworkLoginStatus LoginStatus { get; set; }
        /// <summary>Health details about all peripherals (for example, speaker and microphone) attached to a device.</summary>
        public TeamworkPeripheralsHealth PeripheralsHealth { get; set; }
        /// <summary>Software updates available for the device.</summary>
        public TeamworkSoftwareUpdateHealth SoftwareUpdateHealth { get; set; }
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
