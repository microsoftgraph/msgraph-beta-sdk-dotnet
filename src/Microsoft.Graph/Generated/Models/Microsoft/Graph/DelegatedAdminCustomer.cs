using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DelegatedAdminCustomer : Entity, IParsable {
        public string DisplayName { get; set; }
        public List<DelegatedAdminServiceManagementDetail> ServiceManagementDetails { get; set; }
        public string TenantId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as DelegatedAdminCustomer).DisplayName = n.GetStringValue(); } },
                {"serviceManagementDetails", (o,n) => { (o as DelegatedAdminCustomer).ServiceManagementDetails = n.GetCollectionOfObjectValues<DelegatedAdminServiceManagementDetail>().ToList(); } },
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
