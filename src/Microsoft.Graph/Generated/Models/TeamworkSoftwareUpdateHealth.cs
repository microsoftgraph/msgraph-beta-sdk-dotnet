using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkSoftwareUpdateHealth : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The software update available for the admin agent.</summary>
        public TeamworkSoftwareUpdateStatus AdminAgentSoftwareUpdateStatus {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateStatus>("adminAgentSoftwareUpdateStatus"); }
            set { BackingStore?.Set("adminAgentSoftwareUpdateStatus", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The software update available for the company portal.</summary>
        public TeamworkSoftwareUpdateStatus CompanyPortalSoftwareUpdateStatus {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateStatus>("companyPortalSoftwareUpdateStatus"); }
            set { BackingStore?.Set("companyPortalSoftwareUpdateStatus", value); }
        }
        /// <summary>The software update available for the firmware.</summary>
        public TeamworkSoftwareUpdateStatus FirmwareSoftwareUpdateStatus {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateStatus>("firmwareSoftwareUpdateStatus"); }
            set { BackingStore?.Set("firmwareSoftwareUpdateStatus", value); }
        }
        /// <summary>The software update available for the operating system.</summary>
        public TeamworkSoftwareUpdateStatus OperatingSystemSoftwareUpdateStatus {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateStatus>("operatingSystemSoftwareUpdateStatus"); }
            set { BackingStore?.Set("operatingSystemSoftwareUpdateStatus", value); }
        }
        /// <summary>The software update available for the partner agent.</summary>
        public TeamworkSoftwareUpdateStatus PartnerAgentSoftwareUpdateStatus {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateStatus>("partnerAgentSoftwareUpdateStatus"); }
            set { BackingStore?.Set("partnerAgentSoftwareUpdateStatus", value); }
        }
        /// <summary>The software update available for the Teams client.</summary>
        public TeamworkSoftwareUpdateStatus TeamsClientSoftwareUpdateStatus {
            get { return BackingStore?.Get<TeamworkSoftwareUpdateStatus>("teamsClientSoftwareUpdateStatus"); }
            set { BackingStore?.Set("teamsClientSoftwareUpdateStatus", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkSoftwareUpdateHealth and sets the default values.
        /// </summary>
        public TeamworkSoftwareUpdateHealth() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"adminAgentSoftwareUpdateStatus", n => { AdminAgentSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"companyPortalSoftwareUpdateStatus", n => { CompanyPortalSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"firmwareSoftwareUpdateStatus", n => { FirmwareSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"operatingSystemSoftwareUpdateStatus", n => { OperatingSystemSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"partnerAgentSoftwareUpdateStatus", n => { PartnerAgentSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
                {"teamsClientSoftwareUpdateStatus", n => { TeamsClientSoftwareUpdateStatus = n.GetObjectValue<TeamworkSoftwareUpdateStatus>(TeamworkSoftwareUpdateStatus.CreateFromDiscriminatorValue); } },
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
