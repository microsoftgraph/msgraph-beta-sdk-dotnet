using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.FindMeetingTimes {
    /// <summary>Provides operations to call the findMeetingTimes method.</summary>
    public class FindMeetingTimesPostRequestBody : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>The attendees property</summary>
        public List<AttendeeBase> Attendees {
            get { return BackingStore?.Get<List<AttendeeBase>>(nameof(Attendees)); }
            set { BackingStore?.Set(nameof(Attendees), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The isOrganizerOptional property</summary>
        public bool? IsOrganizerOptional {
            get { return BackingStore?.Get<bool?>(nameof(IsOrganizerOptional)); }
            set { BackingStore?.Set(nameof(IsOrganizerOptional), value); }
        }
        /// <summary>The locationConstraint property</summary>
        public Microsoft.Graph.Beta.Models.LocationConstraint LocationConstraint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.LocationConstraint>(nameof(LocationConstraint)); }
            set { BackingStore?.Set(nameof(LocationConstraint), value); }
        }
        /// <summary>The maxCandidates property</summary>
        public int? MaxCandidates {
            get { return BackingStore?.Get<int?>(nameof(MaxCandidates)); }
            set { BackingStore?.Set(nameof(MaxCandidates), value); }
        }
        /// <summary>The meetingDuration property</summary>
        public TimeSpan? MeetingDuration {
            get { return BackingStore?.Get<TimeSpan?>(nameof(MeetingDuration)); }
            set { BackingStore?.Set(nameof(MeetingDuration), value); }
        }
        /// <summary>The minimumAttendeePercentage property</summary>
        public double? MinimumAttendeePercentage {
            get { return BackingStore?.Get<double?>(nameof(MinimumAttendeePercentage)); }
            set { BackingStore?.Set(nameof(MinimumAttendeePercentage), value); }
        }
        /// <summary>The returnSuggestionReasons property</summary>
        public bool? ReturnSuggestionReasons {
            get { return BackingStore?.Get<bool?>(nameof(ReturnSuggestionReasons)); }
            set { BackingStore?.Set(nameof(ReturnSuggestionReasons), value); }
        }
        /// <summary>The timeConstraint property</summary>
        public Microsoft.Graph.Beta.Models.TimeConstraint TimeConstraint {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TimeConstraint>(nameof(TimeConstraint)); }
            set { BackingStore?.Set(nameof(TimeConstraint), value); }
        }
        /// <summary>
        /// Instantiates a new findMeetingTimesPostRequestBody and sets the default values.
        /// </summary>
        public FindMeetingTimesPostRequestBody() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FindMeetingTimesPostRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FindMeetingTimesPostRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attendees", n => { Attendees = n.GetCollectionOfObjectValues<AttendeeBase>(AttendeeBase.CreateFromDiscriminatorValue).ToList(); } },
                {"isOrganizerOptional", n => { IsOrganizerOptional = n.GetBoolValue(); } },
                {"locationConstraint", n => { LocationConstraint = n.GetObjectValue<Microsoft.Graph.Beta.Models.LocationConstraint>(Microsoft.Graph.Beta.Models.LocationConstraint.CreateFromDiscriminatorValue); } },
                {"maxCandidates", n => { MaxCandidates = n.GetIntValue(); } },
                {"meetingDuration", n => { MeetingDuration = n.GetTimeSpanValue(); } },
                {"minimumAttendeePercentage", n => { MinimumAttendeePercentage = n.GetDoubleValue(); } },
                {"returnSuggestionReasons", n => { ReturnSuggestionReasons = n.GetBoolValue(); } },
                {"timeConstraint", n => { TimeConstraint = n.GetObjectValue<Microsoft.Graph.Beta.Models.TimeConstraint>(Microsoft.Graph.Beta.Models.TimeConstraint.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttendeeBase>("attendees", Attendees);
            writer.WriteBoolValue("isOrganizerOptional", IsOrganizerOptional);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.LocationConstraint>("locationConstraint", LocationConstraint);
            writer.WriteIntValue("maxCandidates", MaxCandidates);
            writer.WriteTimeSpanValue("meetingDuration", MeetingDuration);
            writer.WriteDoubleValue("minimumAttendeePercentage", MinimumAttendeePercentage);
            writer.WriteBoolValue("returnSuggestionReasons", ReturnSuggestionReasons);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.TimeConstraint>("timeConstraint", TimeConstraint);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
