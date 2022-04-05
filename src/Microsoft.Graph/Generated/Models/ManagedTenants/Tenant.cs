using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    public class Tenant : Entity, IParsable {
        /// <summary>The relationship details for the tenant with the managing entity.</summary>
        public TenantContract Contract { get; set; }
        /// <summary>The date and time the tenant was created in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The display name for the tenant. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time the tenant was last updated within the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>The onboarding status information for the tenant. Optional. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation TenantStatusInformation { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Tenant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Tenant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contract", (o,n) => { (o as Tenant).Contract = n.GetObjectValue<TenantContract>(TenantContract.CreateFromDiscriminatorValue); } },
                {"createdDateTime", (o,n) => { (o as Tenant).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as Tenant).DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as Tenant).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantId", (o,n) => { (o as Tenant).TenantId = n.GetStringValue(); } },
                {"tenantStatusInformation", (o,n) => { (o as Tenant).TenantStatusInformation = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation>(Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TenantContract>("contract", Contract);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation>("tenantStatusInformation", TenantStatusInformation);
        }
    }
}
