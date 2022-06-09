using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class ContentType : Entity, IParsable {
        /// <summary>List of canonical URLs for hub sites with which this content type is associated to. This will contain all hubsites where this content type is queued to be enforced or is already enforced. Enforcing a content type means that the content type will be applied to the lists in the enforced sites.</summary>
        public List<string> AssociatedHubsUrls {
            get { return BackingStore?.Get<List<string>>(nameof(AssociatedHubsUrls)); }
            set { BackingStore?.Set(nameof(AssociatedHubsUrls), value); }
        }
        /// <summary>Parent contentType from which this content type is derived.</summary>
        public ContentType Base {
            get { return BackingStore?.Get<ContentType>(nameof(Base)); }
            set { BackingStore?.Set(nameof(Base), value); }
        }
        /// <summary>The collection of content types that are ancestors of this content type.</summary>
        public List<ContentType> BaseTypes {
            get { return BackingStore?.Get<List<ContentType>>(nameof(BaseTypes)); }
            set { BackingStore?.Set(nameof(BaseTypes), value); }
        }
        /// <summary>The collection of columns that are required by this content type</summary>
        public List<ColumnLink> ColumnLinks {
            get { return BackingStore?.Get<List<ColumnLink>>(nameof(ColumnLinks)); }
            set { BackingStore?.Set(nameof(ColumnLinks), value); }
        }
        /// <summary>Column order information in a content type.</summary>
        public List<ColumnDefinition> ColumnPositions {
            get { return BackingStore?.Get<List<ColumnDefinition>>(nameof(ColumnPositions)); }
            set { BackingStore?.Set(nameof(ColumnPositions), value); }
        }
        /// <summary>The collection of column definitions for this contentType.</summary>
        public List<ColumnDefinition> Columns {
            get { return BackingStore?.Get<List<ColumnDefinition>>(nameof(Columns)); }
            set { BackingStore?.Set(nameof(Columns), value); }
        }
        /// <summary>The descriptive text for the item.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Document Set metadata.</summary>
        public Microsoft.Graph.Beta.Models.DocumentSet DocumentSet {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DocumentSet>(nameof(DocumentSet)); }
            set { BackingStore?.Set(nameof(DocumentSet), value); }
        }
        /// <summary>Document template metadata. To make sure that documents have consistent content across a site and its subsites, you can associate a Word, Excel, or PowerPoint template with a site content type.</summary>
        public DocumentSetContent DocumentTemplate {
            get { return BackingStore?.Get<DocumentSetContent>(nameof(DocumentTemplate)); }
            set { BackingStore?.Set(nameof(DocumentTemplate), value); }
        }
        /// <summary>The name of the group this content type belongs to. Helps organize related content types.</summary>
        public string Group {
            get { return BackingStore?.Get<string>(nameof(Group)); }
            set { BackingStore?.Set(nameof(Group), value); }
        }
        /// <summary>Indicates whether the content type is hidden in the list&apos;s &apos;New&apos; menu.</summary>
        public bool? Hidden {
            get { return BackingStore?.Get<bool?>(nameof(Hidden)); }
            set { BackingStore?.Set(nameof(Hidden), value); }
        }
        /// <summary>If this content type is inherited from another scope (like a site), provides a reference to the item where the content type is defined.</summary>
        public ItemReference InheritedFrom {
            get { return BackingStore?.Get<ItemReference>(nameof(InheritedFrom)); }
            set { BackingStore?.Set(nameof(InheritedFrom), value); }
        }
        /// <summary>Specifies if a content type is a built-in content type.</summary>
        public bool? IsBuiltIn {
            get { return BackingStore?.Get<bool?>(nameof(IsBuiltIn)); }
            set { BackingStore?.Set(nameof(IsBuiltIn), value); }
        }
        /// <summary>The name of the content type.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>Specifies the order in which the content type appears in the selection UI.</summary>
        public ContentTypeOrder Order {
            get { return BackingStore?.Get<ContentTypeOrder>(nameof(Order)); }
            set { BackingStore?.Set(nameof(Order), value); }
        }
        /// <summary>The unique identifier of the content type.</summary>
        public string ParentId {
            get { return BackingStore?.Get<string>(nameof(ParentId)); }
            set { BackingStore?.Set(nameof(ParentId), value); }
        }
        /// <summary>If true, any changes made to the content type will be pushed to inherited content types and lists that implement the content type.</summary>
        public bool? PropagateChanges {
            get { return BackingStore?.Get<bool?>(nameof(PropagateChanges)); }
            set { BackingStore?.Set(nameof(PropagateChanges), value); }
        }
        /// <summary>If true, the content type cannot be modified unless this value is first set to false.</summary>
        public bool? ReadOnly {
            get { return BackingStore?.Get<bool?>(nameof(ReadOnly)); }
            set { BackingStore?.Set(nameof(ReadOnly), value); }
        }
        /// <summary>If true, the content type cannot be modified by users or through push-down operations. Only site collection administrators can seal or unseal content types.</summary>
        public bool? Sealed {
            get { return BackingStore?.Get<bool?>(nameof(Sealed)); }
            set { BackingStore?.Set(nameof(Sealed), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ContentType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"associatedHubsUrls", n => { AssociatedHubsUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"base", n => { Base = n.GetObjectValue<ContentType>(ContentType.CreateFromDiscriminatorValue); } },
                {"baseTypes", n => { BaseTypes = n.GetCollectionOfObjectValues<ContentType>(ContentType.CreateFromDiscriminatorValue).ToList(); } },
                {"columnLinks", n => { ColumnLinks = n.GetCollectionOfObjectValues<ColumnLink>(ColumnLink.CreateFromDiscriminatorValue).ToList(); } },
                {"columnPositions", n => { ColumnPositions = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"columns", n => { Columns = n.GetCollectionOfObjectValues<ColumnDefinition>(ColumnDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"documentSet", n => { DocumentSet = n.GetObjectValue<Microsoft.Graph.Beta.Models.DocumentSet>(Microsoft.Graph.Beta.Models.DocumentSet.CreateFromDiscriminatorValue); } },
                {"documentTemplate", n => { DocumentTemplate = n.GetObjectValue<DocumentSetContent>(DocumentSetContent.CreateFromDiscriminatorValue); } },
                {"group", n => { Group = n.GetStringValue(); } },
                {"hidden", n => { Hidden = n.GetBoolValue(); } },
                {"inheritedFrom", n => { InheritedFrom = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"isBuiltIn", n => { IsBuiltIn = n.GetBoolValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"order", n => { Order = n.GetObjectValue<ContentTypeOrder>(ContentTypeOrder.CreateFromDiscriminatorValue); } },
                {"parentId", n => { ParentId = n.GetStringValue(); } },
                {"propagateChanges", n => { PropagateChanges = n.GetBoolValue(); } },
                {"readOnly", n => { ReadOnly = n.GetBoolValue(); } },
                {"sealed", n => { Sealed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("associatedHubsUrls", AssociatedHubsUrls);
            writer.WriteObjectValue<ContentType>("base", Base);
            writer.WriteCollectionOfObjectValues<ContentType>("baseTypes", BaseTypes);
            writer.WriteCollectionOfObjectValues<ColumnLink>("columnLinks", ColumnLinks);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columnPositions", ColumnPositions);
            writer.WriteCollectionOfObjectValues<ColumnDefinition>("columns", Columns);
            writer.WriteStringValue("description", Description);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DocumentSet>("documentSet", DocumentSet);
            writer.WriteObjectValue<DocumentSetContent>("documentTemplate", DocumentTemplate);
            writer.WriteStringValue("group", Group);
            writer.WriteBoolValue("hidden", Hidden);
            writer.WriteObjectValue<ItemReference>("inheritedFrom", InheritedFrom);
            writer.WriteBoolValue("isBuiltIn", IsBuiltIn);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ContentTypeOrder>("order", Order);
            writer.WriteStringValue("parentId", ParentId);
            writer.WriteBoolValue("propagateChanges", PropagateChanges);
            writer.WriteBoolValue("readOnly", ReadOnly);
            writer.WriteBoolValue("sealed", Sealed);
        }
    }
}
