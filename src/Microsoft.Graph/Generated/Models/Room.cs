using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Room : Place, IParsable {
        /// <summary>Specifies the name of the audio device in the room.</summary>
        public string AudioDeviceName {
            get { return BackingStore?.Get<string>(nameof(AudioDeviceName)); }
            set { BackingStore?.Set(nameof(AudioDeviceName), value); }
        }
        /// <summary>Type of room. Possible values are standard, and reserved.</summary>
        public Microsoft.Graph.Beta.Models.BookingType? BookingType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.BookingType?>(nameof(BookingType)); }
            set { BackingStore?.Set(nameof(BookingType), value); }
        }
        /// <summary>Specifies the building name or building number that the room is in.</summary>
        public string Building {
            get { return BackingStore?.Get<string>(nameof(Building)); }
            set { BackingStore?.Set(nameof(Building), value); }
        }
        /// <summary>Specifies the capacity of the room.</summary>
        public int? Capacity {
            get { return BackingStore?.Get<int?>(nameof(Capacity)); }
            set { BackingStore?.Set(nameof(Capacity), value); }
        }
        /// <summary>Specifies the name of the display device in the room.</summary>
        public string DisplayDeviceName {
            get { return BackingStore?.Get<string>(nameof(DisplayDeviceName)); }
            set { BackingStore?.Set(nameof(DisplayDeviceName), value); }
        }
        /// <summary>Email address of the room.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>(nameof(EmailAddress)); }
            set { BackingStore?.Set(nameof(EmailAddress), value); }
        }
        /// <summary>Specifies a descriptive label for the floor, for example, P.</summary>
        public string FloorLabel {
            get { return BackingStore?.Get<string>(nameof(FloorLabel)); }
            set { BackingStore?.Set(nameof(FloorLabel), value); }
        }
        /// <summary>Specifies the floor number that the room is on.</summary>
        public int? FloorNumber {
            get { return BackingStore?.Get<int?>(nameof(FloorNumber)); }
            set { BackingStore?.Set(nameof(FloorNumber), value); }
        }
        /// <summary>Specifies whether the room is wheelchair accessible.</summary>
        public bool? IsWheelChairAccessible {
            get { return BackingStore?.Get<bool?>(nameof(IsWheelChairAccessible)); }
            set { BackingStore?.Set(nameof(IsWheelChairAccessible), value); }
        }
        /// <summary>Specifies a descriptive label for the room, for example, a number or name.</summary>
        public string Label {
            get { return BackingStore?.Get<string>(nameof(Label)); }
            set { BackingStore?.Set(nameof(Label), value); }
        }
        /// <summary>Specifies a nickname for the room, for example, &apos;conf room&apos;.</summary>
        public string Nickname {
            get { return BackingStore?.Get<string>(nameof(Nickname)); }
            set { BackingStore?.Set(nameof(Nickname), value); }
        }
        /// <summary>Specifies additional features of the room, for example, details like the type of view or furniture type.</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>Specifies the name of the video device in the room.</summary>
        public string VideoDeviceName {
            get { return BackingStore?.Get<string>(nameof(VideoDeviceName)); }
            set { BackingStore?.Set(nameof(VideoDeviceName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Room CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Room();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"audioDeviceName", n => { AudioDeviceName = n.GetStringValue(); } },
                {"bookingType", n => { BookingType = n.GetEnumValue<BookingType>(); } },
                {"building", n => { Building = n.GetStringValue(); } },
                {"capacity", n => { Capacity = n.GetIntValue(); } },
                {"displayDeviceName", n => { DisplayDeviceName = n.GetStringValue(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"floorLabel", n => { FloorLabel = n.GetStringValue(); } },
                {"floorNumber", n => { FloorNumber = n.GetIntValue(); } },
                {"isWheelChairAccessible", n => { IsWheelChairAccessible = n.GetBoolValue(); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"nickname", n => { Nickname = n.GetStringValue(); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"videoDeviceName", n => { VideoDeviceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("audioDeviceName", AudioDeviceName);
            writer.WriteEnumValue<BookingType>("bookingType", BookingType);
            writer.WriteStringValue("building", Building);
            writer.WriteIntValue("capacity", Capacity);
            writer.WriteStringValue("displayDeviceName", DisplayDeviceName);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteStringValue("floorLabel", FloorLabel);
            writer.WriteIntValue("floorNumber", FloorNumber);
            writer.WriteBoolValue("isWheelChairAccessible", IsWheelChairAccessible);
            writer.WriteStringValue("label", Label);
            writer.WriteStringValue("nickname", Nickname);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("videoDeviceName", VideoDeviceName);
        }
    }
}
