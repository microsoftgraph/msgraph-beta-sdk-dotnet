using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class CloudPcOverview : Entity, IParsable {
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshedDateTime"); }
            set { BackingStore?.Set("lastRefreshedDateTime", value); }
        }
        /// <summary>The number of cloud PC connections that have a status of failed. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusFailed {
            get { return BackingStore?.Get<int?>("numberOfCloudPcConnectionStatusFailed"); }
            set { BackingStore?.Set("numberOfCloudPcConnectionStatusFailed", value); }
        }
        /// <summary>The number of cloud PC connections that have a status of passed. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusPassed {
            get { return BackingStore?.Get<int?>("numberOfCloudPcConnectionStatusPassed"); }
            set { BackingStore?.Set("numberOfCloudPcConnectionStatusPassed", value); }
        }
        /// <summary>The number of cloud PC connections that have a status of pending. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusPending {
            get { return BackingStore?.Get<int?>("numberOfCloudPcConnectionStatusPending"); }
            set { BackingStore?.Set("numberOfCloudPcConnectionStatusPending", value); }
        }
        /// <summary>The number of cloud PC connections that have a status of running. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusRunning {
            get { return BackingStore?.Get<int?>("numberOfCloudPcConnectionStatusRunning"); }
            set { BackingStore?.Set("numberOfCloudPcConnectionStatusRunning", value); }
        }
        /// <summary>The number of cloud PC connections that have a status of unknownFutureValue. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusUnkownFutureValue {
            get { return BackingStore?.Get<int?>("numberOfCloudPcConnectionStatusUnkownFutureValue"); }
            set { BackingStore?.Set("numberOfCloudPcConnectionStatusUnkownFutureValue", value); }
        }
        /// <summary>The number of cloud PCs that have a status of deprovisioning. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusDeprovisioning {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusDeprovisioning"); }
            set { BackingStore?.Set("numberOfCloudPcStatusDeprovisioning", value); }
        }
        /// <summary>The number of cloud PCs that have a status of failed. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusFailed {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusFailed"); }
            set { BackingStore?.Set("numberOfCloudPcStatusFailed", value); }
        }
        /// <summary>The number of cloud PCs that have a status of inGracePeriod. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusInGracePeriod {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusInGracePeriod"); }
            set { BackingStore?.Set("numberOfCloudPcStatusInGracePeriod", value); }
        }
        /// <summary>The number of cloud PCs that have a status of notProvisioned. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusNotProvisioned {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusNotProvisioned"); }
            set { BackingStore?.Set("numberOfCloudPcStatusNotProvisioned", value); }
        }
        /// <summary>The number of cloud PCs that have a status of provisioned. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusProvisioned {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusProvisioned"); }
            set { BackingStore?.Set("numberOfCloudPcStatusProvisioned", value); }
        }
        /// <summary>The number of cloud PCs that have a status of provisioning. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusProvisioning {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusProvisioning"); }
            set { BackingStore?.Set("numberOfCloudPcStatusProvisioning", value); }
        }
        /// <summary>The number of cloud PCs that have a status of unknown. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusUnknown {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusUnknown"); }
            set { BackingStore?.Set("numberOfCloudPcStatusUnknown", value); }
        }
        /// <summary>The number of cloud PCs that have a status of upgrading. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusUpgrading {
            get { return BackingStore?.Get<int?>("numberOfCloudPcStatusUpgrading"); }
            set { BackingStore?.Set("numberOfCloudPcStatusUpgrading", value); }
        }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName {
            get { return BackingStore?.Get<string>("tenantDisplayName"); }
            set { BackingStore?.Set("tenantDisplayName", value); }
        }
        /// <summary>The tenantId property</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>The total number of cloud PC devices that have the Business SKU. Optional. Read-only.</summary>
        public int? TotalBusinessLicenses {
            get { return BackingStore?.Get<int?>("totalBusinessLicenses"); }
            set { BackingStore?.Set("totalBusinessLicenses", value); }
        }
        /// <summary>The total number of cloud PC connection statuses for the given managed tenant. Optional. Read-only.</summary>
        public int? TotalCloudPcConnectionStatus {
            get { return BackingStore?.Get<int?>("totalCloudPcConnectionStatus"); }
            set { BackingStore?.Set("totalCloudPcConnectionStatus", value); }
        }
        /// <summary>The total number of cloud PC statues for the given managed tenant. Optional. Read-only.</summary>
        public int? TotalCloudPcStatus {
            get { return BackingStore?.Get<int?>("totalCloudPcStatus"); }
            set { BackingStore?.Set("totalCloudPcStatus", value); }
        }
        /// <summary>The total number of cloud PC devices that have the Enterprise SKU. Optional. Read-only.</summary>
        public int? TotalEnterpriseLicenses {
            get { return BackingStore?.Get<int?>("totalEnterpriseLicenses"); }
            set { BackingStore?.Set("totalEnterpriseLicenses", value); }
        }
        /// <summary>
        /// Instantiates a new cloudPcOverview and sets the default values.
        /// </summary>
        public CloudPcOverview() : base() {
            OdataType = "#microsoft.graph.managedTenants.cloudPcOverview";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastRefreshedDateTime", n => { LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"numberOfCloudPcConnectionStatusFailed", n => { NumberOfCloudPcConnectionStatusFailed = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusPassed", n => { NumberOfCloudPcConnectionStatusPassed = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusPending", n => { NumberOfCloudPcConnectionStatusPending = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusRunning", n => { NumberOfCloudPcConnectionStatusRunning = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusUnkownFutureValue", n => { NumberOfCloudPcConnectionStatusUnkownFutureValue = n.GetIntValue(); } },
                {"numberOfCloudPcStatusDeprovisioning", n => { NumberOfCloudPcStatusDeprovisioning = n.GetIntValue(); } },
                {"numberOfCloudPcStatusFailed", n => { NumberOfCloudPcStatusFailed = n.GetIntValue(); } },
                {"numberOfCloudPcStatusInGracePeriod", n => { NumberOfCloudPcStatusInGracePeriod = n.GetIntValue(); } },
                {"numberOfCloudPcStatusNotProvisioned", n => { NumberOfCloudPcStatusNotProvisioned = n.GetIntValue(); } },
                {"numberOfCloudPcStatusProvisioned", n => { NumberOfCloudPcStatusProvisioned = n.GetIntValue(); } },
                {"numberOfCloudPcStatusProvisioning", n => { NumberOfCloudPcStatusProvisioning = n.GetIntValue(); } },
                {"numberOfCloudPcStatusUnknown", n => { NumberOfCloudPcStatusUnknown = n.GetIntValue(); } },
                {"numberOfCloudPcStatusUpgrading", n => { NumberOfCloudPcStatusUpgrading = n.GetIntValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"totalBusinessLicenses", n => { TotalBusinessLicenses = n.GetIntValue(); } },
                {"totalCloudPcConnectionStatus", n => { TotalCloudPcConnectionStatus = n.GetIntValue(); } },
                {"totalCloudPcStatus", n => { TotalCloudPcStatus = n.GetIntValue(); } },
                {"totalEnterpriseLicenses", n => { TotalEnterpriseLicenses = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteIntValue("numberOfCloudPcConnectionStatusFailed", NumberOfCloudPcConnectionStatusFailed);
            writer.WriteIntValue("numberOfCloudPcConnectionStatusPassed", NumberOfCloudPcConnectionStatusPassed);
            writer.WriteIntValue("numberOfCloudPcConnectionStatusPending", NumberOfCloudPcConnectionStatusPending);
            writer.WriteIntValue("numberOfCloudPcConnectionStatusRunning", NumberOfCloudPcConnectionStatusRunning);
            writer.WriteIntValue("numberOfCloudPcConnectionStatusUnkownFutureValue", NumberOfCloudPcConnectionStatusUnkownFutureValue);
            writer.WriteIntValue("numberOfCloudPcStatusDeprovisioning", NumberOfCloudPcStatusDeprovisioning);
            writer.WriteIntValue("numberOfCloudPcStatusFailed", NumberOfCloudPcStatusFailed);
            writer.WriteIntValue("numberOfCloudPcStatusInGracePeriod", NumberOfCloudPcStatusInGracePeriod);
            writer.WriteIntValue("numberOfCloudPcStatusNotProvisioned", NumberOfCloudPcStatusNotProvisioned);
            writer.WriteIntValue("numberOfCloudPcStatusProvisioned", NumberOfCloudPcStatusProvisioned);
            writer.WriteIntValue("numberOfCloudPcStatusProvisioning", NumberOfCloudPcStatusProvisioning);
            writer.WriteIntValue("numberOfCloudPcStatusUnknown", NumberOfCloudPcStatusUnknown);
            writer.WriteIntValue("numberOfCloudPcStatusUpgrading", NumberOfCloudPcStatusUpgrading);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("totalBusinessLicenses", TotalBusinessLicenses);
            writer.WriteIntValue("totalCloudPcConnectionStatus", TotalCloudPcConnectionStatus);
            writer.WriteIntValue("totalCloudPcStatus", TotalCloudPcStatus);
            writer.WriteIntValue("totalEnterpriseLicenses", TotalEnterpriseLicenses);
        }
    }
}
