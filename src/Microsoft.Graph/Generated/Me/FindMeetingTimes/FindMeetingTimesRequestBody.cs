using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.FindMeetingTimes {
    /// <summary>Provides operations to call the findMeetingTimes method.</summary>
    public class FindMeetingTimesRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The attendees property</summary>
        public List<AttendeeBase> Attendees { get; set; }
        /// <summary>The isOrganizerOptional property</summary>
        public bool? IsOrganizerOptional { get; set; }
        /// <summary>The locationConstraint property</summary>
        public Microsoft.Graph.Beta.Models.LocationConstraint LocationConstraint { get; set; }
        /// <summary>The maxCandidates property</summary>
        public int? MaxCandidates { get; set; }
        /// <summary>The meetingDuration property</summary>
        public TimeSpan? MeetingDuration { get; set; }
        /// <summary>The minimumAttendeePercentage property</summary>
        public double? MinimumAttendeePercentage { get; set; }
        /// <summary>The returnSuggestionReasons property</summary>
        public bool? ReturnSuggestionReasons { get; set; }
        /// <summary>The timeConstraint property</summary>
        public Microsoft.Graph.Beta.Models.TimeConstraint TimeConstraint { get; set; }
        /// <summary>
        /// Instantiates a new findMeetingTimesRequestBody and sets the default values.
        /// </summary>
        public FindMeetingTimesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static FindMeetingTimesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new FindMeetingTimesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"attendees", (o,n) => { (o as FindMeetingTimesRequestBody).Attendees = n.GetCollectionOfObjectValues<AttendeeBase>(AttendeeBase.CreateFromDiscriminatorValue).ToList(); } },
                {"isOrganizerOptional", (o,n) => { (o as FindMeetingTimesRequestBody).IsOrganizerOptional = n.GetBoolValue(); } },
                {"locationConstraint", (o,n) => { (o as FindMeetingTimesRequestBody).LocationConstraint = n.GetObjectValue<Microsoft.Graph.Beta.Models.LocationConstraint>(Microsoft.Graph.Beta.Models.LocationConstraint.CreateFromDiscriminatorValue); } },
                {"maxCandidates", (o,n) => { (o as FindMeetingTimesRequestBody).MaxCandidates = n.GetIntValue(); } },
                {"meetingDuration", (o,n) => { (o as FindMeetingTimesRequestBody).MeetingDuration = n.GetTimeSpanValue(); } },
                {"minimumAttendeePercentage", (o,n) => { (o as FindMeetingTimesRequestBody).MinimumAttendeePercentage = n.GetDoubleValue(); } },
                {"returnSuggestionReasons", (o,n) => { (o as FindMeetingTimesRequestBody).ReturnSuggestionReasons = n.GetBoolValue(); } },
                {"timeConstraint", (o,n) => { (o as FindMeetingTimesRequestBody).TimeConstraint = n.GetObjectValue<Microsoft.Graph.Beta.Models.TimeConstraint>(Microsoft.Graph.Beta.Models.TimeConstraint.CreateFromDiscriminatorValue); } },
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
