using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class TeamworkDeviceConfiguration : Entity, IParsable {
        /// <summary>The camera configuration. Applicable only for Microsoft Teams Rooms-enabled devices.</summary>
        public TeamworkCameraConfiguration CameraConfiguration {
            get { return BackingStore?.Get<TeamworkCameraConfiguration>(nameof(CameraConfiguration)); }
            set { BackingStore?.Set(nameof(CameraConfiguration), value); }
        }
        /// <summary>Identity of the user who created the device configuration document.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>The UTC date and time when the device configuration document was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The display configuration.</summary>
        public TeamworkDisplayConfiguration DisplayConfiguration {
            get { return BackingStore?.Get<TeamworkDisplayConfiguration>(nameof(DisplayConfiguration)); }
            set { BackingStore?.Set(nameof(DisplayConfiguration), value); }
        }
        /// <summary>The hardware configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkHardwareConfiguration HardwareConfiguration {
            get { return BackingStore?.Get<TeamworkHardwareConfiguration>(nameof(HardwareConfiguration)); }
            set { BackingStore?.Set(nameof(HardwareConfiguration), value); }
        }
        /// <summary>Identity of the user who last modified the device configuration.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>The UTC date and time when the device configuration was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>The microphone configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkMicrophoneConfiguration MicrophoneConfiguration {
            get { return BackingStore?.Get<TeamworkMicrophoneConfiguration>(nameof(MicrophoneConfiguration)); }
            set { BackingStore?.Set(nameof(MicrophoneConfiguration), value); }
        }
        /// <summary>Information related to software versions for the device, such as firmware, operating system, Teams client, and admin agent.</summary>
        public TeamworkDeviceSoftwareVersions SoftwareVersions {
            get { return BackingStore?.Get<TeamworkDeviceSoftwareVersions>(nameof(SoftwareVersions)); }
            set { BackingStore?.Set(nameof(SoftwareVersions), value); }
        }
        /// <summary>The speaker configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkSpeakerConfiguration SpeakerConfiguration {
            get { return BackingStore?.Get<TeamworkSpeakerConfiguration>(nameof(SpeakerConfiguration)); }
            set { BackingStore?.Set(nameof(SpeakerConfiguration), value); }
        }
        /// <summary>The system configuration. Not applicable for Teams Rooms-enabled devices.</summary>
        public TeamworkSystemConfiguration SystemConfiguration {
            get { return BackingStore?.Get<TeamworkSystemConfiguration>(nameof(SystemConfiguration)); }
            set { BackingStore?.Set(nameof(SystemConfiguration), value); }
        }
        /// <summary>The Teams client configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkTeamsClientConfiguration TeamsClientConfiguration {
            get { return BackingStore?.Get<TeamworkTeamsClientConfiguration>(nameof(TeamsClientConfiguration)); }
            set { BackingStore?.Set(nameof(TeamsClientConfiguration), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TeamworkDeviceConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDeviceConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"cameraConfiguration", n => { CameraConfiguration = n.GetObjectValue<TeamworkCameraConfiguration>(TeamworkCameraConfiguration.CreateFromDiscriminatorValue); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayConfiguration", n => { DisplayConfiguration = n.GetObjectValue<TeamworkDisplayConfiguration>(TeamworkDisplayConfiguration.CreateFromDiscriminatorValue); } },
                {"hardwareConfiguration", n => { HardwareConfiguration = n.GetObjectValue<TeamworkHardwareConfiguration>(TeamworkHardwareConfiguration.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"microphoneConfiguration", n => { MicrophoneConfiguration = n.GetObjectValue<TeamworkMicrophoneConfiguration>(TeamworkMicrophoneConfiguration.CreateFromDiscriminatorValue); } },
                {"softwareVersions", n => { SoftwareVersions = n.GetObjectValue<TeamworkDeviceSoftwareVersions>(TeamworkDeviceSoftwareVersions.CreateFromDiscriminatorValue); } },
                {"speakerConfiguration", n => { SpeakerConfiguration = n.GetObjectValue<TeamworkSpeakerConfiguration>(TeamworkSpeakerConfiguration.CreateFromDiscriminatorValue); } },
                {"systemConfiguration", n => { SystemConfiguration = n.GetObjectValue<TeamworkSystemConfiguration>(TeamworkSystemConfiguration.CreateFromDiscriminatorValue); } },
                {"teamsClientConfiguration", n => { TeamsClientConfiguration = n.GetObjectValue<TeamworkTeamsClientConfiguration>(TeamworkTeamsClientConfiguration.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkCameraConfiguration>("cameraConfiguration", CameraConfiguration);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<TeamworkDisplayConfiguration>("displayConfiguration", DisplayConfiguration);
            writer.WriteObjectValue<TeamworkHardwareConfiguration>("hardwareConfiguration", HardwareConfiguration);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<TeamworkMicrophoneConfiguration>("microphoneConfiguration", MicrophoneConfiguration);
            writer.WriteObjectValue<TeamworkDeviceSoftwareVersions>("softwareVersions", SoftwareVersions);
            writer.WriteObjectValue<TeamworkSpeakerConfiguration>("speakerConfiguration", SpeakerConfiguration);
            writer.WriteObjectValue<TeamworkSystemConfiguration>("systemConfiguration", SystemConfiguration);
            writer.WriteObjectValue<TeamworkTeamsClientConfiguration>("teamsClientConfiguration", TeamsClientConfiguration);
        }
    }
}
