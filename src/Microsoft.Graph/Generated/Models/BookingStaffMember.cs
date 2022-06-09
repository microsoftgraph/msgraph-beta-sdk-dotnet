using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class BookingStaffMember : BookingPerson, IParsable {
        /// <summary>True means that if the staff member is a Microsoft 365 user, the Bookings API would verify the staff member&apos;s availability in their personal calendar in Microsoft 365, before making a booking.</summary>
        public bool? AvailabilityIsAffectedByPersonalCalendar {
            get { return BackingStore?.Get<bool?>(nameof(AvailabilityIsAffectedByPersonalCalendar)); }
            set { BackingStore?.Set(nameof(AvailabilityIsAffectedByPersonalCalendar), value); }
        }
        /// <summary>Identifies a color to represent the staff member. The color corresponds to the color palette in the Staff details page in the Bookings app.</summary>
        public int? ColorIndex {
            get { return BackingStore?.Get<int?>(nameof(ColorIndex)); }
            set { BackingStore?.Set(nameof(ColorIndex), value); }
        }
        /// <summary>The isEmailNotificationEnabled property</summary>
        public bool? IsEmailNotificationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsEmailNotificationEnabled)); }
            set { BackingStore?.Set(nameof(IsEmailNotificationEnabled), value); }
        }
        /// <summary>The role of the staff member in the business. Possible values are: guest, administrator, viewer, externalGuest and unknownFutureValue. Required.</summary>
        public BookingStaffRole? Role {
            get { return BackingStore?.Get<BookingStaffRole?>(nameof(Role)); }
            set { BackingStore?.Set(nameof(Role), value); }
        }
        /// <summary>The time zone of the staff member. For a list of possible values, see dateTimeTimeZone.</summary>
        public string TimeZone {
            get { return BackingStore?.Get<string>(nameof(TimeZone)); }
            set { BackingStore?.Set(nameof(TimeZone), value); }
        }
        /// <summary>True means the staff member&apos;s availability is as specified in the businessHours property of the business. False means the availability is determined by the staff member&apos;s workingHours property setting.</summary>
        public bool? UseBusinessHours {
            get { return BackingStore?.Get<bool?>(nameof(UseBusinessHours)); }
            set { BackingStore?.Set(nameof(UseBusinessHours), value); }
        }
        /// <summary>The range of hours each day of the week that the staff member is available for booking. By default, they are initialized to be the same as the businessHours property of the business.</summary>
        public List<BookingWorkHours> WorkingHours {
            get { return BackingStore?.Get<List<BookingWorkHours>>(nameof(WorkingHours)); }
            set { BackingStore?.Set(nameof(WorkingHours), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new BookingStaffMember CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new BookingStaffMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availabilityIsAffectedByPersonalCalendar", n => { AvailabilityIsAffectedByPersonalCalendar = n.GetBoolValue(); } },
                {"colorIndex", n => { ColorIndex = n.GetIntValue(); } },
                {"isEmailNotificationEnabled", n => { IsEmailNotificationEnabled = n.GetBoolValue(); } },
                {"role", n => { Role = n.GetEnumValue<BookingStaffRole>(); } },
                {"timeZone", n => { TimeZone = n.GetStringValue(); } },
                {"useBusinessHours", n => { UseBusinessHours = n.GetBoolValue(); } },
                {"workingHours", n => { WorkingHours = n.GetCollectionOfObjectValues<BookingWorkHours>(BookingWorkHours.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("availabilityIsAffectedByPersonalCalendar", AvailabilityIsAffectedByPersonalCalendar);
            writer.WriteIntValue("colorIndex", ColorIndex);
            writer.WriteBoolValue("isEmailNotificationEnabled", IsEmailNotificationEnabled);
            writer.WriteEnumValue<BookingStaffRole>("role", Role);
            writer.WriteStringValue("timeZone", TimeZone);
            writer.WriteBoolValue("useBusinessHours", UseBusinessHours);
            writer.WriteCollectionOfObjectValues<BookingWorkHours>("workingHours", WorkingHours);
        }
    }
}
