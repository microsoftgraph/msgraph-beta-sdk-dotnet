using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkDeviceHealth : Entity, IParsable {
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"connection", (o,n) => { (o as TeamworkDeviceHealth).Connection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"createdBy", (o,n) => { (o as TeamworkDeviceHealth).CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as TeamworkDeviceHealth).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"hardwareHealth", (o,n) => { (o as TeamworkDeviceHealth).HardwareHealth = n.GetObjectValue<TeamworkHardwareHealth>(TeamworkHardwareHealth.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", (o,n) => { (o as TeamworkDeviceHealth).LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", (o,n) => { (o as TeamworkDeviceHealth).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"loginStatus", (o,n) => { (o as TeamworkDeviceHealth).LoginStatus = n.GetObjectValue<TeamworkLoginStatus>(TeamworkLoginStatus.CreateFromDiscriminatorValue); } },
                {"peripheralsHealth", (o,n) => { (o as TeamworkDeviceHealth).PeripheralsHealth = n.GetObjectValue<TeamworkPeripheralsHealth>(TeamworkPeripheralsHealth.CreateFromDiscriminatorValue); } },
                {"softwareUpdateHealth", (o,n) => { (o as TeamworkDeviceHealth).SoftwareUpdateHealth = n.GetObjectValue<TeamworkSoftwareUpdateHealth>(TeamworkSoftwareUpdateHealth.CreateFromDiscriminatorValue); } },
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
