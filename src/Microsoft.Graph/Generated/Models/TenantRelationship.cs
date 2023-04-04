using Microsoft.Graph.Beta.Models.ManagedTenants;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TenantRelationship : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The customer who has a delegated admin relationship with a Microsoft partner.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminCustomer>? DelegatedAdminCustomers {
            get { return BackingStore?.Get<List<DelegatedAdminCustomer>?>("delegatedAdminCustomers"); }
            set { BackingStore?.Set("delegatedAdminCustomers", value); }
        }
#nullable restore
#else
        public List<DelegatedAdminCustomer> DelegatedAdminCustomers {
            get { return BackingStore?.Get<List<DelegatedAdminCustomer>>("delegatedAdminCustomers"); }
            set { BackingStore?.Set("delegatedAdminCustomers", value); }
        }
#endif
        /// <summary>The details of the delegated administrative privileges that a Microsoft partner has in a customer tenant.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<DelegatedAdminRelationship>? DelegatedAdminRelationships {
            get { return BackingStore?.Get<List<DelegatedAdminRelationship>?>("delegatedAdminRelationships"); }
            set { BackingStore?.Set("delegatedAdminRelationships", value); }
        }
#nullable restore
#else
        public List<DelegatedAdminRelationship> DelegatedAdminRelationships {
            get { return BackingStore?.Get<List<DelegatedAdminRelationship>>("delegatedAdminRelationships"); }
            set { BackingStore?.Set("delegatedAdminRelationships", value); }
        }
#endif
        /// <summary>The operations available to interact with the multi-tenant management platform.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public ManagedTenant? ManagedTenants {
            get { return BackingStore?.Get<ManagedTenant?>("managedTenants"); }
            set { BackingStore?.Set("managedTenants", value); }
        }
#nullable restore
#else
        public ManagedTenant ManagedTenants {
            get { return BackingStore?.Get<ManagedTenant>("managedTenants"); }
            set { BackingStore?.Set("managedTenants", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new TenantRelationship and sets the default values.
        /// </summary>
        public TenantRelationship() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static TenantRelationship CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TenantRelationship();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"delegatedAdminCustomers", n => { DelegatedAdminCustomers = n.GetCollectionOfObjectValues<DelegatedAdminCustomer>(DelegatedAdminCustomer.CreateFromDiscriminatorValue)?.ToList(); } },
                {"delegatedAdminRelationships", n => { DelegatedAdminRelationships = n.GetCollectionOfObjectValues<DelegatedAdminRelationship>(DelegatedAdminRelationship.CreateFromDiscriminatorValue)?.ToList(); } },
                {"managedTenants", n => { ManagedTenants = n.GetObjectValue<ManagedTenant>(ManagedTenant.CreateFromDiscriminatorValue); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<DelegatedAdminCustomer>("delegatedAdminCustomers", DelegatedAdminCustomers);
            writer.WriteCollectionOfObjectValues<DelegatedAdminRelationship>("delegatedAdminRelationships", DelegatedAdminRelationships);
            writer.WriteObjectValue<ManagedTenant>("managedTenants", ManagedTenants);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
