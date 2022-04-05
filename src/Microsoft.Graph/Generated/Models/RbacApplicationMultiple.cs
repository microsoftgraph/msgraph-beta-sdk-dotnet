using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RbacApplicationMultiple : Entity, IParsable {
        /// <summary>The resourceNamespaces property</summary>
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces { get; set; }
        /// <summary>The roleAssignments property</summary>
        public List<UnifiedRoleAssignmentMultiple> RoleAssignments { get; set; }
        /// <summary>The roleDefinitions property</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RbacApplicationMultiple CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RbacApplicationMultiple();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"resourceNamespaces", (o,n) => { (o as RbacApplicationMultiple).ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>(UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue).ToList(); } },
                {"roleAssignments", (o,n) => { (o as RbacApplicationMultiple).RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentMultiple>(UnifiedRoleAssignmentMultiple.CreateFromDiscriminatorValue).ToList(); } },
                {"roleDefinitions", (o,n) => { (o as RbacApplicationMultiple).RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRbacResourceNamespace>("resourceNamespaces", ResourceNamespaces);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentMultiple>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
        }
    }
}
