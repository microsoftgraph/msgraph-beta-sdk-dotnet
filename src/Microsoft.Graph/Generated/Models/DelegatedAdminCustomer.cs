using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DelegatedAdminCustomer : Entity, IParsable {
        /// <summary>The Azure AD display name of the customer tenant. Read-only. Supports $orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Contains the management details of a service in the customer tenant that&apos;s managed by delegated administration.</summary>
        public List<DelegatedAdminServiceManagementDetail> ServiceManagementDetails {
            get { return BackingStore?.Get<List<DelegatedAdminServiceManagementDetail>>("serviceManagementDetails"); }
            set { BackingStore?.Set("serviceManagementDetails", value); }
        }
        /// <summary>The Azure AD-assigned tenant ID of the customer. Read-only.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>("tenantId"); }
            set { BackingStore?.Set("tenantId", value); }
        }
        /// <summary>
        /// Instantiates a new DelegatedAdminCustomer and sets the default values.
        /// </summary>
        public DelegatedAdminCustomer() : base() {
            OdataType = "#microsoft.graph.delegatedAdminCustomer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DelegatedAdminCustomer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DelegatedAdminCustomer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"serviceManagementDetails", n => { ServiceManagementDetails = n.GetCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>(DelegatedAdminServiceManagementDetail.CreateFromDiscriminatorValue)?.ToList(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
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
            writer.WriteCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>("serviceManagementDetails", ServiceManagementDetails);
            writer.WriteStringValue("tenantId", TenantId);
        }
    }
}
