using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RbacApplicationMultiple : Entity, IParsable {
        /// <summary>The resourceNamespaces property</summary>
        public List<UnifiedRbacResourceNamespace> ResourceNamespaces {
            get { return BackingStore?.Get<List<UnifiedRbacResourceNamespace>>("resourceNamespaces"); }
            set { BackingStore?.Set("resourceNamespaces", value); }
        }
        /// <summary>The roleAssignments property</summary>
        public List<UnifiedRoleAssignmentMultiple> RoleAssignments {
            get { return BackingStore?.Get<List<UnifiedRoleAssignmentMultiple>>("roleAssignments"); }
            set { BackingStore?.Set("roleAssignments", value); }
        }
        /// <summary>The roleDefinitions property</summary>
        public List<UnifiedRoleDefinition> RoleDefinitions {
            get { return BackingStore?.Get<List<UnifiedRoleDefinition>>("roleDefinitions"); }
            set { BackingStore?.Set("roleDefinitions", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RbacApplicationMultiple CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RbacApplicationMultiple();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"resourceNamespaces", n => { ResourceNamespaces = n.GetCollectionOfObjectValues<UnifiedRbacResourceNamespace>(UnifiedRbacResourceNamespace.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleAssignments", n => { RoleAssignments = n.GetCollectionOfObjectValues<UnifiedRoleAssignmentMultiple>(UnifiedRoleAssignmentMultiple.CreateFromDiscriminatorValue)?.ToList(); } },
                {"roleDefinitions", n => { RoleDefinitions = n.GetCollectionOfObjectValues<UnifiedRoleDefinition>(UnifiedRoleDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<UnifiedRbacResourceNamespace>("resourceNamespaces", ResourceNamespaces);
            writer.WriteCollectionOfObjectValues<UnifiedRoleAssignmentMultiple>("roleAssignments", RoleAssignments);
            writer.WriteCollectionOfObjectValues<UnifiedRoleDefinition>("roleDefinitions", RoleDefinitions);
        }
    }
}
