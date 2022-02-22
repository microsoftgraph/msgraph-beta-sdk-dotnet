using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class InboundSharedUserProfile : DirectoryObject, IParsable {
        public string DisplayName { get; set; }
        public string HomeTenantId { get; set; }
        public string UserId { get; set; }
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"displayName", (o,n) => { (o as InboundSharedUserProfile).DisplayName = n.GetStringValue(); } },
                {"homeTenantId", (o,n) => { (o as InboundSharedUserProfile).HomeTenantId = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as InboundSharedUserProfile).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as InboundSharedUserProfile).UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteStringValue("homeTenantId", HomeTenantId);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
