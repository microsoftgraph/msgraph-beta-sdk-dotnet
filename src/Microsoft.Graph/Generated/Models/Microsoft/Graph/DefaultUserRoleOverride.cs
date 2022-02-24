using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DefaultUserRoleOverride : Entity, IParsable {
        public bool? IsDefault { get; set; }
        public List<UnifiedRolePermission> RolePermissions { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isDefault", (o,n) => { (o as DefaultUserRoleOverride).IsDefault = n.GetBoolValue(); } },
                {"rolePermissions", (o,n) => { (o as DefaultUserRoleOverride).RolePermissions = n.GetCollectionOfObjectValues<UnifiedRolePermission>().ToList(); } },
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
