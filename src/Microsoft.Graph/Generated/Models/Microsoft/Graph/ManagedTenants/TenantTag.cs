using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph.ManagedTenants {
    public class TenantTag : Entity, IParsable {
        /// <summary>The identifier for the account that created the tenant tag. Required. Read-only.</summary>
        public string CreatedByUserId { get; set; }
        /// <summary>The date and time when the tenant tag was created. Required. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The date and time when the tenant tag was deleted. Required. Read-only.</summary>
        public DateTimeOffset? DeletedDateTime { get; set; }
        /// <summary>The description for the tenant tag. Optional. Read-only.</summary>
        public string Description { get; set; }
        /// <summary>The display name for the tenant tag. Required. Read-only.</summary>
        public string DisplayName { get; set; }
        /// <summary>The identifier for the account that lasted on the tenant tag. Optional. Read-only.</summary>
        public string LastActionByUserId { get; set; }
        /// <summary>The date and time the last action was performed against the tenant tag. Optional. Read-only.</summary>
        public DateTimeOffset? LastActionDateTime { get; set; }
        /// <summary>The collection of managed tenants associated with the tenant tag. Optional.</summary>
        public List<TenantInfo> Tenants { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdByUserId", (o,n) => { (o as TenantTag).CreatedByUserId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as TenantTag).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"deletedDateTime", (o,n) => { (o as TenantTag).DeletedDateTime = n.GetDateTimeOffsetValue(); } },
                {"description", (o,n) => { (o as TenantTag).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TenantTag).DisplayName = n.GetStringValue(); } },
                {"lastActionByUserId", (o,n) => { (o as TenantTag).LastActionByUserId = n.GetStringValue(); } },
                {"lastActionDateTime", (o,n) => { (o as TenantTag).LastActionDateTime = n.GetDateTimeOffsetValue(); } },
                {"tenants", (o,n) => { (o as TenantTag).Tenants = n.GetCollectionOfObjectValues<TenantInfo>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("createdByUserId", CreatedByUserId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("deletedDateTime", DeletedDateTime);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("lastActionByUserId", LastActionByUserId);
            writer.WriteDateTimeOffsetValue("lastActionDateTime", LastActionDateTime);
            writer.WriteCollectionOfObjectValues<TenantInfo>("tenants", Tenants);
        }
    }
}
