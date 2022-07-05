using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class VirtualEndpoint : Entity, IParsable {
        /// <summary>Cloud PC audit event.</summary>
        public List<CloudPcAuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<CloudPcAuditEvent>>(nameof(AuditEvents)); }
            set { BackingStore?.Set(nameof(AuditEvents), value); }
        }
        /// <summary>Cloud managed virtual desktops.</summary>
        public List<CloudPC> CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>>(nameof(CloudPCs)); }
            set { BackingStore?.Set(nameof(CloudPCs), value); }
        }
        /// <summary>The image resource on Cloud PC.</summary>
        public List<CloudPcDeviceImage> DeviceImages {
            get { return BackingStore?.Get<List<CloudPcDeviceImage>>(nameof(DeviceImages)); }
            set { BackingStore?.Set(nameof(DeviceImages), value); }
        }
        /// <summary>The externalPartnerSettings property</summary>
        public List<CloudPcExternalPartnerSetting> ExternalPartnerSettings {
            get { return BackingStore?.Get<List<CloudPcExternalPartnerSetting>>(nameof(ExternalPartnerSettings)); }
            set { BackingStore?.Set(nameof(ExternalPartnerSettings), value); }
        }
        /// <summary>The gallery image resource on Cloud PC.</summary>
        public List<CloudPcGalleryImage> GalleryImages {
            get { return BackingStore?.Get<List<CloudPcGalleryImage>>(nameof(GalleryImages)); }
            set { BackingStore?.Set(nameof(GalleryImages), value); }
        }
        /// <summary>A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.</summary>
        public List<CloudPcOnPremisesConnection> OnPremisesConnections {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnection>>(nameof(OnPremisesConnections)); }
            set { BackingStore?.Set(nameof(OnPremisesConnections), value); }
        }
        /// <summary>The Cloud PC organization settings for a tenant.</summary>
        public CloudPcOrganizationSettings OrganizationSettings {
            get { return BackingStore?.Get<CloudPcOrganizationSettings>(nameof(OrganizationSettings)); }
            set { BackingStore?.Set(nameof(OrganizationSettings), value); }
        }
        /// <summary>Cloud PC provisioning policy.</summary>
        public List<CloudPcProvisioningPolicy> ProvisioningPolicies {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicy>>(nameof(ProvisioningPolicies)); }
            set { BackingStore?.Set(nameof(ProvisioningPolicies), value); }
        }
        /// <summary>Cloud PC service plans.</summary>
        public List<CloudPcServicePlan> ServicePlans {
            get { return BackingStore?.Get<List<CloudPcServicePlan>>(nameof(ServicePlans)); }
            set { BackingStore?.Set(nameof(ServicePlans), value); }
        }
        /// <summary>Cloud PC snapshots.</summary>
        public List<CloudPcSnapshot> Snapshots {
            get { return BackingStore?.Get<List<CloudPcSnapshot>>(nameof(Snapshots)); }
            set { BackingStore?.Set(nameof(Snapshots), value); }
        }
        /// <summary>Cloud PC supported regions.</summary>
        public List<CloudPcSupportedRegion> SupportedRegions {
            get { return BackingStore?.Get<List<CloudPcSupportedRegion>>(nameof(SupportedRegions)); }
            set { BackingStore?.Set(nameof(SupportedRegions), value); }
        }
        /// <summary>Cloud PC user settings.</summary>
        public List<CloudPcUserSetting> UserSettings {
            get { return BackingStore?.Get<List<CloudPcUserSetting>>(nameof(UserSettings)); }
            set { BackingStore?.Set(nameof(UserSettings), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new VirtualEndpoint CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEndpoint();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<CloudPcAuditEvent>(CloudPcAuditEvent.CreateFromDiscriminatorValue).ToList(); } },
                {"cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<CloudPC>(CloudPC.CreateFromDiscriminatorValue).ToList(); } },
                {"deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<CloudPcDeviceImage>(CloudPcDeviceImage.CreateFromDiscriminatorValue).ToList(); } },
                {"externalPartnerSettings", n => { ExternalPartnerSettings = n.GetCollectionOfObjectValues<CloudPcExternalPartnerSetting>(CloudPcExternalPartnerSetting.CreateFromDiscriminatorValue).ToList(); } },
                {"galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<CloudPcGalleryImage>(CloudPcGalleryImage.CreateFromDiscriminatorValue).ToList(); } },
                {"onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnection>(CloudPcOnPremisesConnection.CreateFromDiscriminatorValue).ToList(); } },
                {"organizationSettings", n => { OrganizationSettings = n.GetObjectValue<CloudPcOrganizationSettings>(CloudPcOrganizationSettings.CreateFromDiscriminatorValue); } },
                {"provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicy>(CloudPcProvisioningPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<CloudPcServicePlan>(CloudPcServicePlan.CreateFromDiscriminatorValue).ToList(); } },
                {"snapshots", n => { Snapshots = n.GetCollectionOfObjectValues<CloudPcSnapshot>(CloudPcSnapshot.CreateFromDiscriminatorValue).ToList(); } },
                {"supportedRegions", n => { SupportedRegions = n.GetCollectionOfObjectValues<CloudPcSupportedRegion>(CloudPcSupportedRegion.CreateFromDiscriminatorValue).ToList(); } },
                {"userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<CloudPcUserSetting>(CloudPcUserSetting.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CloudPcAuditEvent>("auditEvents", AuditEvents);
            writer.WriteCollectionOfObjectValues<CloudPC>("cloudPCs", CloudPCs);
            writer.WriteCollectionOfObjectValues<CloudPcDeviceImage>("deviceImages", DeviceImages);
            writer.WriteCollectionOfObjectValues<CloudPcExternalPartnerSetting>("externalPartnerSettings", ExternalPartnerSettings);
            writer.WriteCollectionOfObjectValues<CloudPcGalleryImage>("galleryImages", GalleryImages);
            writer.WriteCollectionOfObjectValues<CloudPcOnPremisesConnection>("onPremisesConnections", OnPremisesConnections);
            writer.WriteObjectValue<CloudPcOrganizationSettings>("organizationSettings", OrganizationSettings);
            writer.WriteCollectionOfObjectValues<CloudPcProvisioningPolicy>("provisioningPolicies", ProvisioningPolicies);
            writer.WriteCollectionOfObjectValues<CloudPcServicePlan>("servicePlans", ServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcSnapshot>("snapshots", Snapshots);
            writer.WriteCollectionOfObjectValues<CloudPcSupportedRegion>("supportedRegions", SupportedRegions);
            writer.WriteCollectionOfObjectValues<CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
