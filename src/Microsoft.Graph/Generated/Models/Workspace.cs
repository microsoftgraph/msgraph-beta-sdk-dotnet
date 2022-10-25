using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class Workspace : Place, IParsable {
        /// <summary>Specifies the building name or building number that the workspace is in.</summary>
        public string Building {
            get { return BackingStore?.Get<string>("building"); }
            set { BackingStore?.Set("building", value); }
        }
        /// <summary>Specifies the capacity of the workspace.</summary>
        public int? Capacity {
            get { return BackingStore?.Get<int?>("capacity"); }
            set { BackingStore?.Set("capacity", value); }
        }
        /// <summary>Email address of the workspace.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>("emailAddress"); }
            set { BackingStore?.Set("emailAddress", value); }
        }
        /// <summary>Specifies a descriptive label for the floor, for example, P.</summary>
        public string FloorLabel {
            get { return BackingStore?.Get<string>("floorLabel"); }
            set { BackingStore?.Set("floorLabel", value); }
        }
        /// <summary>Specifies the floor number that the workspace is on.</summary>
        public int? FloorNumber {
            get { return BackingStore?.Get<int?>("floorNumber"); }
            set { BackingStore?.Set("floorNumber", value); }
        }
        /// <summary>Specifies whether the workspace is wheelchair accessible.</summary>
        public bool? IsWheelChairAccessible {
            get { return BackingStore?.Get<bool?>("isWheelChairAccessible"); }
            set { BackingStore?.Set("isWheelChairAccessible", value); }
        }
        /// <summary>Specifies a descriptive label for the workspace, for example, a number or name.</summary>
        public string Label {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
        /// <summary>Specifies a nickname for the workspace, for example, &apos;quiet workspace&apos;.</summary>
        public string Nickname {
            get { return BackingStore?.Get<string>("nickname"); }
            set { BackingStore?.Set("nickname", value); }
        }
        /// <summary>Specifies additional features of the workspace, for example, details like the type of view or furniture type.</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>("tags"); }
            set { BackingStore?.Set("tags", value); }
        }
        /// <summary>
        /// Instantiates a new workspace and sets the default values.
        /// </summary>
        public Workspace() : base() {
            OdataType = "#microsoft.graph.workspace";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Workspace CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Workspace();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"building", n => { Building = n.GetStringValue(); } },
                {"capacity", n => { Capacity = n.GetIntValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"floorLabel", n => { FloorLabel = n.GetStringValue(); } },
                {"floorNumber", n => { FloorNumber = n.GetIntValue(); } },
                {"isWheelChairAccessible", n => { IsWheelChairAccessible = n.GetBoolValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"nickname", n => { Nickname = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("building", Building);
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteStringValue("floorLabel", FloorLabel);
            writer.WriteIntValue("floorNumber", FloorNumber);
            writer.WriteBoolValue("isWheelChairAccessible", IsWheelChairAccessible);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
        }
    }
}
