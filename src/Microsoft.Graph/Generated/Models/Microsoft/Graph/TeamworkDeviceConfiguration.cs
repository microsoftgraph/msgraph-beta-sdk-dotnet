using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TeamworkDeviceConfiguration : Entity, IParsable {
        /// <summary>The camera configuration. Applicable only for Microsoft Teams Rooms-enabled devices.</summary>
        public TeamworkCameraConfiguration CameraConfiguration { get; set; }
        /// <summary>Identity of the user who created the device configuration document.</summary>
        public IdentitySet CreatedBy { get; set; }
        /// <summary>The UTC date and time when the device configuration document was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display configuration.</summary>
        public TeamworkDisplayConfiguration DisplayConfiguration { get; set; }
        /// <summary>The hardware configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkHardwareConfiguration HardwareConfiguration { get; set; }
        /// <summary>Identity of the user who last modified the device configuration.</summary>
        public IdentitySet LastModifiedBy { get; set; }
        /// <summary>The UTC date and time when the device configuration was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The microphone configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkMicrophoneConfiguration MicrophoneConfiguration { get; set; }
        /// <summary>Information related to software versions for the device, such as firmware, operating system, Teams client, and admin agent.</summary>
        public TeamworkDeviceSoftwareVersions SoftwareVersions { get; set; }
        /// <summary>The speaker configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkSpeakerConfiguration SpeakerConfiguration { get; set; }
        /// <summary>The system configuration. Not applicable for Teams Rooms-enabled devices.</summary>
        public TeamworkSystemConfiguration SystemConfiguration { get; set; }
        /// <summary>The Teams client configuration. Applicable only for Teams Rooms-enabled devices.</summary>
        public TeamworkTeamsClientConfiguration TeamsClientConfiguration { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"cameraConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).CameraConfiguration = n.GetObjectValue<TeamworkCameraConfiguration>(); } },
                {"createdBy", (o,n) => { (o as TeamworkDeviceConfiguration).CreatedBy = n.GetObjectValue<IdentitySet>(); } },
                {"createdDateTime", (o,n) => { (o as TeamworkDeviceConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).DisplayConfiguration = n.GetObjectValue<TeamworkDisplayConfiguration>(); } },
                {"hardwareConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).HardwareConfiguration = n.GetObjectValue<TeamworkHardwareConfiguration>(); } },
                {"lastModifiedBy", (o,n) => { (o as TeamworkDeviceConfiguration).LastModifiedBy = n.GetObjectValue<IdentitySet>(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TeamworkDeviceConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"microphoneConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).MicrophoneConfiguration = n.GetObjectValue<TeamworkMicrophoneConfiguration>(); } },
                {"softwareVersions", (o,n) => { (o as TeamworkDeviceConfiguration).SoftwareVersions = n.GetObjectValue<TeamworkDeviceSoftwareVersions>(); } },
                {"speakerConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).SpeakerConfiguration = n.GetObjectValue<TeamworkSpeakerConfiguration>(); } },
                {"systemConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).SystemConfiguration = n.GetObjectValue<TeamworkSystemConfiguration>(); } },
                {"teamsClientConfiguration", (o,n) => { (o as TeamworkDeviceConfiguration).TeamsClientConfiguration = n.GetObjectValue<TeamworkTeamsClientConfiguration>(); } },
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
