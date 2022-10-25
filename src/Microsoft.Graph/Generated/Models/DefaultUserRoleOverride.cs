using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class DefaultUserRoleOverride : Entity, IParsable {
        /// <summary>The isDefault property</summary>
        public bool? IsDefault {
            get { return BackingStore?.Get<bool?>("isDefault"); }
            set { BackingStore?.Set("isDefault", value); }
        }
        /// <summary>The rolePermissions property</summary>
        public List<UnifiedRolePermission> RolePermissions {
            get { return BackingStore?.Get<List<UnifiedRolePermission>>("rolePermissions"); }
            set { BackingStore?.Set("rolePermissions", value); }
        }
        /// <summary>
        /// Instantiates a new defaultUserRoleOverride and sets the default values.
        /// </summary>
        public DefaultUserRoleOverride() : base() {
            OdataType = "#microsoft.graph.defaultUserRoleOverride";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DefaultUserRoleOverride CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DefaultUserRoleOverride();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isDefault", n => { IsDefault = n.GetBoolValue(); } },
                {"rolePermissions", n => { RolePermissions = n.GetCollectionOfObjectValues<UnifiedRolePermission>(UnifiedRolePermission.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isDefault", IsDefault);
            writer.WriteCollectionOfObjectValues<UnifiedRolePermission>("rolePermissions", RolePermissions);
        }
    }
}
