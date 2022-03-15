using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the teamwork singleton.</summary>
    public class TeamworkSoftwareUpdateHealth : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The software update available for the admin agent.</summary>
        public TeamworkSoftwareUpdateStatus AdminAgentSoftwareUpdateStatus { get; set; }
        /// <summary>The software update available for the company portal.</summary>
        public TeamworkSoftwareUpdateStatus CompanyPortalSoftwareUpdateStatus { get; set; }
        /// <summary>The software update available for the firmware.</summary>
        public TeamworkSoftwareUpdateStatus FirmwareSoftwareUpdateStatus { get; set; }
        /// <summary>The software update available for the operating system.</summary>
        public TeamworkSoftwareUpdateStatus OperatingSystemSoftwareUpdateStatus { get; set; }
        /// <summary>The software update available for the partner agent.</summary>
        public TeamworkSoftwareUpdateStatus PartnerAgentSoftwareUpdateStatus { get; set; }
        /// <summary>The software update available for the Teams client.</summary>
        public TeamworkSoftwareUpdateStatus TeamsClientSoftwareUpdateStatus { get; set; }
        /// <summary>
        /// Instantiates a new teamworkSoftwareUpdateHealth and sets the default values.
        /// </summary>
        public TeamworkSoftwareUpdateHealth() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkSoftwareUpdateHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkSoftwareUpdateHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"adminAgentSoftwareUpdateStatus", (o,n) => { (o as TeamworkSoftwareUpdateHealth).AdminAgentSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"companyPortalSoftwareUpdateStatus", (o,n) => { (o as TeamworkSoftwareUpdateHealth).CompanyPortalSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"firmwareSoftwareUpdateStatus", (o,n) => { (o as TeamworkSoftwareUpdateHealth).FirmwareSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"operatingSystemSoftwareUpdateStatus", (o,n) => { (o as TeamworkSoftwareUpdateHealth).OperatingSystemSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"partnerAgentSoftwareUpdateStatus", (o,n) => { (o as TeamworkSoftwareUpdateHealth).PartnerAgentSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"teamsClientSoftwareUpdateStatus", (o,n) => { (o as TeamworkSoftwareUpdateHealth).TeamsClientSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkSoftwareUpdateStatus>("adminAgentSoftwareUpdateStatus", AdminAgentSoftwareUpdateStatus);
            writer.WriteObjectValue<TeamworkSoftwareUpdateStatus>("companyPortalSoftwareUpdateStatus", CompanyPortalSoftwareUpdateStatus);
            writer.WriteObjectValue<TeamworkSoftwareUpdateStatus>("firmwareSoftwareUpdateStatus", FirmwareSoftwareUpdateStatus);
            writer.WriteObjectValue<TeamworkSoftwareUpdateStatus>("operatingSystemSoftwareUpdateStatus", OperatingSystemSoftwareUpdateStatus);
            writer.WriteObjectValue<TeamworkSoftwareUpdateStatus>("partnerAgentSoftwareUpdateStatus", PartnerAgentSoftwareUpdateStatus);
            writer.WriteObjectValue<TeamworkSoftwareUpdateStatus>("teamsClientSoftwareUpdateStatus", TeamsClientSoftwareUpdateStatus);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
