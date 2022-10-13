using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyCategory : Entity, IParsable {
        /// <summary>The children categories</summary>
        public List<GroupPolicyCategory> Children {
            get { return BackingStore?.Get<List<GroupPolicyCategory>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
        /// <summary>The id of the definition file the category came from</summary>
        public GroupPolicyDefinitionFile DefinitionFile {
            get { return BackingStore?.Get<GroupPolicyDefinitionFile>("definitionFile"); }
            set { BackingStore?.Set("definitionFile", value); }
        }
        /// <summary>The immediate GroupPolicyDefinition children of the category</summary>
        public List<GroupPolicyDefinition> Definitions {
            get { return BackingStore?.Get<List<GroupPolicyDefinition>>("definitions"); }
            set { BackingStore?.Set("definitions", value); }
        }
        /// <summary>The string id of the category&apos;s display name</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Category Ingestion source</summary>
        public Microsoft.Graph.Beta.Models.IngestionSource? IngestionSource {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IngestionSource?>("ingestionSource"); }
            set { BackingStore?.Set("ingestionSource", value); }
        }
        /// <summary>Defines if the category is a root category</summary>
        public bool? IsRoot {
            get { return BackingStore?.Get<bool?>("isRoot"); }
            set { BackingStore?.Set("isRoot", value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The parent category</summary>
        public GroupPolicyCategory Parent {
            get { return BackingStore?.Get<GroupPolicyCategory>("parent"); }
            set { BackingStore?.Set("parent", value); }
        }
        /// <summary>
        /// Instantiates a new groupPolicyCategory and sets the default values.
        /// </summary>
        public GroupPolicyCategory() : base() {
            OdataType = "#microsoft.graph.groupPolicyCategory";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"children", n => { Children = n.GetCollectionOfObjectValues<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue)?.ToList(); } },
                {"definitionFile", n => { DefinitionFile = n.GetObjectValue<GroupPolicyDefinitionFile>(GroupPolicyDefinitionFile.CreateFromDiscriminatorValue); } },
                {"definitions", n => { Definitions = n.GetCollectionOfObjectValues<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue)?.ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"ingestionSource", n => { IngestionSource = n.GetEnumValue<IngestionSource>(); } },
                {"isRoot", n => { IsRoot = n.GetBoolValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"parent", n => { Parent = n.GetObjectValue<GroupPolicyCategory>(GroupPolicyCategory.CreateFromDiscriminatorValue); } },
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
            writer.WriteEnumValue<IngestionSource>("ingestionSource", IngestionSource);
            writer.WriteBoolValue("isRoot", IsRoot);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteObjectValue<GroupPolicyCategory>("parent", Parent);
        }
    }
}
