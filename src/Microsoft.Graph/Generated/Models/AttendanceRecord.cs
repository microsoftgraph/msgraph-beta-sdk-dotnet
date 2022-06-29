using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class AttendanceRecord : Entity, IParsable {
        /// <summary>List of time periods between joining and leaving a meeting.</summary>
        public List<AttendanceInterval> AttendanceIntervals {
            get { return BackingStore?.Get<List<AttendanceInterval>>(nameof(AttendanceIntervals)); }
            set { BackingStore?.Set(nameof(AttendanceIntervals), value); }
        }
        /// <summary>Email address of the user associated with this atttendance record.</summary>
        public string EmailAddress {
            get { return BackingStore?.Get<string>(nameof(EmailAddress)); }
            set { BackingStore?.Set(nameof(EmailAddress), value); }
        }
        /// <summary>Identity of the user associated with this atttendance record.</summary>
        public Microsoft.Graph.Beta.Models.Identity Identity {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Identity>(nameof(Identity)); }
            set { BackingStore?.Set(nameof(Identity), value); }
        }
        /// <summary>Unique identifier of a meetingRegistrant. Presents when the participant has registered for the meeting.</summary>
        public string RegistrantId {
            get { return BackingStore?.Get<string>(nameof(RegistrantId)); }
            set { BackingStore?.Set(nameof(RegistrantId), value); }
        }
        /// <summary>Role of the attendee. Possible values are: None, Attendee, Presenter, and Organizer.</summary>
        public string Role {
            get { return BackingStore?.Get<string>(nameof(Role)); }
            set { BackingStore?.Set(nameof(Role), value); }
        }
        /// <summary>Total duration of the attendances in seconds.</summary>
        public int? TotalAttendanceInSeconds {
            get { return BackingStore?.Get<int?>(nameof(TotalAttendanceInSeconds)); }
            set { BackingStore?.Set(nameof(TotalAttendanceInSeconds), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AttendanceRecord CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttendanceRecord();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"attendanceIntervals", n => { AttendanceIntervals = n.GetCollectionOfObjectValues<AttendanceInterval>(AttendanceInterval.CreateFromDiscriminatorValue).ToList(); } },
                {"emailAddress", n => { EmailAddress = n.GetStringValue(); } },
                {"identity", n => { Identity = n.GetObjectValue<Microsoft.Graph.Beta.Models.Identity>(Microsoft.Graph.Beta.Models.Identity.CreateFromDiscriminatorValue); } },
                {"registrantId", n => { RegistrantId = n.GetStringValue(); } },
                {"role", n => { Role = n.GetStringValue(); } },
                {"totalAttendanceInSeconds", n => { TotalAttendanceInSeconds = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AttendanceInterval>("attendanceIntervals", AttendanceIntervals);
            writer.WriteStringValue("emailAddress", EmailAddress);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Identity>("identity", Identity);
            writer.WriteStringValue("registrantId", RegistrantId);
            writer.WriteStringValue("role", Role);
            writer.WriteIntValue("totalAttendanceInSeconds", TotalAttendanceInSeconds);
        }
    }
}
