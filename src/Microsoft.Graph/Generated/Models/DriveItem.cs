using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DriveItem : BaseItem, IParsable {
        /// <summary>The list of recent activities that took place on this item.</summary>
        public List<ItemActivityOLD> Activities {
            get { return BackingStore?.Get<List<ItemActivityOLD>>("activities"); }
            set { BackingStore?.Set("activities", value); }
        }
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ItemAnalytics Analytics {
            get { return BackingStore?.Get<ItemAnalytics>("analytics"); }
            set { BackingStore?.Set("analytics", value); }
        }
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Only on OneDrive Personal.</summary>
        public Microsoft.Graph.Beta.Models.Audio Audio {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Audio>("audio"); }
            set { BackingStore?.Set("audio", value); }
        }
        /// <summary>Bundle metadata, if the item is a bundle. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Bundle Bundle {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Bundle>("bundle"); }
            set { BackingStore?.Set("bundle", value); }
        }
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
        public List<DriveItem> Children {
            get { return BackingStore?.Get<List<DriveItem>>("children"); }
            set { BackingStore?.Set("children", value); }
        }
        /// <summary>The content stream, if the item represents a file.</summary>
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.</summary>
        public string CTag {
            get { return BackingStore?.Get<string>("cTag"); }
            set { BackingStore?.Set("cTag", value); }
        }
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Deleted Deleted {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Deleted>("deleted"); }
            set { BackingStore?.Set("deleted", value); }
        }
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.FileObject FileObject {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FileObject>("file"); }
            set { BackingStore?.Set("file", value); }
        }
        /// <summary>File system information on client. Read-write.</summary>
        public Microsoft.Graph.Beta.Models.FileSystemInfo FileSystemInfo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.FileSystemInfo>("fileSystemInfo"); }
            set { BackingStore?.Set("fileSystemInfo", value); }
        }
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Folder Folder {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Folder>("folder"); }
            set { BackingStore?.Set("folder", value); }
        }
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Image Image {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Image>("image"); }
            set { BackingStore?.Set("image", value); }
        }
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.ListItem ListItem {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ListItem>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
        public GeoCoordinates Location {
            get { return BackingStore?.Get<GeoCoordinates>("location"); }
            set { BackingStore?.Set("location", value); }
        }
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Malware Malware {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Malware>("malware"); }
            set { BackingStore?.Set("malware", value); }
        }
        /// <summary>Information about the media (audio or video) item. Read-write. Only on OneDrive for Business and SharePoint.</summary>
        public Microsoft.Graph.Beta.Models.Media Media {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Media>("media"); }
            set { BackingStore?.Set("media", value); }
        }
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Package Package {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Package>("package"); }
            set { BackingStore?.Set("package", value); }
        }
        /// <summary>If present, indicates that indicates that one or more operations that may affect the state of the driveItem are pending completion. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.PendingOperations PendingOperations {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PendingOperations>("pendingOperations"); }
            set { BackingStore?.Set("pendingOperations", value); }
        }
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
        public List<Permission> Permissions {
            get { return BackingStore?.Get<List<Permission>>("permissions"); }
            set { BackingStore?.Set("permissions", value); }
        }
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Photo Photo {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Photo>("photo"); }
            set { BackingStore?.Set("photo", value); }
        }
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.</summary>
        public PublicationFacet Publication {
            get { return BackingStore?.Get<PublicationFacet>("publication"); }
            set { BackingStore?.Set("publication", value); }
        }
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.RemoteItem RemoteItem {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RemoteItem>("remoteItem"); }
            set { BackingStore?.Set("remoteItem", value); }
        }
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
        public Microsoft.Graph.Beta.Models.Root Root {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Root>("root"); }
            set { BackingStore?.Set("root", value); }
        }
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SearchResult SearchResult {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SearchResult>("searchResult"); }
            set { BackingStore?.Set("searchResult", value); }
        }
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Shared Shared {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Shared>("shared"); }
            set { BackingStore?.Set("shared", value); }
        }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SharepointIds SharepointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds"); }
            set { BackingStore?.Set("sharepointIds", value); }
        }
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>("size"); }
            set { BackingStore?.Set("size", value); }
        }
        /// <summary>Information about the drive item source. Read-only. Only on OneDrive for Business and SharePoint.</summary>
        public DriveItemSource Source {
            get { return BackingStore?.Get<DriveItemSource>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.SpecialFolder SpecialFolder {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SpecialFolder>("specialFolder"); }
            set { BackingStore?.Set("specialFolder", value); }
        }
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
        public List<Subscription> Subscriptions {
            get { return BackingStore?.Get<List<Subscription>>("subscriptions"); }
            set { BackingStore?.Set("subscriptions", value); }
        }
        /// <summary>Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.</summary>
        public List<ThumbnailSet> Thumbnails {
            get { return BackingStore?.Get<List<ThumbnailSet>>("thumbnails"); }
            set { BackingStore?.Set("thumbnails", value); }
        }
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
        public List<DriveItemVersion> Versions {
            get { return BackingStore?.Get<List<DriveItemVersion>>("versions"); }
            set { BackingStore?.Set("versions", value); }
        }
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Video Video {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Video>("video"); }
            set { BackingStore?.Set("video", value); }
        }
        /// <summary>WebDAV compatible URL for the item.</summary>
        public string WebDavUrl {
            get { return BackingStore?.Get<string>("webDavUrl"); }
            set { BackingStore?.Set("webDavUrl", value); }
        }
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet&apos;s contents. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.Workbook Workbook {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Workbook>("workbook"); }
            set { BackingStore?.Set("workbook", value); }
        }
        /// <summary>
        /// Instantiates a new driveItem and sets the default values.
        /// </summary>
        public DriveItem() : base() {
            OdataType = "#microsoft.graph.driveItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DriveItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DriveItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue).ToList(); } },
                {"analytics", n => { Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", n => { Audio = n.GetObjectValue<Microsoft.Graph.Beta.Models.Audio>(Microsoft.Graph.Beta.Models.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", n => { Bundle = n.GetObjectValue<Microsoft.Graph.Beta.Models.Bundle>(Microsoft.Graph.Beta.Models.Bundle.CreateFromDiscriminatorValue); } },
                {"children", n => { Children = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"cTag", n => { CTag = n.GetStringValue(); } },
                {"deleted", n => { Deleted = n.GetObjectValue<Microsoft.Graph.Beta.Models.Deleted>(Microsoft.Graph.Beta.Models.Deleted.CreateFromDiscriminatorValue); } },
                {"file", n => { FileObject = n.GetObjectValue<Microsoft.Graph.Beta.Models.FileObject>(Microsoft.Graph.Beta.Models.FileObject.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", n => { FileSystemInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.FileSystemInfo>(Microsoft.Graph.Beta.Models.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", n => { Folder = n.GetObjectValue<Microsoft.Graph.Beta.Models.Folder>(Microsoft.Graph.Beta.Models.Folder.CreateFromDiscriminatorValue); } },
                {"image", n => { Image = n.GetObjectValue<Microsoft.Graph.Beta.Models.Image>(Microsoft.Graph.Beta.Models.Image.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.ListItem>(Microsoft.Graph.Beta.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"location", n => { Location = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", n => { Malware = n.GetObjectValue<Microsoft.Graph.Beta.Models.Malware>(Microsoft.Graph.Beta.Models.Malware.CreateFromDiscriminatorValue); } },
                {"media", n => { Media = n.GetObjectValue<Microsoft.Graph.Beta.Models.Media>(Microsoft.Graph.Beta.Models.Media.CreateFromDiscriminatorValue); } },
                {"package", n => { Package = n.GetObjectValue<Microsoft.Graph.Beta.Models.Package>(Microsoft.Graph.Beta.Models.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", n => { PendingOperations = n.GetObjectValue<Microsoft.Graph.Beta.Models.PendingOperations>(Microsoft.Graph.Beta.Models.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", n => { Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", n => { Photo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Photo>(Microsoft.Graph.Beta.Models.Photo.CreateFromDiscriminatorValue); } },
                {"publication", n => { Publication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", n => { RemoteItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.RemoteItem>(Microsoft.Graph.Beta.Models.RemoteItem.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<Microsoft.Graph.Beta.Models.Root>(Microsoft.Graph.Beta.Models.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", n => { SearchResult = n.GetObjectValue<Microsoft.Graph.Beta.Models.SearchResult>(Microsoft.Graph.Beta.Models.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", n => { Shared = n.GetObjectValue<Microsoft.Graph.Beta.Models.Shared>(Microsoft.Graph.Beta.Models.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", n => { SharepointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"source", n => { Source = n.GetObjectValue<DriveItemSource>(DriveItemSource.CreateFromDiscriminatorValue); } },
                {"specialFolder", n => { SpecialFolder = n.GetObjectValue<Microsoft.Graph.Beta.Models.SpecialFolder>(Microsoft.Graph.Beta.Models.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", n => { Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue).ToList(); } },
                {"thumbnails", n => { Thumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue).ToList(); } },
                {"versions", n => { Versions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"video", n => { Video = n.GetObjectValue<Microsoft.Graph.Beta.Models.Video>(Microsoft.Graph.Beta.Models.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", n => { WebDavUrl = n.GetStringValue(); } },
                {"workbook", n => { Workbook = n.GetObjectValue<Microsoft.Graph.Beta.Models.Workbook>(Microsoft.Graph.Beta.Models.Workbook.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ItemActivityOLD>("activities", Activities);
            writer.WriteObjectValue<ItemAnalytics>("analytics", Analytics);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Audio>("audio", Audio);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Bundle>("bundle", Bundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", Children);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("cTag", CTag);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.FileObject>("file", FileObject);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Folder>("folder", Folder);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Image>("image", Image);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", Location);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Malware>("malware", Malware);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Media>("media", Media);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Package>("package", Package);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PendingOperations>("pendingOperations", PendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Photo>("photo", Photo);
            writer.WriteObjectValue<PublicationFacet>("publication", Publication);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.RemoteItem>("remoteItem", RemoteItem);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Root>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SearchResult>("searchResult", SearchResult);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Shared>("shared", Shared);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteLongValue("size", Size);
            writer.WriteObjectValue<DriveItemSource>("source", Source);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", Thumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", Versions);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Workbook>("workbook", Workbook);
        }
    }
}
