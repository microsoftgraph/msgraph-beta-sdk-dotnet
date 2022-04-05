using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the tenantRelationship singleton.</summary>
    public class TenantRelationship : Entity, IParsable {
        /// <summary>The customer who has a delegated admin relationship with a Microsoft partner.</summary>
        public List<DelegatedAdminCustomer> DelegatedAdminCustomers { get; set; }
        /// <summary>The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.</summary>
        public List<DelegatedAdminRelationship> DelegatedAdminRelationships { get; set; }
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
        public ManagedTenant ManagedTenants { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TenantRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"delegatedAdminCustomers", (o,n) => { (o as TenantRelationship).DelegatedAdminCustomers = n.GetCollectionOfObjectValues<DelegatedAdminCustomer>(DelegatedAdminCustomer.CreateFromDiscriminatorValue).ToList(); } },
                {"delegatedAdminRelationships", (o,n) => { (o as TenantRelationship).DelegatedAdminRelationships = n.GetCollectionOfObjectValues<DelegatedAdminRelationship>(DelegatedAdminRelationship.CreateFromDiscriminatorValue).ToList(); } },
                {"managedTenants", (o,n) => { (o as TenantRelationship).ManagedTenants = n.GetObjectValue<ManagedTenant>(ManagedTenant.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<DelegatedAdminCustomer>("delegatedAdminCustomers", DelegatedAdminCustomers);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationship>("delegatedAdminRelationships", DelegatedAdminRelationships);
            writer.WriteObjectValue<ManagedTenant>("managedTenants", ManagedTenants);
        }
    }
}
