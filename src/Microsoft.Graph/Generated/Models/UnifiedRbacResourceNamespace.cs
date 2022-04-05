using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UnifiedRbacResourceNamespace : Entity, IParsable {
        /// <summary>Name of the resource namespace. Typically, the same name as the id property, such as microsoft.aad.b2c. Required. Supports $filter (eq, startsWith).</summary>
        public string Name { get; set; }
        /// <summary>Operations that an authorized principal are allowed to perform.</summary>
        public List<UnifiedRbacResourceAction> ResourceActions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UnifiedRbacResourceNamespace CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UnifiedRbacResourceNamespace();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"name", (o,n) => { (o as UnifiedRbacResourceNamespace).Name = n.GetStringValue(); } },
                {"resourceActions", (o,n) => { (o as UnifiedRbacResourceNamespace).ResourceActions = n.GetCollectionOfObjectValues<UnifiedRbacResourceAction>(UnifiedRbacResourceAction.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfObjectValues<UnifiedRbacResourceAction>("resourceActions", ResourceActions);
        }
    }
}
