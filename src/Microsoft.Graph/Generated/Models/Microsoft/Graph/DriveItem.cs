using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DriveItem : BaseItem, IParsable {
        /// <summary>The list of recent activities that took place on this item.</summary>
        public List<ItemActivityOLD> Activities { get; set; }
        /// <summary>Analytics about the view activities that took place on this item.</summary>
        public ItemAnalytics Analytics { get; set; }
        /// <summary>Audio metadata, if the item is an audio file. Read-only. Only on OneDrive Personal.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Audio Audio { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Bundle Bundle { get; set; }
        /// <summary>Collection containing Item objects for the immediate children of Item. Only items representing folders have children. Read-only. Nullable.</summary>
        public List<DriveItem> Children { get; set; }
        /// <summary>The content stream, if the item represents a file.</summary>
        public byte[] Content { get; set; }
        /// <summary>An eTag for the content of the item. This eTag is not changed if only the metadata is changed. Note This property is not returned if the item is a folder. Read-only.</summary>
        public string CTag { get; set; }
        /// <summary>Information about the deleted state of the item. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted Deleted { get; set; }
        /// <summary>File metadata, if the item is a file. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.File File { get; set; }
        /// <summary>File system information on client. Read-write.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.FileSystemInfo FileSystemInfo { get; set; }
        /// <summary>Folder metadata, if the item is a folder. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Folder Folder { get; set; }
        /// <summary>Image metadata, if the item is an image. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Image Image { get; set; }
        /// <summary>For drives in SharePoint, the associated document library list item. Read-only. Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem ListItem { get; set; }
        /// <summary>Location metadata, if the item has location data. Read-only.</summary>
        public GeoCoordinates Location { get; set; }
        /// <summary>Malware metadata, if the item was detected to contain malware. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Malware Malware { get; set; }
        /// <summary>Information about the media (audio or video) item. Read-write. Only on OneDrive for Business and SharePoint.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Media Media { get; set; }
        /// <summary>If present, indicates that this item is a package instead of a folder or file. Packages are treated like files in some contexts and folders in others. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Package Package { get; set; }
        /// <summary>If present, indicates that one or more operations that might affect the state of the driveItem are pending completion. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PendingOperations PendingOperations { get; set; }
        /// <summary>The set of permissions for the item. Read-only. Nullable.</summary>
        public List<Permission> Permissions { get; set; }
        /// <summary>Photo metadata, if the item is a photo. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Photo Photo { get; set; }
        /// <summary>Provides information about the published or checked-out state of an item, in locations that support such actions. This property is not returned by default. Read-only.</summary>
        public PublicationFacet Publication { get; set; }
        /// <summary>Remote item data, if the item is shared from a drive other than the one being accessed. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.RemoteItem RemoteItem { get; set; }
        /// <summary>If this property is non-null, it indicates that the driveItem is the top-most driveItem in the drive.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Root Root { get; set; }
        /// <summary>Search metadata, if the item is from a search result. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SearchResult SearchResult { get; set; }
        /// <summary>Indicates that the item has been shared with others and provides information about the shared state of the item. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Shared Shared { get; set; }
        /// <summary>Returns identifiers useful for SharePoint REST compatibility. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds SharepointIds { get; set; }
        /// <summary>Size of the item in bytes. Read-only.</summary>
        public int? Size { get; set; }
        /// <summary>Information about the drive item source. Read-only. Only on OneDrive for Business and SharePoint.</summary>
        public DriveItemSource Source { get; set; }
        /// <summary>If the current item is also available as a special folder, this facet is returned. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.SpecialFolder SpecialFolder { get; set; }
        /// <summary>The set of subscriptions on the item. Only supported on the root of a drive.</summary>
        public List<Subscription> Subscriptions { get; set; }
        /// <summary>Collection containing [ThumbnailSet][] objects associated with the item. For more info, see [getting thumbnails][]. Read-only. Nullable.</summary>
        public List<ThumbnailSet> Thumbnails { get; set; }
        /// <summary>The list of previous versions of the item. For more info, see [getting previous versions][]. Read-only. Nullable.</summary>
        public List<DriveItemVersion> Versions { get; set; }
        /// <summary>Video metadata, if the item is a video. Read-only.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Video Video { get; set; }
        /// <summary>WebDAV compatible URL for the item.</summary>
        public string WebDavUrl { get; set; }
        /// <summary>For files that are Excel spreadsheets, accesses the workbook API to work with the spreadsheet's contents. Nullable.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Workbook Workbook { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"activities", (o,n) => { (o as DriveItem).Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue).ToList(); } },
                {"analytics", (o,n) => { (o as DriveItem).Analytics = n.GetObjectValue<ItemAnalytics>(ItemAnalytics.CreateFromDiscriminatorValue); } },
                {"audio", (o,n) => { (o as DriveItem).Audio = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Audio>(MicrosoftGraphSdk.Models.Microsoft.Graph.Audio.CreateFromDiscriminatorValue); } },
                {"bundle", (o,n) => { (o as DriveItem).Bundle = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Bundle>(MicrosoftGraphSdk.Models.Microsoft.Graph.Bundle.CreateFromDiscriminatorValue); } },
                {"children", (o,n) => { (o as DriveItem).Children = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"content", (o,n) => { (o as DriveItem).Content = n.GetByteArrayValue(); } },
                {"cTag", (o,n) => { (o as DriveItem).CTag = n.GetStringValue(); } },
                {"deleted", (o,n) => { (o as DriveItem).Deleted = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted>(MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted.CreateFromDiscriminatorValue); } },
                {"file", (o,n) => { (o as DriveItem).File = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.File>(MicrosoftGraphSdk.Models.Microsoft.Graph.File.CreateFromDiscriminatorValue); } },
                {"fileSystemInfo", (o,n) => { (o as DriveItem).FileSystemInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.FileSystemInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.FileSystemInfo.CreateFromDiscriminatorValue); } },
                {"folder", (o,n) => { (o as DriveItem).Folder = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Folder>(MicrosoftGraphSdk.Models.Microsoft.Graph.Folder.CreateFromDiscriminatorValue); } },
                {"image", (o,n) => { (o as DriveItem).Image = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Image>(MicrosoftGraphSdk.Models.Microsoft.Graph.Image.CreateFromDiscriminatorValue); } },
                {"listItem", (o,n) => { (o as DriveItem).ListItem = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem>(MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem.CreateFromDiscriminatorValue); } },
                {"location", (o,n) => { (o as DriveItem).Location = n.GetObjectValue<GeoCoordinates>(GeoCoordinates.CreateFromDiscriminatorValue); } },
                {"malware", (o,n) => { (o as DriveItem).Malware = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Malware>(MicrosoftGraphSdk.Models.Microsoft.Graph.Malware.CreateFromDiscriminatorValue); } },
                {"media", (o,n) => { (o as DriveItem).Media = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Media>(MicrosoftGraphSdk.Models.Microsoft.Graph.Media.CreateFromDiscriminatorValue); } },
                {"package", (o,n) => { (o as DriveItem).Package = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Package>(MicrosoftGraphSdk.Models.Microsoft.Graph.Package.CreateFromDiscriminatorValue); } },
                {"pendingOperations", (o,n) => { (o as DriveItem).PendingOperations = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PendingOperations>(MicrosoftGraphSdk.Models.Microsoft.Graph.PendingOperations.CreateFromDiscriminatorValue); } },
                {"permissions", (o,n) => { (o as DriveItem).Permissions = n.GetCollectionOfObjectValues<Permission>(Permission.CreateFromDiscriminatorValue).ToList(); } },
                {"photo", (o,n) => { (o as DriveItem).Photo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Photo>(MicrosoftGraphSdk.Models.Microsoft.Graph.Photo.CreateFromDiscriminatorValue); } },
                {"publication", (o,n) => { (o as DriveItem).Publication = n.GetObjectValue<PublicationFacet>(PublicationFacet.CreateFromDiscriminatorValue); } },
                {"remoteItem", (o,n) => { (o as DriveItem).RemoteItem = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.RemoteItem>(MicrosoftGraphSdk.Models.Microsoft.Graph.RemoteItem.CreateFromDiscriminatorValue); } },
                {"root", (o,n) => { (o as DriveItem).Root = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Root>(MicrosoftGraphSdk.Models.Microsoft.Graph.Root.CreateFromDiscriminatorValue); } },
                {"searchResult", (o,n) => { (o as DriveItem).SearchResult = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SearchResult>(MicrosoftGraphSdk.Models.Microsoft.Graph.SearchResult.CreateFromDiscriminatorValue); } },
                {"shared", (o,n) => { (o as DriveItem).Shared = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Shared>(MicrosoftGraphSdk.Models.Microsoft.Graph.Shared.CreateFromDiscriminatorValue); } },
                {"sharepointIds", (o,n) => { (o as DriveItem).SharepointIds = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds>(MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds.CreateFromDiscriminatorValue); } },
                {"size", (o,n) => { (o as DriveItem).Size = n.GetIntValue(); } },
                {"source", (o,n) => { (o as DriveItem).Source = n.GetObjectValue<DriveItemSource>(DriveItemSource.CreateFromDiscriminatorValue); } },
                {"specialFolder", (o,n) => { (o as DriveItem).SpecialFolder = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SpecialFolder>(MicrosoftGraphSdk.Models.Microsoft.Graph.SpecialFolder.CreateFromDiscriminatorValue); } },
                {"subscriptions", (o,n) => { (o as DriveItem).Subscriptions = n.GetCollectionOfObjectValues<Subscription>(Subscription.CreateFromDiscriminatorValue).ToList(); } },
                {"thumbnails", (o,n) => { (o as DriveItem).Thumbnails = n.GetCollectionOfObjectValues<ThumbnailSet>(ThumbnailSet.CreateFromDiscriminatorValue).ToList(); } },
                {"versions", (o,n) => { (o as DriveItem).Versions = n.GetCollectionOfObjectValues<DriveItemVersion>(DriveItemVersion.CreateFromDiscriminatorValue).ToList(); } },
                {"video", (o,n) => { (o as DriveItem).Video = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Video>(MicrosoftGraphSdk.Models.Microsoft.Graph.Video.CreateFromDiscriminatorValue); } },
                {"webDavUrl", (o,n) => { (o as DriveItem).WebDavUrl = n.GetStringValue(); } },
                {"workbook", (o,n) => { (o as DriveItem).Workbook = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Workbook>(MicrosoftGraphSdk.Models.Microsoft.Graph.Workbook.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Audio>("audio", Audio);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Bundle>("bundle", Bundle);
            writer.WriteCollectionOfObjectValues<DriveItem>("children", Children);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteStringValue("cTag", CTag);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Deleted>("deleted", Deleted);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.File>("file", File);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.FileSystemInfo>("fileSystemInfo", FileSystemInfo);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Folder>("folder", Folder);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Image>("image", Image);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<GeoCoordinates>("location", Location);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Malware>("malware", Malware);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Media>("media", Media);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Package>("package", Package);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PendingOperations>("pendingOperations", PendingOperations);
            writer.WriteCollectionOfObjectValues<Permission>("permissions", Permissions);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Photo>("photo", Photo);
            writer.WriteObjectValue<PublicationFacet>("publication", Publication);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.RemoteItem>("remoteItem", RemoteItem);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Root>("root", Root);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SearchResult>("searchResult", SearchResult);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Shared>("shared", Shared);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SharepointIds>("sharepointIds", SharepointIds);
            writer.WriteIntValue("size", Size);
            writer.WriteObjectValue<DriveItemSource>("source", Source);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.SpecialFolder>("specialFolder", SpecialFolder);
            writer.WriteCollectionOfObjectValues<Subscription>("subscriptions", Subscriptions);
            writer.WriteCollectionOfObjectValues<ThumbnailSet>("thumbnails", Thumbnails);
            writer.WriteCollectionOfObjectValues<DriveItemVersion>("versions", Versions);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Video>("video", Video);
            writer.WriteStringValue("webDavUrl", WebDavUrl);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Workbook>("workbook", Workbook);
        }
    }
}
