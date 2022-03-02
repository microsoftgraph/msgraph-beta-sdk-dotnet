using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.ManagedTenants;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TenantRelationship : Entity, IParsable {
        public List<DelegatedAdminCustomer> DelegatedAdminCustomers { get; set; }
        public List<DelegatedAdminRelationship> DelegatedAdminRelationships { get; set; }
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
        public ManagedTenant ManagedTenants { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"delegatedAdminCustomers", (o,n) => { (o as TenantRelationship).DelegatedAdminCustomers = n.GetCollectionOfObjectValues<DelegatedAdminCustomer>().ToList(); } },
                {"delegatedAdminRelationships", (o,n) => { (o as TenantRelationship).DelegatedAdminRelationships = n.GetCollectionOfObjectValues<DelegatedAdminRelationship>().ToList(); } },
                {"managedTenants", (o,n) => { (o as TenantRelationship).ManagedTenants = n.GetObjectValue<ManagedTenant>(); } },
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
