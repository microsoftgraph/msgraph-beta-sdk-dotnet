// <auto-generated/>
#pragma warning disable CS0618
using Microsoft.Kiota.Abstractions.Extensions;
using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System;
namespace Microsoft.Graph.Beta.Models
{
    [global::System.CodeDom.Compiler.GeneratedCode("Kiota", "1.0.0")]
    #pragma warning disable CS1591
    public partial class ListItem : global::Microsoft.Graph.Beta.Models.BaseItem, IParsable
    #pragma warning restore CS1591
    {
        /// <summary>The list of recent activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ItemActivityOLD>? Activities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ItemActivityOLD>?>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ItemActivityOLD> Activities
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ItemActivityOLD>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
#endif
        /// <summary>Analytics about the view activities that took place on this item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ItemAnalytics? Analytics
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemAnalytics?>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ItemAnalytics Analytics
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ItemAnalytics>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
#endif
        /// <summary>The content type of this list item</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.ContentTypeInfo? ContentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentTypeInfo?>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.ContentTypeInfo ContentType
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>("contentType"); }
            set { BackingStore?.Set("contentType", value); }
        }
#endif
        /// <summary>The deleted property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.Deleted? Deleted
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Deleted?>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.Deleted Deleted
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.Deleted>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
#endif
        /// <summary>Version information for a document set version created by a user.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.DocumentSetVersion>? DocumentSetVersions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DocumentSetVersion>?>("documentSetVersions"); }
            set { BackingStore?.Set("documentSetVersions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.DocumentSetVersion> DocumentSetVersions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.DocumentSetVersion>>("documentSetVersions"); }
            set { BackingStore?.Set("documentSetVersions", value); }
        }
#endif
        /// <summary>For document libraries, the driveItem relationship exposes the listItem as a driveItem</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.DriveItem? DriveItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem?>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.DriveItem DriveItem
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
#endif
        /// <summary>The values of the columns set on this list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.FieldValueSet? Fields
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.FieldValueSet?>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.FieldValueSet Fields
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.FieldValueSet>("fields"); }
            set { BackingStore?.Set("fields", value); }
        }
#endif
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.Permission>? Permissions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Permission>?>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.Permission> Permissions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.Permission>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
#endif
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public global::Microsoft.Graph.Beta.Models.SharepointIds? SharepointIds
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharepointIds?>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#nullable restore
#else
        public global::Microsoft.Graph.Beta.Models.SharepointIds SharepointIds
        {
            get { return BackingStore?.Get<global::Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
#endif
        /// <summary>The list of previous versions of the list item.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<global::Microsoft.Graph.Beta.Models.ListItemVersion>? Versions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ListItemVersion>?>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#nullable restore
#else
        public List<global::Microsoft.Graph.Beta.Models.ListItemVersion> Versions
        {
            get { return BackingStore?.Get<List<global::Microsoft.Graph.Beta.Models.ListItemVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new <see cref="global::Microsoft.Graph.Beta.Models.ListItem"/> and sets the default values.
        /// </summary>
        public ListItem() : base()
        {
            OdataType = "#microsoft.graph.listItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <returns>A <see cref="global::Microsoft.Graph.Beta.Models.ListItem"/></returns>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new global::Microsoft.Graph.Beta.Models.ListItem CreateFromDiscriminatorValue(IParseNode parseNode)
        {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new global::Microsoft.Graph.Beta.Models.ListItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        /// <returns>A IDictionary&lt;string, Action&lt;IParseNode&gt;&gt;</returns>
        public override IDictionary<string, Action<IParseNode>> GetFieldDeserializers()
        {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers())
            {
                { "activities", n => { Activities = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ItemActivityOLD>(global::Microsoft.Graph.Beta.Models.ItemActivityOLD.CreateFromDiscriminatorValue)?.AsList(); } },
                { "analytics", n => { Analytics = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ItemAnalytics>(global::Microsoft.Graph.Beta.Models.ItemAnalytics.CreateFromDiscriminatorValue); } },
                { "contentType", n => { ContentType = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>(global::Microsoft.Graph.Beta.Models.ContentTypeInfo.CreateFromDiscriminatorValue); } },
                { "deleted", n => { Deleted = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.Deleted>(global::Microsoft.Graph.Beta.Models.Deleted.CreateFromDiscriminatorValue); } },
                { "documentSetVersions", n => { DocumentSetVersions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DocumentSetVersion>(global::Microsoft.Graph.Beta.Models.DocumentSetVersion.CreateFromDiscriminatorValue)?.AsList(); } },
                { "driveItem", n => { DriveItem = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>(global::Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                { "fields", n => { Fields = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.FieldValueSet>(global::Microsoft.Graph.Beta.Models.FieldValueSet.CreateFromDiscriminatorValue); } },
                { "permissions", n => { Permissions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Permission>(global::Microsoft.Graph.Beta.Models.Permission.CreateFromDiscriminatorValue)?.AsList(); } },
                { "sharepointIds", n => { SharepointIds = n.GetObjectValue<global::Microsoft.Graph.Beta.Models.SharepointIds>(global::Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                { "versions", n => { Versions = n.GetCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ListItemVersion>(global::Microsoft.Graph.Beta.Models.ListItemVersion.CreateFromDiscriminatorValue)?.AsList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public override void Serialize(ISerializationWriter writer)
        {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ItemActivityOLD>("activities", Activities);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.ContentTypeInfo>("contentType", ContentType);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.Deleted>("deleted", Deleted);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.DocumentSetVersion>("documentSetVersions", DocumentSetVersions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.FieldValueSet>("fields", Fields);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.Permission>("permissions", Permissions);
            writer.WriteObjectValue<global::Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteCollectionOfObjectValues<global::Microsoft.Graph.Beta.Models.ListItemVersion>("versions", Versions);
        }
    }
}
#pragma warning restore CS0618
