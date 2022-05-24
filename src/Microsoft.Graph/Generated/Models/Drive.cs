using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class Drive : BaseItem, IParsable {
        /// <summary>The list of recent activities that took place under this drive.</summary>
        public List<ItemActivityOLD> Activities {
            get { return BackingStore?.Get<List<ItemActivityOLD>>(nameof(Activities)); }
            set { BackingStore?.Set(nameof(Activities), value); }
        }
        /// <summary>Collection of [bundles][bundle] (albums and multi-select-shared sets of items). Only in personal OneDrive.</summary>
        public List<DriveItem> Bundles {
            get { return BackingStore?.Get<List<DriveItem>>(nameof(Bundles)); }
            set { BackingStore?.Set(nameof(Bundles), value); }
        }
        /// <summary>Describes the type of drive represented by this resource. OneDrive personal drives will return personal. OneDrive for Business will return business. SharePoint document libraries will return documentLibrary. Read-only.</summary>
        public string DriveType {
            get { return BackingStore?.Get<string>(nameof(DriveType)); }
            set { BackingStore?.Set(nameof(DriveType), value); }
        }
        /// <summary>The list of items the user is following. Only in OneDrive for Business.</summary>
        public List<DriveItem> Following {
            get { return BackingStore?.Get<List<DriveItem>>(nameof(Following)); }
            set { BackingStore?.Set(nameof(Following), value); }
        }
        /// <summary>All items contained in the drive. Read-only. Nullable.</summary>
        public List<DriveItem> Items {
            get { return BackingStore?.Get<List<DriveItem>>(nameof(Items)); }
            set { BackingStore?.Set(nameof(Items), value); }
        }
        /// <summary>For drives in SharePoint, the underlying document library list. Read-only. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.List List {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.List>(nameof(List)); }
            set { BackingStore?.Set(nameof(List), value); }
        }
        /// <summary>Optional. The user account that owns the drive. Read-only.</summary>
        public IdentitySet Owner {
            get { return BackingStore?.Get<IdentitySet>(nameof(Owner)); }
            set { BackingStore?.Set(nameof(Owner), value); }
        }
        /// <summary>Optional. Information about the drive&apos;s storage space quota. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.Quota Quota {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Quota>(nameof(Quota)); }
            set { BackingStore?.Set(nameof(Quota), value); }
        }
        /// <summary>The root folder of the drive. Read-only.</summary>
        public DriveItem Root {
            get { return BackingStore?.Get<DriveItem>(nameof(Root)); }
            set { BackingStore?.Set(nameof(Root), value); }
        }
        /// <summary>The sharePointIds property</summary>
        public Microsoft.Graph.Beta.Models.SharepointIds SharePointIds {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharepointIds>(nameof(SharePointIds)); }
            set { BackingStore?.Set(nameof(SharePointIds), value); }
        }
        /// <summary>Collection of common folders available in OneDrive. Read-only. Nullable.</summary>
        public List<DriveItem> Special {
            get { return BackingStore?.Get<List<DriveItem>>(nameof(Special)); }
            set { BackingStore?.Set(nameof(Special), value); }
        }
        /// <summary>If present, indicates that this is a system-managed drive. Read-only.</summary>
        public SystemFacet System {
            get { return BackingStore?.Get<SystemFacet>(nameof(System)); }
            set { BackingStore?.Set(nameof(System), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Drive CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Drive();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activities", n => { Activities = n.GetCollectionOfObjectValues<ItemActivityOLD>(ItemActivityOLD.CreateFromDiscriminatorValue).ToList(); } },
                {"bundles", n => { Bundles = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"driveType", n => { DriveType = n.GetStringValue(); } },
                {"following", n => { Following = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"list", n => { List = n.GetObjectValue<Microsoft.Graph.Beta.Models.List>(Microsoft.Graph.Beta.Models.List.CreateFromDiscriminatorValue); } },
                {"owner", n => { Owner = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"quota", n => { Quota = n.GetObjectValue<Microsoft.Graph.Beta.Models.Quota>(Microsoft.Graph.Beta.Models.Quota.CreateFromDiscriminatorValue); } },
                {"root", n => { Root = n.GetObjectValue<DriveItem>(DriveItem.CreateFromDiscriminatorValue); } },
                {"sharePointIds", n => { SharePointIds = n.GetObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>(Microsoft.Graph.Beta.Models.SharepointIds.CreateFromDiscriminatorValue); } },
                {"special", n => { Special = n.GetCollectionOfObjectValues<DriveItem>(DriveItem.CreateFromDiscriminatorValue).ToList(); } },
                {"system", n => { System = n.GetObjectValue<SystemFacet>(SystemFacet.CreateFromDiscriminatorValue); } },
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
            writer.WriteCollectionOfObjectValues<DriveItem>("bundles", Bundles);
            writer.WriteStringValue("driveType", DriveType);
            writer.WriteCollectionOfObjectValues<DriveItem>("following", Following);
            writer.WriteCollectionOfObjectValues<DriveItem>("items", Items);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.List>("list", List);
            writer.WriteObjectValue<IdentitySet>("owner", Owner);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Quota>("quota", Quota);
            writer.WriteObjectValue<DriveItem>("root", Root);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.SharepointIds>("sharePointIds", SharePointIds);
            writer.WriteCollectionOfObjectValues<DriveItem>("special", Special);
            writer.WriteObjectValue<SystemFacet>("system", System);
        }
    }
}
