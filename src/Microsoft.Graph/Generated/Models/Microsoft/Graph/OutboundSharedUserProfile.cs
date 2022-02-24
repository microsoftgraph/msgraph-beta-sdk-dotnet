using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OutboundSharedUserProfile : DirectoryObject, IParsable {
        public List<TenantReference> Tenants { get; set; }
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"tenants", (o,n) => { (o as OutboundSharedUserProfile).Tenants = n.GetCollectionOfObjectValues<TenantReference>().ToList(); } },
                {"userId", (o,n) => { (o as OutboundSharedUserProfile).UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TenantReference>("tenants", Tenants);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
