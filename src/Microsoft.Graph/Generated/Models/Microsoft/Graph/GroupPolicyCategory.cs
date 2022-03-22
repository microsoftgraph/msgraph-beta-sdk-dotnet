using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GroupPolicyCategory : Entity, IParsable {
        /// <summary>The children categories</summary>
        public List<GroupPolicyCategory> Children { get; set; }
        /// <summary>The id of the definition file the category came from</summary>
        public GroupPolicyDefinitionFile DefinitionFile { get; set; }
        /// <summary>The immediate GroupPolicyDefinition children of the category</summary>
        public List<GroupPolicyDefinition> Definitions { get; set; }
        /// <summary>The string id of the category's display name</summary>
        public string DisplayName { get; set; }
        /// <summary>Defines if the category is a root category</summary>
        public bool? IsRoot { get; set; }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The parent category</summary>
        public GroupPolicyCategory Parent { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyCategory CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyCategory();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"children", (o,n) => { (o as GroupPolicyCategory).Children = n.GetCollectionOfObjectValues<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue).ToList(); } },
                {"definitionFile", (o,n) => { (o as GroupPolicyCategory).DefinitionFile = n.GetObjectValue<GroupPolicyDefinitionFile>(GroupPolicyDefinitionFile.CreateFromDiscriminatorValue); } },
                {"definitions", (o,n) => { (o as GroupPolicyCategory).Definitions = n.GetCollectionOfObjectValues<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"displayName", (o,n) => { (o as GroupPolicyCategory).DisplayName = n.GetStringValue(); } },
                {"isRoot", (o,n) => { (o as GroupPolicyCategory).IsRoot = n.GetBoolValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyCategory).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parent", (o,n) => { (o as GroupPolicyCategory).Parent = n.GetObjectValue<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<GroupPolicyCategory>("children", Children);
            writer.WriteObjectValue<GroupPolicyDefinitionFile>("definitionFile", DefinitionFile);
            writer.WriteCollectionOfObjectValues<GroupPolicyDefinition>("definitions", Definitions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isRoot", IsRoot);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<GroupPolicyCategory>("parent", Parent);
        }
    }
}
