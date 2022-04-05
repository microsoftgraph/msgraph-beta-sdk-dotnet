using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyConfiguration : Entity, IParsable {
        /// <summary>The list of group assignments for the configuration.</summary>
        public List<GroupPolicyConfigurationAssignment> Assignments { get; set; }
        /// <summary>The date and time the object was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The list of enabled or disabled group policy definition values for the configuration.</summary>
        public List<GroupPolicyDefinitionValue> DefinitionValues { get; set; }
        /// <summary>User provided description for the resource object.</summary>
        public string Description { get; set; }
        /// <summary>User provided name for the resource object.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The list of scope tags for the configuration.</summary>
        public List<string> RoleScopeTagIds { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignments", (o,n) => { (o as GroupPolicyConfiguration).Assignments = n.GetCollectionOfObjectValues<GroupPolicyConfigurationAssignment>(GroupPolicyConfigurationAssignment.CreateFromDiscriminatorValue).ToList(); } },
                {"createdDateTime", (o,n) => { (o as GroupPolicyConfiguration).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"definitionValues", (o,n) => { (o as GroupPolicyConfiguration).DefinitionValues = n.GetCollectionOfObjectValues<GroupPolicyDefinitionValue>(GroupPolicyDefinitionValue.CreateFromDiscriminatorValue).ToList(); } },
                {"description", (o,n) => { (o as GroupPolicyConfiguration).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as GroupPolicyConfiguration).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyConfiguration).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"roleScopeTagIds", (o,n) => { (o as GroupPolicyConfiguration).RoleScopeTagIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<GroupPolicyConfigurationAssignment>("assignments", Assignments);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinitionValue>("definitionValues", DefinitionValues);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("roleScopeTagIds", RoleScopeTagIds);
        }
    }
}
