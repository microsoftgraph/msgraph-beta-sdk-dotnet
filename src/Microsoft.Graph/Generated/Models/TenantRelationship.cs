using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TenantRelationship : Entity, IParsable {
        /// <summary>The customer who has a delegated admin relationship with a Microsoft partner.</summary>
        public List<DelegatedAdminCustomer> DelegatedAdminCustomers {
            get { return BackingStore?.Get<List<DelegatedAdminCustomer>>("delegatedAdminCustomers"); }
            set { BackingStore?.Set("delegatedAdminCustomers", value); }
        }
        /// <summary>The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.</summary>
        public List<DelegatedAdminRelationship> DelegatedAdminRelationships {
            get { return BackingStore?.Get<List<DelegatedAdminRelationship>>("delegatedAdminRelationships"); }
            set { BackingStore?.Set("delegatedAdminRelationships", value); }
        }
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
        public ManagedTenant ManagedTenants {
            get { return BackingStore?.Get<ManagedTenant>("managedTenants"); }
            set { BackingStore?.Set("managedTenants", value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"delegatedAdminCustomers", n => { DelegatedAdminCustomers = n.GetCollectionOfObjectValues<DelegatedAdminCustomer>(DelegatedAdminCustomer.CreateFromDiscriminatorValue).ToList(); } },
                {"delegatedAdminRelationships", n => { DelegatedAdminRelationships = n.GetCollectionOfObjectValues<DelegatedAdminRelationship>(DelegatedAdminRelationship.CreateFromDiscriminatorValue).ToList(); } },
                {"managedTenants", n => { ManagedTenants = n.GetObjectValue<ManagedTenant>(ManagedTenant.CreateFromDiscriminatorValue); } },
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
