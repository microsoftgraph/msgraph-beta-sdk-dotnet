using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ItemActivityOLD : Entity, IParsable {
        public ItemActionSet Action { get; set; }
        public IdentitySet Actor { get; set; }
        public DriveItem DriveItem { get; set; }
        public ListItem ListItem { get; set; }
        public ItemActivityTimeSet Times { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"action", (o,n) => { (o as ItemActivityOLD).Action = n.GetObjectValue<ItemActionSet>(); } },
                {"actor", (o,n) => { (o as ItemActivityOLD).Actor = n.GetObjectValue<IdentitySet>(); } },
                {"driveItem", (o,n) => { (o as ItemActivityOLD).DriveItem = n.GetObjectValue<DriveItem>(); } },
                {"listItem", (o,n) => { (o as ItemActivityOLD).ListItem = n.GetObjectValue<ListItem>(); } },
                {"times", (o,n) => { (o as ItemActivityOLD).Times = n.GetObjectValue<ItemActivityTimeSet>(); } },
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
            writer.WriteObjectValue<DriveItem>("driveItem", DriveItem);
            writer.WriteObjectValue<ListItem>("listItem", ListItem);
            writer.WriteObjectValue<ItemActivityTimeSet>("times", Times);
        }
    }
}
