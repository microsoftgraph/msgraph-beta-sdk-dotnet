using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class ManagedDeviceComplianceTrend : Entity, IParsable {
        /// <summary>The number of devices with a compliant status. Required. Read-only.</summary>
        public int? CompliantDeviceCount { get; set; }
        /// <summary>The number of devices manged by Configuration Manager. Required. Read-only.</summary>
        public int? ConfigManagerDeviceCount { get; set; }
        /// <summary>The date and time compliance snapshot was performed. Required. Read-only.</summary>
        public string CountDateTime { get; set; }
        /// <summary>The number of devices with an error status. Required. Read-only.</summary>
        public int? ErrorDeviceCount { get; set; }
        /// <summary>The number of devices that are in a grace period status. Required. Read-only.</summary>
        public int? InGracePeriodDeviceCount { get; set; }
        /// <summary>The number of devices that are in a non-compliant status. Required. Read-only.</summary>
        public int? NoncompliantDeviceCount { get; set; }
        /// <summary>The display name for the managed tenant. Optional. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>The number of devices in an unknown status. Required. Read-only.</summary>
        public int? UnknownDeviceCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"compliantDeviceCount", (o,n) => { (o as ManagedDeviceComplianceTrend).CompliantDeviceCount = n.GetIntValue(); } },
                {"configManagerDeviceCount", (o,n) => { (o as ManagedDeviceComplianceTrend).ConfigManagerDeviceCount = n.GetIntValue(); } },
                {"countDateTime", (o,n) => { (o as ManagedDeviceComplianceTrend).CountDateTime = n.GetStringValue(); } },
                {"errorDeviceCount", (o,n) => { (o as ManagedDeviceComplianceTrend).ErrorDeviceCount = n.GetIntValue(); } },
                {"inGracePeriodDeviceCount", (o,n) => { (o as ManagedDeviceComplianceTrend).InGracePeriodDeviceCount = n.GetIntValue(); } },
                {"noncompliantDeviceCount", (o,n) => { (o as ManagedDeviceComplianceTrend).NoncompliantDeviceCount = n.GetIntValue(); } },
                {"tenantDisplayName", (o,n) => { (o as ManagedDeviceComplianceTrend).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as ManagedDeviceComplianceTrend).TenantId = n.GetStringValue(); } },
                {"unknownDeviceCount", (o,n) => { (o as ManagedDeviceComplianceTrend).UnknownDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("compliantDeviceCount", CompliantDeviceCount);
            writer.WriteIntValue("configManagerDeviceCount", ConfigManagerDeviceCount);
            writer.WriteStringValue("countDateTime", CountDateTime);
            writer.WriteIntValue("errorDeviceCount", ErrorDeviceCount);
            writer.WriteIntValue("inGracePeriodDeviceCount", InGracePeriodDeviceCount);
            writer.WriteIntValue("noncompliantDeviceCount", NoncompliantDeviceCount);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteIntValue("unknownDeviceCount", UnknownDeviceCount);
        }
    }
}
