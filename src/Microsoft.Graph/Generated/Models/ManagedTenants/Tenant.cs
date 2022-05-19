using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.ManagedTenants {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class Tenant : Entity, IParsable {
        /// <summary>The relationship details for the tenant with the managing entity.</summary>
        public TenantContract Contract {
            get { return BackingStore?.Get<TenantContract>(nameof(Contract)); }
            set { BackingStore?.Set(nameof(Contract), value); }
        }
        /// <summary>The date and time the tenant was created in the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The display name for the tenant. Required. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date and time the tenant was last updated within the multi-tenant management platform. Optional. Read-only.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The onboarding status information for the tenant. Optional. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation TenantStatusInformation {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation>(nameof(TenantStatusInformation)); }
            set { BackingStore?.Set(nameof(TenantStatusInformation), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"contract", n => { Contract = n.GetObjectValue<TenantContract>(TenantContract.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"tenantStatusInformation", n => { TenantStatusInformation = n.GetObjectValue<Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation>(Microsoft.Graph.Beta.Models.ManagedTenants.TenantStatusInformation.CreateFromDiscriminatorValue); } },
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
