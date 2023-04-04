using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDeviceHealth : Entity, IParsable {
        /// <summary>The connection property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkConnection? Connection {
            get { return BackingStore?.Get<TeamworkConnection?>("connection"); }
            set { BackingStore?.Set("connection", value); }
        }
#nullable restore
#else
        public TeamworkConnection Connection {
            get { return BackingStore?.Get<TeamworkConnection>("connection"); }
            set { BackingStore?.Set("connection", value); }
        }
#endif
        /// <summary>Identity of the user who created the device health document.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? CreatedBy {
            get { return BackingStore?.Get<IdentitySet?>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#nullable restore
#else
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>("createdBy"); }
            set { BackingStore?.Set("createdBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device health document was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("createdDateTime"); }
            set { BackingStore?.Set("createdDateTime", value); }
        }
        /// <summary>Health details about the device hardware.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkHardwareHealth? HardwareHealth {
            get { return BackingStore?.Get<TeamworkHardwareHealth?>("hardwareHealth"); }
            set { BackingStore?.Set("hardwareHealth", value); }
        }
#nullable restore
#else
        public TeamworkHardwareHealth HardwareHealth {
            get { return BackingStore?.Get<TeamworkHardwareHealth>("hardwareHealth"); }
            set { BackingStore?.Set("hardwareHealth", value); }
        }
#endif
        /// <summary>Identity of the user who last modified the device health details.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public IdentitySet? LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet?>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#nullable restore
#else
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>("lastModifiedBy"); }
            set { BackingStore?.Set("lastModifiedBy", value); }
        }
#endif
        /// <summary>The UTC date and time when the device health detail was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The login status of Microsoft Teams, Skype for Business, and Exchange.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkLoginStatus? LoginStatus {
            get { return BackingStore?.Get<TeamworkLoginStatus?>("loginStatus"); }
            set { BackingStore?.Set("loginStatus", value); }
        }
#nullable restore
#else
        public TeamworkLoginStatus LoginStatus {
            get { return BackingStore?.Get<TeamworkLoginStatus>("loginStatus"); }
            set { BackingStore?.Set("loginStatus", value); }
        }
#endif
        /// <summary>Health details about all peripherals (for example, speaker and microphone) attached to a device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkPeripheralsHealth? PeripheralsHealth {
            get { return BackingStore?.Get<TeamworkPeripheralsHealth?>("peripheralsHealth"); }
            set { BackingStore?.Set("peripheralsHealth", value); }
        }
#nullable restore
#else
        public TeamworkPeripheralsHealth PeripheralsHealth {
            get { return BackingStore?.Get<TeamworkPeripheralsHealth>("peripheralsHealth"); }
            set { BackingStore?.Set("peripheralsHealth", value); }
        }
#endif
        /// <summary>Software updates available for the device.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public TeamworkSoftwareUpdateHealth? SoftwareUpdateHealth {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateHealth?>("softwareUpdateHealth"); }
            set { BackingStore?.Set("softwareUpdateHealth", value); }
        }
#nullable restore
#else
        public TeamworkSoftwareUpdateHealth SoftwareUpdateHealth {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateHealth>("softwareUpdateHealth"); }
            set { BackingStore?.Set("softwareUpdateHealth", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
