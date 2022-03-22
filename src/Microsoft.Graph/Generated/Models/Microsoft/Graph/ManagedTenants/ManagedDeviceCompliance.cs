using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class ManagedDeviceCompliance : Entity, IParsable {
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager. Optional. Read-only.</summary>
        public string ComplianceStatus { get; set; }
        /// <summary>Platform of the device. This property is read-only. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.  Optional. Read-only.</summary>
        public string DeviceType { get; set; }
        /// <summary>The date and time when the grace period will expire. Optional. Read-only.</summary>
        public DateTimeOffset? InGracePeriodUntilDateTime { get; set; }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The date and time that the device last completed a successful sync with Microsoft Endpoint Manager. Optional. Read-only.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>The identifier for the managed device in Microsoft Endpoint Manager. Optional. Read-only.</summary>
        public string ManagedDeviceId { get; set; }
        /// <summary>The display name for the managed device. Optional. Read-only.</summary>
        public string ManagedDeviceName { get; set; }
        /// <summary>The manufacture for the device. Optional. Read-only.</summary>
        public string Manufacturer { get; set; }
        /// <summary>The model for the device. Optional. Read-only.</summary>
        public string Model { get; set; }
        /// <summary>The description of the operating system for the managed device. Optional. Read-only.</summary>
        public string OsDescription { get; set; }
        /// <summary>The version of the operating system for the managed device. Optional. Read-only.</summary>
        public string OsVersion { get; set; }
        /// <summary>The type of owner for the managed device. Optional. Read-only.</summary>
        public string OwnerType { get; set; }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceCompliance CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceCompliance();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"complianceStatus", (o,n) => { (o as ManagedDeviceCompliance).ComplianceStatus = n.GetStringValue(); } },
                {"deviceType", (o,n) => { (o as ManagedDeviceCompliance).DeviceType = n.GetStringValue(); } },
                {"inGracePeriodUntilDateTime", (o,n) => { (o as ManagedDeviceCompliance).InGracePeriodUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRefreshedDateTime", (o,n) => { (o as ManagedDeviceCompliance).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as ManagedDeviceCompliance).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", (o,n) => { (o as ManagedDeviceCompliance).ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", (o,n) => { (o as ManagedDeviceCompliance).ManagedDeviceName = n.GetStringValue(); } },
                {"manufacturer", (o,n) => { (o as ManagedDeviceCompliance).Manufacturer = n.GetStringValue(); } },
                {"model", (o,n) => { (o as ManagedDeviceCompliance).Model = n.GetStringValue(); } },
                {"osDescription", (o,n) => { (o as ManagedDeviceCompliance).OsDescription = n.GetStringValue(); } },
                {"osVersion", (o,n) => { (o as ManagedDeviceCompliance).OsVersion = n.GetStringValue(); } },
                {"ownerType", (o,n) => { (o as ManagedDeviceCompliance).OwnerType = n.GetStringValue(); } },
                {"tenantDisplayName", (o,n) => { (o as ManagedDeviceCompliance).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as ManagedDeviceCompliance).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("complianceStatus", ComplianceStatus);
            writer.WriteStringValue("deviceType", DeviceType);
            writer.WriteDateTimeOffsetValue("inGracePeriodUntilDateTime", InGracePeriodUntilDateTime);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteStringValue("managedDeviceId", ManagedDeviceId);
            writer.WriteStringValue("managedDeviceName", ManagedDeviceName);
            writer.WriteStringValue("manufacturer", Manufacturer);
            writer.WriteStringValue("model", Model);
            writer.WriteStringValue("osDescription", OsDescription);
            writer.WriteStringValue("osVersion", OsVersion);
            writer.WriteStringValue("ownerType", OwnerType);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
