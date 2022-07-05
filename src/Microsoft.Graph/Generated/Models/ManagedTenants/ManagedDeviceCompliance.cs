using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class ManagedDeviceCompliance : Entity, IParsable {
        /// <summary>Compliance state of the device. This property is read-only. Possible values are: unknown, compliant, noncompliant, conflict, error, inGracePeriod, configManager. Optional. Read-only.</summary>
        public string ComplianceStatus {
            get { return BackingStore?.Get<string>(nameof(ComplianceStatus)); }
            set { BackingStore?.Set(nameof(ComplianceStatus), value); }
        }
        /// <summary>Platform of the device. This property is read-only. Possible values are: desktop, windowsRT, winMO6, nokia, windowsPhone, mac, winCE, winEmbedded, iPhone, iPad, iPod, android, iSocConsumer, unix, macMDM, holoLens, surfaceHub, androidForWork, androidEnterprise, windows10x, androidnGMS, chromeOS, linux, blackberry, palm, unknown, cloudPC.  Optional. Read-only.</summary>
        public string DeviceType {
            get { return BackingStore?.Get<string>(nameof(DeviceType)); }
            set { BackingStore?.Set(nameof(DeviceType), value); }
        }
        /// <summary>The date and time when the grace period will expire. Optional. Read-only.</summary>
        public DateTimeOffset? InGracePeriodUntilDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(InGracePeriodUntilDateTime)); }
            set { BackingStore?.Set(nameof(InGracePeriodUntilDateTime), value); }
        }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastRefreshedDateTime)); }
            set { BackingStore?.Set(nameof(LastRefreshedDateTime), value); }
        }
        /// <summary>The date and time that the device last completed a successful sync with Microsoft Endpoint Manager. Optional. Read-only.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastSyncDateTime)); }
            set { BackingStore?.Set(nameof(LastSyncDateTime), value); }
        }
        /// <summary>The identifier for the managed device in Microsoft Endpoint Manager. Optional. Read-only.</summary>
        public string ManagedDeviceId {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceId)); }
            set { BackingStore?.Set(nameof(ManagedDeviceId), value); }
        }
        /// <summary>The display name for the managed device. Optional. Read-only.</summary>
        public string ManagedDeviceName {
            get { return BackingStore?.Get<string>(nameof(ManagedDeviceName)); }
            set { BackingStore?.Set(nameof(ManagedDeviceName), value); }
        }
        /// <summary>The manufacture for the device. Optional. Read-only.</summary>
        public string Manufacturer {
            get { return BackingStore?.Get<string>(nameof(Manufacturer)); }
            set { BackingStore?.Set(nameof(Manufacturer), value); }
        }
        /// <summary>The model for the device. Optional. Read-only.</summary>
        public string Model {
            get { return BackingStore?.Get<string>(nameof(Model)); }
            set { BackingStore?.Set(nameof(Model), value); }
        }
        /// <summary>The description of the operating system for the managed device. Optional. Read-only.</summary>
        public string OsDescription {
            get { return BackingStore?.Get<string>(nameof(OsDescription)); }
            set { BackingStore?.Set(nameof(OsDescription), value); }
        }
        /// <summary>The version of the operating system for the managed device. Optional. Read-only.</summary>
        public string OsVersion {
            get { return BackingStore?.Get<string>(nameof(OsVersion)); }
            set { BackingStore?.Set(nameof(OsVersion), value); }
        }
        /// <summary>The type of owner for the managed device. Optional. Read-only.</summary>
        public string OwnerType {
            get { return BackingStore?.Get<string>(nameof(OwnerType)); }
            set { BackingStore?.Set(nameof(OwnerType), value); }
        }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>(nameof(TenantDisplayName)); }
            set { BackingStore?.Set(nameof(TenantDisplayName), value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"complianceStatus", n => { ComplianceStatus = n.GetStringValue(); } },
                {"deviceType", n => { DeviceType = n.GetStringValue(); } },
                {"inGracePeriodUntilDateTime", n => { InGracePeriodUntilDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"managedDeviceId", n => { ManagedDeviceId = n.GetStringValue(); } },
                {"managedDeviceName", n => { ManagedDeviceName = n.GetStringValue(); } },
                {"manufacturer", n => { Manufacturer = n.GetStringValue(); } },
                {"model", n => { Model = n.GetStringValue(); } },
                {"osDescription", n => { OsDescription = n.GetStringValue(); } },
                {"osVersion", n => { OsVersion = n.GetStringValue(); } },
                {"ownerType", n => { OwnerType = n.GetStringValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
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
