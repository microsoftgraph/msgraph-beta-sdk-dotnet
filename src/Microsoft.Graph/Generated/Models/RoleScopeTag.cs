using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Role Scope Tag</summary>
    public class RoleScopeTag : Entity, IParsable {
        /// <summary>The list of assignments for this Role Scope Tag.</summary>
        public List<RoleScopeTagAutoAssignment> Assignments {
            get { return BackingStore?.Get<List<RoleScopeTagAutoAssignment>>("assignments"); }
            set { BackingStore?.Set("assignments", value); }
        }
        /// <summary>Description of the Role Scope Tag.</summary>
        public string Description {
            get { return BackingStore?.Get<string>("description"); }
            set { BackingStore?.Set("description", value); }
        }
        /// <summary>The display or friendly name of the Role Scope Tag.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Description of the Role Scope Tag. This property is read-only.</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>("isBuiltIn"); }
            set { BackingStore?.Set("isBuiltIn", value); }
        }
        /// <summary>
        /// Instantiates a new roleScopeTag and sets the default values.
        /// </summary>
        public RoleScopeTag() : base() {
            OdataType = "#microsoft.graph.roleScopeTag";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RoleScopeTag CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoleScopeTag();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignments", n => { Assignments = n.GetCollectionOfObjectValues<RoleScopeTagAutoAssignment>(RoleScopeTagAutoAssignment.CreateFromDiscriminatorValue)?.ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
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
