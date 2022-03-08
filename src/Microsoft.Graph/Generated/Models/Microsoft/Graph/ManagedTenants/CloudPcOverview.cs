using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class CloudPcOverview : Entity, IParsable {
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The number of cloud PC connections that have a status of failed. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusFailed { get; set; }
        /// <summary>The number of cloud PC connections that have a status of passed. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusPassed { get; set; }
        /// <summary>The number of cloud PC connections that have a status of pending. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusPending { get; set; }
        /// <summary>The number of cloud PC connections that have a status of running. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusRunning { get; set; }
        /// <summary>The number of cloud PC connections that have a status of unknownFutureValue. Optional. Read-only.</summary>
        public int? NumberOfCloudPcConnectionStatusUnkownFutureValue { get; set; }
        /// <summary>The number of cloud PCs that have a status of deprovisioning. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusDeprovisioning { get; set; }
        /// <summary>The number of cloud PCs that have a status of failed. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusFailed { get; set; }
        /// <summary>The number of cloud PCs that have a status of inGracePeriod. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusInGracePeriod { get; set; }
        /// <summary>The number of cloud PCs that have a status of notProvisioned. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusNotProvisioned { get; set; }
        /// <summary>The number of cloud PCs that have a status of provisioned. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusProvisioned { get; set; }
        /// <summary>The number of cloud PCs that have a status of provisioning. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusProvisioning { get; set; }
        /// <summary>The number of cloud PCs that have a status of unknown. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusUnknown { get; set; }
        /// <summary>The number of cloud PCs that have a status of upgrading. Optional. Read-only.</summary>
        public int? NumberOfCloudPcStatusUpgrading { get; set; }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        public string TenantId { get; set; }
        /// <summary>The total number of cloud PC connection statuses for the given managed tenant. Optional. Read-only.</summary>
        public int? TotalCloudPcConnectionStatus { get; set; }
        /// <summary>The total number of cloud PC statues for the given managed tenant. Optional. Read-only.</summary>
        public int? TotalCloudPcStatus { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastRefreshedDateTime", (o,n) => { (o as CloudPcOverview).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"numberOfCloudPcConnectionStatusFailed", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcConnectionStatusFailed = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusPassed", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcConnectionStatusPassed = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusPending", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcConnectionStatusPending = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusRunning", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcConnectionStatusRunning = n.GetIntValue(); } },
                {"numberOfCloudPcConnectionStatusUnkownFutureValue", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcConnectionStatusUnkownFutureValue = n.GetIntValue(); } },
                {"numberOfCloudPcStatusDeprovisioning", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusDeprovisioning = n.GetIntValue(); } },
                {"numberOfCloudPcStatusFailed", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusFailed = n.GetIntValue(); } },
                {"numberOfCloudPcStatusInGracePeriod", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusInGracePeriod = n.GetIntValue(); } },
                {"numberOfCloudPcStatusNotProvisioned", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusNotProvisioned = n.GetIntValue(); } },
                {"numberOfCloudPcStatusProvisioned", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusProvisioned = n.GetIntValue(); } },
                {"numberOfCloudPcStatusProvisioning", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusProvisioning = n.GetIntValue(); } },
                {"numberOfCloudPcStatusUnknown", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusUnknown = n.GetIntValue(); } },
                {"numberOfCloudPcStatusUpgrading", (o,n) => { (o as CloudPcOverview).NumberOfCloudPcStatusUpgrading = n.GetIntValue(); } },
                {"tenantDisplayName", (o,n) => { (o as CloudPcOverview).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as CloudPcOverview).TenantId = n.GetStringValue(); } },
                {"totalCloudPcConnectionStatus", (o,n) => { (o as CloudPcOverview).TotalCloudPcConnectionStatus = n.GetIntValue(); } },
                {"totalCloudPcStatus", (o,n) => { (o as CloudPcOverview).TotalCloudPcStatus = n.GetIntValue(); } },
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
            writer.WriteIntValue("totalCloudPcConnectionStatus", TotalCloudPcConnectionStatus);
            writer.WriteIntValue("totalCloudPcStatus", TotalCloudPcStatus);
        }
    }
}
