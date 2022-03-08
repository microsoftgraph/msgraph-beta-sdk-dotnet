using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the policyRoot singleton.</summary>
    public class DefaultUserRoleOverride : Entity, IParsable {
        public bool? IsDefault { get; set; }
        public List<UnifiedRolePermission> RolePermissions { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isDefault", (o,n) => { (o as DefaultUserRoleOverride).IsDefault = n.GetBoolValue(); } },
                {"rolePermissions", (o,n) => { (o as DefaultUserRoleOverride).RolePermissions = n.GetCollectionOfObjectValues<UnifiedRolePermission>(UnifiedRolePermission.CreateFromDiscriminatorValue).ToList(); } },
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
