using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UnifiedRbacResourceAction : Entity, IParsable {
        public string ActionVerb { get; set; }
        public string Description { get; set; }
        public string Name { get; set; }
        public UnifiedRbacResourceScope ResourceScope { get; set; }
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
