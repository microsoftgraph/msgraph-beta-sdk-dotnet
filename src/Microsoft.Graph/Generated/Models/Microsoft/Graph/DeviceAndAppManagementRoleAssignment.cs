using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceAndAppManagementRoleAssignment : RoleAssignment, IParsable {
        /// <summary>The list of ids of role member security groups. These are IDs from Azure Active Directory.</summary>
        public List<string> Members { get; set; }
        /// <summary>The set of Role Scope Tags defined on the Role Assignment.</summary>
        public List<RoleScopeTag> RoleScopeTags { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"members", (o,n) => { (o as DeviceAndAppManagementRoleAssignment).Members = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"roleScopeTags", (o,n) => { (o as DeviceAndAppManagementRoleAssignment).RoleScopeTags = n.GetCollectionOfObjectValues<RoleScopeTag>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("members", Members);
            writer.WriteCollectionOfObjectValues<RoleScopeTag>("roleScopeTags", RoleScopeTags);
        }
    }
}
