using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class ItemActivityOLD : Entity, IParsable {
        /// <summary>The action property</summary>
        public ItemActionSet Action {
            get { return BackingStore?.Get<ItemActionSet>("action"); }
            set { BackingStore?.Set("action", value); }
        }
        /// <summary>The actor property</summary>
        public IdentitySet Actor {
            get { return BackingStore?.Get<IdentitySet>("actor"); }
            set { BackingStore?.Set("actor", value); }
        }
        /// <summary>The driveItem property</summary>
        public Microsoft.Graph.Beta.Models.DriveItem DriveItem {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DriveItem>("driveItem"); }
            set { BackingStore?.Set("driveItem", value); }
        }
        /// <summary>The listItem property</summary>
        public Microsoft.Graph.Beta.Models.ListItem ListItem {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ListItem>("listItem"); }
            set { BackingStore?.Set("listItem", value); }
        }
        /// <summary>The times property</summary>
        public ItemActivityTimeSet Times {
            get { return BackingStore?.Get<ItemActivityTimeSet>("times"); }
            set { BackingStore?.Set("times", value); }
        }
        /// <summary>
        /// Instantiates a new itemActivityOLD and sets the default values.
        /// </summary>
        public ItemActivityOLD() : base() {
            OdataType = "#microsoft.graph.itemActivityOLD";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ItemActivityOLD CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityOLD();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"action", n => { Action = n.GetObjectValue<ItemActionSet>(ItemActionSet.CreateFromDiscriminatorValue); } },
                {"actor", n => { Actor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"driveItem", n => { DriveItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.DriveItem>(Microsoft.Graph.Beta.Models.DriveItem.CreateFromDiscriminatorValue); } },
                {"listItem", n => { ListItem = n.GetObjectValue<Microsoft.Graph.Beta.Models.ListItem>(Microsoft.Graph.Beta.Models.ListItem.CreateFromDiscriminatorValue); } },
                {"times", n => { Times = n.GetObjectValue<ItemActivityTimeSet>(ItemActivityTimeSet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemActionSet>("action", Action);
            writer.WriteObjectValue<IdentitySet>("actor", Actor);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<ItemActivityTimeSet>("times", Times);
        }
    }
}
