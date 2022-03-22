using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CloudPcProvisioningPolicy : Entity, IParsable {
        /// <summary>A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Azure AD that have provisioning policy assigned. Returned only on $expand. See an example of getting the assignments relationship.</summary>
        public List<CloudPcProvisioningPolicyAssignment> Assignments { get; set; }
        /// <summary>The provisioning policy description.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the provisioning policy.</summary>
        public string DisplayName { get; set; }
        /// <summary>Specifies how Cloud PCs will join Azure Active Directory.</summary>
        public CloudPcDomainJoinConfiguration DomainJoinConfiguration { get; set; }
        /// <summary>The display name for the OS image you’re provisioning.</summary>
        public string ImageDisplayName { get; set; }
        /// <summary>The ID of the OS image you want to provision on Cloud PCs. The format for a gallery type image is: {publisher_offer_sku}. Supported values for each of the parameters are as follows:publisher: Microsoftwindowsdesktop. offer: windows-ent-cpc. sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365 and 19h2-ent-cpc-os.</summary>
        public string ImageId { get; set; }
        /// <summary>The type of OS image (custom or gallery) you want to provision on Cloud PCs. Possible values are: gallery, custom.</summary>
        public CloudPcProvisioningPolicyImageType? ImageType { get; set; }
        /// <summary>The specific settings for the Microsoft Managed Desktop, which enables customers to get a managed device experience for the Cloud PC. Before you can enable Microsoft Managed Desktop, an admin must configure it.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.MicrosoftManagedDesktop MicrosoftManagedDesktop { get; set; }
        /// <summary>The ID of the cloudPcOnPremisesConnection. To ensure that Cloud PCs have network connectivity and that they domain join, choose a connection with a virtual network that’s validated by the Cloud PC service.</summary>
        public string OnPremisesConnectionId { get; set; }
        /// <summary>Specific Windows settings to configure while creating Cloud PCs for this provisioning policy.</summary>
        public CloudPcWindowsSettings WindowsSettings { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcProvisioningPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcProvisioningPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as CloudPcProvisioningPolicy).Assignments = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicyAssignment>(CloudPcProvisioningPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"description", (o,n) => { (o as CloudPcProvisioningPolicy).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as CloudPcProvisioningPolicy).DisplayName = n.GetStringValue(); } },
                {"domainJoinConfiguration", (o,n) => { (o as CloudPcProvisioningPolicy).DomainJoinConfiguration = n.GetObjectValue<CloudPcDomainJoinConfiguration>(CloudPcDomainJoinConfiguration.CreateFromDiscriminatorValue); } },
                {"imageDisplayName", (o,n) => { (o as CloudPcProvisioningPolicy).ImageDisplayName = n.GetStringValue(); } },
                {"imageId", (o,n) => { (o as CloudPcProvisioningPolicy).ImageId = n.GetStringValue(); } },
                {"imageType", (o,n) => { (o as CloudPcProvisioningPolicy).ImageType = n.GetEnumValue<CloudPcProvisioningPolicyImageType>(); } },
                {"microsoftManagedDesktop", (o,n) => { (o as CloudPcProvisioningPolicy).MicrosoftManagedDesktop = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MicrosoftManagedDesktop>(MicrosoftGraphSdk.Models.Microsoft.Graph.MicrosoftManagedDesktop.CreateFromDiscriminatorValue); } },
                {"onPremisesConnectionId", (o,n) => { (o as CloudPcProvisioningPolicy).OnPremisesConnectionId = n.GetStringValue(); } },
                {"windowsSettings", (o,n) => { (o as CloudPcProvisioningPolicy).WindowsSettings = n.GetObjectValue<CloudPcWindowsSettings>(CloudPcWindowsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicyAssignment>("assignments", Assignments);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<CloudPcDomainJoinConfiguration>("domainJoinConfiguration", DomainJoinConfiguration);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteEnumValue<CloudPcProvisioningPolicyImageType>("imageType", ImageType);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.MicrosoftManagedDesktop>("microsoftManagedDesktop", MicrosoftManagedDesktop);
            writer.WriteStringValue("onPremisesConnectionId", OnPremisesConnectionId);
            writer.WriteObjectValue<CloudPcWindowsSettings>("windowsSettings", WindowsSettings);
        }
    }
}
