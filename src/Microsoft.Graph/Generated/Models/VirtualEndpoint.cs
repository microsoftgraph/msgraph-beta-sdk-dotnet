using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEndpoint : Entity, IParsable {
        /// <summary>Cloud PC audit event.</summary>
        public List<CloudPcAuditEvent> AuditEvents {
            get { return BackingStore?.Get<List<CloudPcAuditEvent>>("auditEvents"); }
            set { BackingStore?.Set("auditEvents", value); }
        }
        /// <summary>Cloud managed virtual desktops.</summary>
        public List<CloudPC> CloudPCs {
            get { return BackingStore?.Get<List<CloudPC>>("cloudPCs"); }
            set { BackingStore?.Set("cloudPCs", value); }
        }
        /// <summary>The image resource on Cloud PC.</summary>
        public List<CloudPcDeviceImage> DeviceImages {
            get { return BackingStore?.Get<List<CloudPcDeviceImage>>("deviceImages"); }
            set { BackingStore?.Set("deviceImages", value); }
        }
        /// <summary>The external partner settings on a Cloud PC.</summary>
        public List<CloudPcExternalPartnerSetting> ExternalPartnerSettings {
            get { return BackingStore?.Get<List<CloudPcExternalPartnerSetting>>("externalPartnerSettings"); }
            set { BackingStore?.Set("externalPartnerSettings", value); }
        }
        /// <summary>The gallery image resource on Cloud PC.</summary>
        public List<CloudPcGalleryImage> GalleryImages {
            get { return BackingStore?.Get<List<CloudPcGalleryImage>>("galleryImages"); }
            set { BackingStore?.Set("galleryImages", value); }
        }
        /// <summary>A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.</summary>
        public List<CloudPcOnPremisesConnection> OnPremisesConnections {
            get { return BackingStore?.Get<List<CloudPcOnPremisesConnection>>("onPremisesConnections"); }
            set { BackingStore?.Set("onPremisesConnections", value); }
        }
        /// <summary>The Cloud PC organization settings for a tenant.</summary>
        public CloudPcOrganizationSettings OrganizationSettings {
            get { return BackingStore?.Get<CloudPcOrganizationSettings>("organizationSettings"); }
            set { BackingStore?.Set("organizationSettings", value); }
        }
        /// <summary>Cloud PC provisioning policy.</summary>
        public List<CloudPcProvisioningPolicy> ProvisioningPolicies {
            get { return BackingStore?.Get<List<CloudPcProvisioningPolicy>>("provisioningPolicies"); }
            set { BackingStore?.Set("provisioningPolicies", value); }
        }
        /// <summary>The reports property</summary>
        public CloudPcReports Reports {
            get { return BackingStore?.Get<CloudPcReports>("reports"); }
            set { BackingStore?.Set("reports", value); }
        }
        /// <summary>Cloud PC service plans.</summary>
        public List<CloudPcServicePlan> ServicePlans {
            get { return BackingStore?.Get<List<CloudPcServicePlan>>("servicePlans"); }
            set { BackingStore?.Set("servicePlans", value); }
        }
        /// <summary>Cloud PC snapshots.</summary>
        public List<CloudPcSnapshot> Snapshots {
            get { return BackingStore?.Get<List<CloudPcSnapshot>>("snapshots"); }
            set { BackingStore?.Set("snapshots", value); }
        }
        /// <summary>Cloud PC supported regions.</summary>
        public List<CloudPcSupportedRegion> SupportedRegions {
            get { return BackingStore?.Get<List<CloudPcSupportedRegion>>("supportedRegions"); }
            set { BackingStore?.Set("supportedRegions", value); }
        }
        /// <summary>Cloud PC user settings.</summary>
        public List<CloudPcUserSetting> UserSettings {
            get { return BackingStore?.Get<List<CloudPcUserSetting>>("userSettings"); }
            set { BackingStore?.Set("userSettings", value); }
        }
        /// <summary>
        /// Instantiates a new VirtualEndpoint and sets the default values.
        /// </summary>
        public VirtualEndpoint() : base() {
            OdataType = "#microsoft.graph.virtualEndpoint";
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
                {"auditEvents", n => { AuditEvents = n.GetCollectionOfObjectValues<CloudPcAuditEvent>(CloudPcAuditEvent.CreateFromDiscriminatorValue)?.ToList(); } },
                {"cloudPCs", n => { CloudPCs = n.GetCollectionOfObjectValues<CloudPC>(CloudPC.CreateFromDiscriminatorValue)?.ToList(); } },
                {"deviceImages", n => { DeviceImages = n.GetCollectionOfObjectValues<CloudPcDeviceImage>(CloudPcDeviceImage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"externalPartnerSettings", n => { ExternalPartnerSettings = n.GetCollectionOfObjectValues<CloudPcExternalPartnerSetting>(CloudPcExternalPartnerSetting.CreateFromDiscriminatorValue)?.ToList(); } },
                {"galleryImages", n => { GalleryImages = n.GetCollectionOfObjectValues<CloudPcGalleryImage>(CloudPcGalleryImage.CreateFromDiscriminatorValue)?.ToList(); } },
                {"onPremisesConnections", n => { OnPremisesConnections = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnection>(CloudPcOnPremisesConnection.CreateFromDiscriminatorValue)?.ToList(); } },
                {"organizationSettings", n => { OrganizationSettings = n.GetObjectValue<CloudPcOrganizationSettings>(CloudPcOrganizationSettings.CreateFromDiscriminatorValue); } },
                {"provisioningPolicies", n => { ProvisioningPolicies = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicy>(CloudPcProvisioningPolicy.CreateFromDiscriminatorValue)?.ToList(); } },
                {"reports", n => { Reports = n.GetObjectValue<CloudPcReports>(CloudPcReports.CreateFromDiscriminatorValue); } },
                {"servicePlans", n => { ServicePlans = n.GetCollectionOfObjectValues<CloudPcServicePlan>(CloudPcServicePlan.CreateFromDiscriminatorValue)?.ToList(); } },
                {"snapshots", n => { Snapshots = n.GetCollectionOfObjectValues<CloudPcSnapshot>(CloudPcSnapshot.CreateFromDiscriminatorValue)?.ToList(); } },
                {"supportedRegions", n => { SupportedRegions = n.GetCollectionOfObjectValues<CloudPcSupportedRegion>(CloudPcSupportedRegion.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userSettings", n => { UserSettings = n.GetCollectionOfObjectValues<CloudPcUserSetting>(CloudPcUserSetting.CreateFromDiscriminatorValue)?.ToList(); } },
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
            writer.WriteObjectValue<CloudPcReports>("reports", Reports);
            writer.WriteCollectionOfObjectValues<CloudPcServicePlan>("servicePlans", ServicePlans);
            writer.WriteCollectionOfObjectValues<CloudPcSnapshot>("snapshots", Snapshots);
            writer.WriteCollectionOfObjectValues<CloudPcSupportedRegion>("supportedRegions", SupportedRegions);
            writer.WriteCollectionOfObjectValues<CloudPcUserSetting>("userSettings", UserSettings);
        }
    }
}
