using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants {
    public class CloudPcConnection : Entity, IParsable {
        /// <summary>The display name of the cloud PC connection. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The health status of the cloud PC connection. Possible values are: pending, running, passed, failed, unknownFutureValue.  Required. Read-only.</summary>
        public string HealthCheckStatus { get; set; }
        /// <summary>Date and time the entity was last updated in the multi-tenant management platform. Required. Read-only.</summary>
        public DateTimeOffset? LastRefreshedDateTime { get; set; }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string TenantDisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Required. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as CloudPcConnection).DisplayName = n.GetStringValue(); } },
                {"healthCheckStatus", (o,n) => { (o as CloudPcConnection).HealthCheckStatus = n.GetStringValue(); } },
                {"lastRefreshedDateTime", (o,n) => { (o as CloudPcConnection).LastRefreshedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantDisplayName", (o,n) => { (o as CloudPcConnection).TenantDisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as CloudPcConnection).TenantId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("healthCheckStatus", HealthCheckStatus);
            writer.WriteDateTimeOffsetValue("lastRefreshedDateTime", LastRefreshedDateTime);
            writer.WriteStringValue("tenantDisplayName", TenantDisplayName);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
