using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UnifiedRbacResourceAction : Entity, IParsable {
        /// <summary>HTTP method for the action, such as DELETE, GET, PATCH, POST, PUT, or null. Supports $filter (eq) but not for null values.</summary>
        public string ActionVerb { get; set; }
        /// <summary>Description for the action. Supports $filter (eq).</summary>
        public string Description { get; set; }
        /// <summary>Name for the action within the resource namespace, such as microsoft.insights/programs/update. Can include slash character (/). Case insensitive. Required. Supports $filter (eq).</summary>
        public string Name { get; set; }
        public UnifiedRbacResourceScope ResourceScope { get; set; }
        /// <summary>Not implemented.</summary>
        public string ResourceScopeId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"actionVerb", (o,n) => { (o as UnifiedRbacResourceAction).ActionVerb = n.GetStringValue(); } },
                {"description", (o,n) => { (o as UnifiedRbacResourceAction).Description = n.GetStringValue(); } },
                {"name", (o,n) => { (o as UnifiedRbacResourceAction).Name = n.GetStringValue(); } },
                {"resourceScope", (o,n) => { (o as UnifiedRbacResourceAction).ResourceScope = n.GetObjectValue<UnifiedRbacResourceScope>(); } },
                {"resourceScopeId", (o,n) => { (o as UnifiedRbacResourceAction).ResourceScopeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("actionVerb", ActionVerb);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<UnifiedRbacResourceScope>("resourceScope", ResourceScope);
            writer.WriteStringValue("resourceScopeId", ResourceScopeId);
        }
    }
}
