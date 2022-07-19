using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingRegistrant : MeetingRegistrantBase, IParsable {
        /// <summary>The registrant&apos;s answer to custom questions.</summary>
        public List<CustomQuestionAnswer> CustomQuestionAnswers {
            get { return BackingStore?.Get<List<CustomQuestionAnswer>>("customQuestionAnswers"); }
            set { BackingStore?.Set("customQuestionAnswers", value); }
        }
        /// <summary>The email address of the registrant.</summary>
        public string Email {
            get { return BackingStore?.Get<string>("email"); }
            set { BackingStore?.Set("email", value); }
        }
        /// <summary>The first name of the registrant.</summary>
        public string FirstName {
            get { return BackingStore?.Get<string>("firstName"); }
            set { BackingStore?.Set("firstName", value); }
        }
        /// <summary>The last name of the registrant.</summary>
        public string LastName {
            get { return BackingStore?.Get<string>("lastName"); }
            set { BackingStore?.Set("lastName", value); }
        }
        /// <summary>Time in UTC when the registrant registers for the meeting. Read-only.</summary>
        public DateTimeOffset? RegistrationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("registrationDateTime"); }
            set { BackingStore?.Set("registrationDateTime", value); }
        }
        /// <summary>The registration status of the registrant. Read-only.</summary>
        public MeetingRegistrantStatus? Status {
            get { return BackingStore?.Get<MeetingRegistrantStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Instantiates a new MeetingRegistrant and sets the default values.
        /// </summary>
        public MeetingRegistrant() : base() {
            OdataType = "#microsoft.graph.meetingRegistrant";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingRegistrant CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingRegistrant();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customQuestionAnswers", n => { CustomQuestionAnswers = n.GetCollectionOfObjectValues<CustomQuestionAnswer>(CustomQuestionAnswer.CreateFromDiscriminatorValue).ToList(); } },
                {"email", n => { Email = n.GetStringValue(); } },
                {"firstName", n => { FirstName = n.GetStringValue(); } },
                {"lastName", n => { LastName = n.GetStringValue(); } },
                {"registrationDateTime", n => { RegistrationDateTime = n.GetDateTimeOffsetValue(); } },
                {"status", n => { Status = n.GetEnumValue<MeetingRegistrantStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<CustomQuestionAnswer>("customQuestionAnswers", CustomQuestionAnswers);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("firstName", FirstName);
            writer.WriteStringValue("lastName", LastName);
            writer.WriteDateTimeOffsetValue("registrationDateTime", RegistrationDateTime);
            writer.WriteEnumValue<MeetingRegistrantStatus>("status", Status);
        }
    }
}
