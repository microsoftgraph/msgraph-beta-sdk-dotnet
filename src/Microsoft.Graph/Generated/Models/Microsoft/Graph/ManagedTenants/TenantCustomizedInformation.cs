using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class TenantCustomizedInformation : Entity, IParsable {
        /// <summary>The collection of contacts for the managed tenant. Optional.</summary>
        public List<TenantContactInformation> Contacts { get; set; }
        /// <summary>The display name for the managed tenant. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The Azure Active Directory tenant identifier for the managed tenant. Optional. Read-only.</summary>
        public string TenantId { get; set; }
        /// <summary>The website for the managed tenant. Required.</summary>
        public string Website { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"contacts", (o,n) => { (o as TenantCustomizedInformation).Contacts = n.GetCollectionOfObjectValues<TenantContactInformation>().ToList(); } },
                {"displayName", (o,n) => { (o as TenantCustomizedInformation).DisplayName = n.GetStringValue(); } },
                {"tenantId", (o,n) => { (o as TenantCustomizedInformation).TenantId = n.GetStringValue(); } },
                {"website", (o,n) => { (o as TenantCustomizedInformation).Website = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TenantContactInformation>("contacts", Contacts);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteStringValue("website", Website);
        }
    }
}
