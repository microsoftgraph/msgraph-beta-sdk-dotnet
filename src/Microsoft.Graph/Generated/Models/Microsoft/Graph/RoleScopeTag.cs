using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class RoleScopeTag : Entity, IParsable {
        /// <summary>The list of assignments for this Role Scope Tag.</summary>
        public List<RoleScopeTagAutoAssignment> Assignments { get; set; }
        /// <summary>Description of the Role Scope Tag.</summary>
        public string Description { get; set; }
        /// <summary>The display or friendly name of the Role Scope Tag.</summary>
        public string DisplayName { get; set; }
        /// <summary>Description of the Role Scope Tag. This property is read-only.</summary>
        public bool? IsBuiltIn { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as RoleScopeTag).Assignments = n.GetCollectionOfObjectValues<RoleScopeTagAutoAssignment>().ToList(); } },
                {"description", (o,n) => { (o as RoleScopeTag).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as RoleScopeTag).DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", (o,n) => { (o as RoleScopeTag).IsBuiltIn = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<RoleScopeTagAutoAssignment>("assignments", Assignments);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
        }
    }
}
