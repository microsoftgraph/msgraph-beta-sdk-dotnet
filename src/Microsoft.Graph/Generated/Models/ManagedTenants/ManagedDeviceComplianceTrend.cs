using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class ManagedDeviceComplianceTrend : Entity, IParsable {
        /// <summary>The number of devices with a compliant status. Required. Read-only.</summary>
        public int? CompliantDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(CompliantDeviceCount)); }
            set { BackingStore?.Set(nameof(CompliantDeviceCount), value); }
        }
        /// <summary>The number of devices manged by Configuration Manager. Required. Read-only.</summary>
        public int? ConfigManagerDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ConfigManagerDeviceCount)); }
            set { BackingStore?.Set(nameof(ConfigManagerDeviceCount), value); }
        }
        /// <summary>The date and time compliance snapshot was performed. Required. Read-only.</summary>
        public string CountDateTime {
            get { return BackingStore?.Get<string>(nameof(CountDateTime)); }
            set { BackingStore?.Set(nameof(CountDateTime), value); }
        }
        /// <summary>The number of devices with an error status. Required. Read-only.</summary>
        public int? ErrorDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorDeviceCount)); }
            set { BackingStore?.Set(nameof(ErrorDeviceCount), value); }
        }
        /// <summary>The number of devices that are in a grace period status. Required. Read-only.</summary>
        public int? InGracePeriodDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(InGracePeriodDeviceCount)); }
            set { BackingStore?.Set(nameof(InGracePeriodDeviceCount), value); }
        }
        /// <summary>The number of devices that are in a non-compliant status. Required. Read-only.</summary>
        public int? NoncompliantDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(NoncompliantDeviceCount)); }
            set { BackingStore?.Set(nameof(NoncompliantDeviceCount), value); }
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
        /// <summary>The number of devices in an unknown status. Required. Read-only.</summary>
        public int? UnknownDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownDeviceCount)); }
            set { BackingStore?.Set(nameof(UnknownDeviceCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ManagedDeviceComplianceTrend CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ManagedDeviceComplianceTrend();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"compliantDeviceCount", n => { CompliantDeviceCount = n.GetIntValue(); } },
                {"configManagerDeviceCount", n => { ConfigManagerDeviceCount = n.GetIntValue(); } },
                {"countDateTime", n => { CountDateTime = n.GetStringValue(); } },
                {"errorDeviceCount", n => { ErrorDeviceCount = n.GetIntValue(); } },
                {"inGracePeriodDeviceCount", n => { InGracePeriodDeviceCount = n.GetIntValue(); } },
                {"noncompliantDeviceCount", n => { NoncompliantDeviceCount = n.GetIntValue(); } },
                {"tenantDisplayName", n => { TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"unknownDeviceCount", n => { UnknownDeviceCount = n.GetIntValue(); } },
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
