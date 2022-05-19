using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingTimeSuggestion : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>An array that shows the availability status of each attendee for this meeting suggestion.</summary>
        public List<Microsoft.Graph.Beta.Models.AttendeeAvailability> AttendeeAvailability {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.AttendeeAvailability>>(nameof(AttendeeAvailability)); }
            set { BackingStore?.Set(nameof(AttendeeAvailability), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>A percentage that represents the likelhood of all the attendees attending.</summary>
        public double? Confidence {
            get { return BackingStore?.Get<double?>(nameof(Confidence)); }
            set { BackingStore?.Set(nameof(Confidence), value); }
        }
        /// <summary>An array that specifies the name and geographic location of each meeting location for this meeting suggestion.</summary>
        public List<Location> Locations {
            get { return BackingStore?.Get<List<Location>>(nameof(Locations)); }
            set { BackingStore?.Set(nameof(Locations), value); }
        }
        /// <summary>A time period suggested for the meeting.</summary>
        public TimeSlot MeetingTimeSlot {
            get { return BackingStore?.Get<TimeSlot>(nameof(MeetingTimeSlot)); }
            set { BackingStore?.Set(nameof(MeetingTimeSlot), value); }
        }
        /// <summary>Order of meeting time suggestions sorted by their computed confidence value from high to low, then by chronology if there are suggestions with the same confidence.</summary>
        public int? Order {
            get { return BackingStore?.Get<int?>(nameof(Order)); }
            set { BackingStore?.Set(nameof(Order), value); }
        }
        /// <summary>Availability of the meeting organizer for this meeting suggestion. Possible values are: free, tentative, busy, oof, workingElsewhere, unknown.</summary>
        public FreeBusyStatus? OrganizerAvailability {
            get { return BackingStore?.Get<FreeBusyStatus?>(nameof(OrganizerAvailability)); }
            set { BackingStore?.Set(nameof(OrganizerAvailability), value); }
        }
        /// <summary>Reason for suggesting the meeting time.</summary>
        public string SuggestionReason {
            get { return BackingStore?.Get<string>(nameof(SuggestionReason)); }
            set { BackingStore?.Set(nameof(SuggestionReason), value); }
        }
        /// <summary>
        /// Instantiates a new meetingTimeSuggestion and sets the default values.
        /// </summary>
        public MeetingTimeSuggestion() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static MeetingTimeSuggestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingTimeSuggestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attendeeAvailability", n => { AttendeeAvailability = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AttendeeAvailability>(Microsoft.Graph.Beta.Models.AttendeeAvailability.CreateFromDiscriminatorValue).ToList(); } },
                {"confidence", n => { Confidence = n.GetDoubleValue(); } },
                {"locations", n => { Locations = n.GetCollectionOfObjectValues<Location>(Location.CreateFromDiscriminatorValue).ToList(); } },
                {"meetingTimeSlot", n => { MeetingTimeSlot = n.GetObjectValue<TimeSlot>(TimeSlot.CreateFromDiscriminatorValue); } },
                {"order", n => { Order = n.GetIntValue(); } },
                {"organizerAvailability", n => { OrganizerAvailability = n.GetEnumValue<FreeBusyStatus>(); } },
                {"suggestionReason", n => { SuggestionReason = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.AttendeeAvailability>("attendeeAvailability", AttendeeAvailability);
            writer.WriteDoubleValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<Location>("locations", Locations);
            writer.WriteObjectValue<TimeSlot>("meetingTimeSlot", MeetingTimeSlot);
            writer.WriteIntValue("order", Order);
            writer.WriteEnumValue<FreeBusyStatus>("organizerAvailability", OrganizerAvailability);
            writer.WriteStringValue("suggestionReason", SuggestionReason);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
