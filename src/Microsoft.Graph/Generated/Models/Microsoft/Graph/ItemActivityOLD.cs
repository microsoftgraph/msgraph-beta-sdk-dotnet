using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class ItemActivityOLD : Entity, IParsable {
        public ItemActionSet Action { get; set; }
        public IdentitySet Actor { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem DriveItem { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem ListItem { get; set; }
        public ItemActivityTimeSet Times { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemActivityOLD CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemActivityOLD();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"action", (o,n) => { (o as ItemActivityOLD).Action = n.GetObjectValue<ItemActionSet>(ItemActionSet.CreateFromDiscriminatorValue); } },
                {"actor", (o,n) => { (o as ItemActivityOLD).Actor = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"driveItem", (o,n) => { (o as ItemActivityOLD).DriveItem = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem>(MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem.CreateFromDiscriminatorValue); } },
                {"listItem", (o,n) => { (o as ItemActivityOLD).ListItem = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem>(MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem.CreateFromDiscriminatorValue); } },
                {"times", (o,n) => { (o as ItemActivityOLD).Times = n.GetObjectValue<ItemActivityTimeSet>(ItemActivityTimeSet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ItemActionSet>("action", Action);
            writer.WriteObjectValue<IdentitySet>("actor", Actor);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ListItem>("listItem", ListItem);
            writer.WriteObjectValue<ItemActivityTimeSet>("times", Times);
        }
    }
}
