using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class VirtualEndpoint : Entity, IParsable {
        /// <summary>Cloud PC audit event.</summary>
        public List<CloudPcAuditEvent> AuditEvents { get; set; }
        /// <summary>Cloud managed virtual desktops.</summary>
        public List<CloudPC> CloudPCs { get; set; }
        /// <summary>The image resource on Cloud PC.</summary>
        public List<CloudPcDeviceImage> DeviceImages { get; set; }
        /// <summary>The gallery image resource on Cloud PC.</summary>
        public List<CloudPcGalleryImage> GalleryImages { get; set; }
        /// <summary>A defined collection of Azure resource information that can be used to establish on-premises network connectivity for Cloud PCs.</summary>
        public List<CloudPcOnPremisesConnection> OnPremisesConnections { get; set; }
        /// <summary>The Cloud PC organization settings for a tenant.</summary>
        public CloudPcOrganizationSettings OrganizationSettings { get; set; }
        /// <summary>Cloud PC provisioning policy.</summary>
        public List<CloudPcProvisioningPolicy> ProvisioningPolicies { get; set; }
        /// <summary>Cloud PC service plans.</summary>
        public List<CloudPcServicePlan> ServicePlans { get; set; }
        /// <summary>Cloud PC snapshots.</summary>
        public List<CloudPcSnapshot> Snapshots { get; set; }
        /// <summary>Cloud PC supported regions.</summary>
        public List<CloudPcSupportedRegion> SupportedRegions { get; set; }
        /// <summary>Cloud PC user settings.</summary>
        public List<CloudPcUserSetting> UserSettings { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"auditEvents", (o,n) => { (o as VirtualEndpoint).AuditEvents = n.GetCollectionOfObjectValues<CloudPcAuditEvent>().ToList(); } },
                {"cloudPCs", (o,n) => { (o as VirtualEndpoint).CloudPCs = n.GetCollectionOfObjectValues<CloudPC>().ToList(); } },
                {"deviceImages", (o,n) => { (o as VirtualEndpoint).DeviceImages = n.GetCollectionOfObjectValues<CloudPcDeviceImage>().ToList(); } },
                {"galleryImages", (o,n) => { (o as VirtualEndpoint).GalleryImages = n.GetCollectionOfObjectValues<CloudPcGalleryImage>().ToList(); } },
                {"onPremisesConnections", (o,n) => { (o as VirtualEndpoint).OnPremisesConnections = n.GetCollectionOfObjectValues<CloudPcOnPremisesConnection>().ToList(); } },
                {"organizationSettings", (o,n) => { (o as VirtualEndpoint).OrganizationSettings = n.GetObjectValue<CloudPcOrganizationSettings>(); } },
                {"provisioningPolicies", (o,n) => { (o as VirtualEndpoint).ProvisioningPolicies = n.GetCollectionOfObjectValues<CloudPcProvisioningPolicy>().ToList(); } },
                {"servicePlans", (o,n) => { (o as VirtualEndpoint).ServicePlans = n.GetCollectionOfObjectValues<CloudPcServicePlan>().ToList(); } },
                {"snapshots", (o,n) => { (o as VirtualEndpoint).Snapshots = n.GetCollectionOfObjectValues<CloudPcSnapshot>().ToList(); } },
                {"supportedRegions", (o,n) => { (o as VirtualEndpoint).SupportedRegions = n.GetCollectionOfObjectValues<CloudPcSupportedRegion>().ToList(); } },
                {"userSettings", (o,n) => { (o as VirtualEndpoint).UserSettings = n.GetCollectionOfObjectValues<CloudPcUserSetting>().ToList(); } },
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
