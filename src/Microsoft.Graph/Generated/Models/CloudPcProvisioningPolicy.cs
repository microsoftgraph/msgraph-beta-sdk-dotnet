using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcProvisioningPolicy : Entity, IParsable {
        /// <summary>The URL of the alternate resource that links to this provisioning policy. Read-only.</summary>
        public string AlternateResourceUrl {
            get { return BackingStore?.Get<string>("alternateResourceUrl"); }
            set { BackingStore?.Set("alternateResourceUrl", value); }
        }
        /// <summary>A defined collection of provisioning policy assignments. Represents the set of Microsoft 365 groups and security groups in Azure AD that have provisioning policy assigned. Returned only on $expand. See an example of getting the assignments relationship.</summary>
        public List<CloudPcProvisioningPolicyAssignment> Assignments {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicyAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>The display name of the Cloud PC group that the Cloud PCs reside in. Read-only.</summary>
        public string CloudPcGroupDisplayName {
            get { return BackingStore?.Get<string>("cloudPcGroupDisplayName"); }
            set { BackingStore?.Set("cloudPcGroupDisplayName", value); }
        }
        /// <summary>The provisioning policy description.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display name for the provisioning policy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Specifies how Cloud PCs will join Azure Active Directory.</summary>
        public CloudPcDomainJoinConfiguration DomainJoinConfiguration {
            get { return BackingStore?.Get<CloudPcDomainJoinConfiguration>("domainJoinConfiguration"); }
            set { BackingStore?.Set("domainJoinConfiguration", value); }
        }
        /// <summary>The number of hours to wait before reprovisioning/deprovisioning happens. Read-only.</summary>
        public int? GracePeriodInHours {
            get { return BackingStore?.Get<int?>("gracePeriodInHours"); }
            set { BackingStore?.Set("gracePeriodInHours", value); }
        }
        /// <summary>The display name for the OS image you’re provisioning.</summary>
        public string ImageDisplayName {
            get { return BackingStore?.Get<string>("imageDisplayName"); }
            set { BackingStore?.Set("imageDisplayName", value); }
        }
        /// <summary>The ID of the OS image you want to provision on Cloud PCs. The format for a gallery type image is: {publisher_offer_sku}. Supported values for each of the parameters are as follows:publisher: Microsoftwindowsdesktop. offer: windows-ent-cpc. sku: 21h1-ent-cpc-m365, 21h1-ent-cpc-os, 20h2-ent-cpc-m365, 20h2-ent-cpc-os, 20h1-ent-cpc-m365, 20h1-ent-cpc-os, 19h2-ent-cpc-m365 and 19h2-ent-cpc-os.</summary>
        public string ImageId {
            get { return BackingStore?.Get<string>("imageId"); }
            set { BackingStore?.Set("imageId", value); }
        }
        /// <summary>The imageType property</summary>
        public CloudPcProvisioningPolicyImageType? ImageType {
            get { return BackingStore?.Get<CloudPcProvisioningPolicyImageType?>("imageType"); }
            set { BackingStore?.Set("imageType", value); }
        }
        /// <summary>Indicates whether the local admin option is enabled. If the local admin option is enabled, the end user can be an admin of the Cloud PC device. Read-only.</summary>
        public bool? LocalAdminEnabled {
            get { return BackingStore?.Get<bool?>("localAdminEnabled"); }
            set { BackingStore?.Set("localAdminEnabled", value); }
        }
        /// <summary>The managedBy property</summary>
        public CloudPcManagementService? ManagedBy {
            get { return BackingStore?.Get<CloudPcManagementService?>("managedBy"); }
            set { BackingStore?.Set("managedBy", value); }
        }
        /// <summary>The specific settings for the Microsoft Managed Desktop, which enables customers to get a managed device experience for the Cloud PC. Before you can enable Microsoft Managed Desktop, an admin must configure it.</summary>
        public Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop MicrosoftManagedDesktop {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop>("microsoftManagedDesktop"); }
            set { BackingStore?.Set("microsoftManagedDesktop", value); }
        }
        /// <summary>The ID of the cloudPcOnPremisesConnection. To ensure that Cloud PCs have network connectivity and that they domain join, choose a connection with a virtual network that’s validated by the Cloud PC service.</summary>
        public string OnPremisesConnectionId {
            get { return BackingStore?.Get<string>("onPremisesConnectionId"); }
            set { BackingStore?.Set("onPremisesConnectionId", value); }
        }
        /// <summary>Specific Windows settings to configure while creating Cloud PCs for this provisioning policy.</summary>
        public CloudPcWindowsSettings WindowsSettings {
            get { return BackingStore?.Get<CloudPcWindowsSettings>("windowsSettings"); }
            set { BackingStore?.Set("windowsSettings", value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alternateResourceUrl", n => { AlternateResourceUrl = n.GetStringValue(); } },
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicyAssignment>(CloudPcProvisioningPolicyAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPcGroupDisplayName", n => { CloudPcGroupDisplayName = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"domainJoinConfiguration", n => { DomainJoinConfiguration = n.GetObjectValue<CloudPcDomainJoinConfiguration>(CloudPcDomainJoinConfiguration.CreateFromDiscriminatorValue); } },
                {"gracePeriodInHours", n => { GracePeriodInHours = n.GetIntValue(); } },
                {"imageDisplayName", n => { ImageDisplayName = n.GetStringValue(); } },
                {"imageId", n => { ImageId = n.GetStringValue(); } },
                {"imageType", n => { ImageType = n.GetEnumValue<CloudPcProvisioningPolicyImageType>(); } },
                {"localAdminEnabled", n => { LocalAdminEnabled = n.GetBoolValue(); } },
                {"managedBy", n => { ManagedBy = n.GetEnumValue<CloudPcManagementService>(); } },
                {"microsoftManagedDesktop", n => { MicrosoftManagedDesktop = n.GetObjectValue<Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop>(Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop.CreateFromDiscriminatorValue); } },
                {"onPremisesConnectionId", n => { OnPremisesConnectionId = n.GetStringValue(); } },
                {"windowsSettings", n => { WindowsSettings = n.GetObjectValue<CloudPcWindowsSettings>(CloudPcWindowsSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("alternateResourceUrl", AlternateResourceUrl);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicyAssignment>("assignments", Assignments);
            writer.WriteStringValue("cloudPcGroupDisplayName", CloudPcGroupDisplayName);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteObjectValue<CloudPcDomainJoinConfiguration>("domainJoinConfiguration", DomainJoinConfiguration);
            writer.WriteIntValue("gracePeriodInHours", GracePeriodInHours);
            writer.WriteStringValue("imageDisplayName", ImageDisplayName);
            writer.WriteStringValue("imageId", ImageId);
            writer.WriteEnumValue<CloudPcProvisioningPolicyImageType>("imageType", ImageType);
            writer.WriteBoolValue("localAdminEnabled", LocalAdminEnabled);
            writer.WriteEnumValue<CloudPcManagementService>("managedBy", ManagedBy);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MicrosoftManagedDesktop>("microsoftManagedDesktop", MicrosoftManagedDesktop);
            writer.WriteStringValue("onPremisesConnectionId", OnPremisesConnectionId);
            writer.WriteObjectValue<CloudPcWindowsSettings>("windowsSettings", WindowsSettings);
        }
    }
}
