using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RemoteItem : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Identity of the user, device, and application which created the item. Read-only.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Date and time of item creation. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Indicates that the remote item is a file. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.FileObject FileObject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FileObject>(nameof(FileObject)); }
            set { BackingStore?.Set(nameof(FileObject), value); }
        }
        /// <summary>Information about the remote item from the local file system. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.FileSystemInfo FileSystemInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FileSystemInfo>(nameof(FileSystemInfo)); }
            set { BackingStore?.Set(nameof(FileSystemInfo), value); }
        }
        /// <summary>Indicates that the remote item is a folder. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Folder Folder {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Folder>(nameof(Folder)); }
            set { BackingStore?.Set(nameof(Folder), value); }
        }
        /// <summary>Unique identifier for the remote item in its drive. Read-only.</summary>
        public string Id {
            get { return BackingStore?.Get<string>(nameof(Id)); }
            set { BackingStore?.Set(nameof(Id), value); }
        }
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Image Image {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Image>(nameof(Image)); }
            set { BackingStore?.Set(nameof(Image), value); }
        }
        /// <summary>Identity of the user, device, and application which last modified the item. Read-only.</summary>
        public IdentitySet LastModifiedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(LastModifiedBy)); }
            set { BackingStore?.Set(nameof(LastModifiedBy), value); }
        }
        /// <summary>Date and time the item was last modified. Read-only.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastModifiedDateTime)); }
            set { BackingStore?.Set(nameof(LastModifiedDateTime), value); }
        }
        /// <summary>Optional. Filename of the remote item. Read-only.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Package Package {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Package>(nameof(Package)); }
            set { BackingStore?.Set(nameof(Package), value); }
        }
        /// <summary>Properties of the parent of the remote item. Read-only.</summary>
        public ItemReference ParentReference {
            get { return BackingStore?.Get<ItemReference>(nameof(ParentReference)); }
            set { BackingStore?.Set(nameof(ParentReference), value); }
        }
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Shared Shared {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Shared>(nameof(Shared)); }
            set { BackingStore?.Set(nameof(Shared), value); }
        }
        /// <summary>Provides interop between items in OneDrive for Business and SharePoint with the full set of item identifiers. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>(nameof(SharepointIds)); }
            set { BackingStore?.Set(nameof(SharepointIds), value); }
        }
        /// <summary>Size of the remote item. Read-only.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SpecialFolder SpecialFolder {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SpecialFolder>(nameof(SpecialFolder)); }
            set { BackingStore?.Set(nameof(SpecialFolder), value); }
        }
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Video Video {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Video>(nameof(Video)); }
            set { BackingStore?.Set(nameof(Video), value); }
        }
        /// <summary>DAV compatible URL for the item.</summary>
        public string WebDavUrl {
            get { return BackingStore?.Get<string>(nameof(WebDavUrl)); }
            set { BackingStore?.Set(nameof(WebDavUrl), value); }
        }
        /// <summary>URL that displays the resource in the browser. Read-only.</summary>
        public string WebUrl {
            get { return BackingStore?.Get<string>(nameof(WebUrl)); }
            set { BackingStore?.Set(nameof(WebUrl), value); }
        }
        /// <summary>
        /// Instantiates a new remoteItem and sets the default values.
        /// </summary>
        public RemoteItem() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RemoteItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RemoteItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"file", n => { FileObject = n.GetObjectValue<Microsoft.Graph.Beta.Models.FileObject>(Microsoft.Graph.Beta.Models.FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.FileSystemInfo>(Microsoft.Graph.Beta.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { Folder = n.GetObjectValue<Microsoft.Graph.Beta.Models.Folder>(Microsoft.Graph.Beta.Models.Folder.CreateFromDiscriminatorValue); } },
                {"id", n => { Id = n.GetStringValue(); } },
                {"image", n => { Image = n.GetObjectValue<Microsoft.Graph.Beta.Models.Image>(Microsoft.Graph.Beta.Models.Image.CreateFromDiscriminatorValue); } },
                {"lastModifiedBy", n => { LastModifiedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"package", n => { Package = n.GetObjectValue<Microsoft.Graph.Beta.Models.Package>(Microsoft.Graph.Beta.Models.Package.CreateFromDiscriminatorValue); } },
                {"parentReference", n => { ParentReference = n.GetObjectValue<ItemReference>(ItemReference.CreateFromDiscriminatorValue); } },
                {"shared", n => { Shared = n.GetObjectValue<Microsoft.Graph.Beta.Models.Shared>(Microsoft.Graph.Beta.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"specialFolder", n => { SpecialFolder = n.GetObjectValue<Microsoft.Graph.Beta.Models.SpecialFolder>(Microsoft.Graph.Beta.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"video", n => { Video = n.GetObjectValue<Microsoft.Graph.Beta.Models.Video>(Microsoft.Graph.Beta.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                {"webUrl", n => { WebUrl = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.FileObject>("file", FileObject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Folder>("folder", Folder);
            writer.WriteStringValue("id", Id);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Image>("image", Image);
            writer.WriteObjectValue<IdentitySet>("lastModifiedBy", LastModifiedBy);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Package>("package", Package);
            writer.WriteObjectValue<ItemReference>("parentReference", ParentReference);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteStringValue("webUrl", WebUrl);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
