using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RoomList : Place, IParsable {
        /// <summary>The email address of the room list.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
        /// <summary>The rooms property</summary>
        public List<Room> Rooms {
            get { return BackingStore?.Get<List<Room>>("rooms"); }
            set { BackingStore?.Set("rooms", value); }
        }
        /// <summary>The workspaces property</summary>
        public List<Workspace> Workspaces {
            get { return BackingStore?.Get<List<Workspace>>("workspaces"); }
            set { BackingStore?.Set("workspaces", value); }
        }
        /// <summary>
        /// Instantiates a new RoomList and sets the default values.
        /// </summary>
        public RoomList() : base() {
            OdataType = "#microsoft.graph.roomList";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RoomList CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RoomList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"rooms", n => { Rooms = n.GetCollectionOfObjectValues<Room>(Room.CreateFromDiscriminatorValue)?.ToList(); } },
                {"workspaces", n => { Workspaces = n.GetCollectionOfObjectValues<Workspace>(Workspace.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteCollectionOfObjectValues<Room>("rooms", Rooms);
            writer.WriteCollectionOfObjectValues<Workspace>("workspaces", Workspaces);
        }
    }
}
