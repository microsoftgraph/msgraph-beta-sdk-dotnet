using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkDeviceSoftwareVersions : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The software version for the admin agent running on the device.</summary>
        public string AdminAgentSoftwareVersion { get; set; }
        /// <summary>The software version for the firmware running on the device.</summary>
        public string FirmwareSoftwareVersion { get; set; }
        /// <summary>The software version for the operating system on the device.</summary>
        public string OperatingSystemSoftwareVersion { get; set; }
        /// <summary>The software version for the partner agent running on the device.</summary>
        public string PartnerAgentSoftwareVersion { get; set; }
        /// <summary>The software version for the Teams client running on the device.</summary>
        public string TeamsClientSoftwareVersion { get; set; }
        /// <summary>
        /// Instantiates a new teamworkDeviceSoftwareVersions and sets the default values.
        /// </summary>
        public TeamworkDeviceSoftwareVersions() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkDeviceSoftwareVersions CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkDeviceSoftwareVersions();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"adminAgentSoftwareVersion", n => { AdminAgentSoftwareVersion = n.GetStringValue(); } },
                {"firmwareSoftwareVersion", n => { FirmwareSoftwareVersion = n.GetStringValue(); } },
                {"operatingSystemSoftwareVersion", n => { OperatingSystemSoftwareVersion = n.GetStringValue(); } },
                {"partnerAgentSoftwareVersion", n => { PartnerAgentSoftwareVersion = n.GetStringValue(); } },
                {"teamsClientSoftwareVersion", n => { TeamsClientSoftwareVersion = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("adminAgentSoftwareVersion", AdminAgentSoftwareVersion);
            writer.WriteStringValue("firmwareSoftwareVersion", FirmwareSoftwareVersion);
            writer.WriteStringValue("operatingSystemSoftwareVersion", OperatingSystemSoftwareVersion);
            writer.WriteStringValue("partnerAgentSoftwareVersion", PartnerAgentSoftwareVersion);
            writer.WriteStringValue("teamsClientSoftwareVersion", TeamsClientSoftwareVersion);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
