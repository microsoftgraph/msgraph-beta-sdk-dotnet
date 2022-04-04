using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DelegatedAdminCustomer : Entity, IParsable {
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The serviceManagementDetails property</summary>
        public List<DelegatedAdminServiceManagementDetail> ServiceManagementDetails { get; set; }
        /// <summary>The tenantId property</summary>
        public string TenantId { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DelegatedAdminCustomer).DisplayName = n.GetStringValue(); } },
                {"serviceManagementDetails", (o,n) => { (o as DelegatedAdminCustomer).ServiceManagementDetails = n.GetCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>(DelegatedAdminServiceManagementDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"tenantId", (o,n) => { (o as DelegatedAdminCustomer).TenantId = n.GetStringValue(); } },
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
