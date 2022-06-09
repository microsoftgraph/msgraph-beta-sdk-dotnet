using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MeetingRegistrant : MeetingRegistrantBase, IParsable {
        /// <summary>The registrant&apos;s answer to custom questions.</summary>
        public List<CustomQuestionAnswer> CustomQuestionAnswers {
            get { return BackingStore?.Get<List<CustomQuestionAnswer>>(nameof(CustomQuestionAnswers)); }
            set { BackingStore?.Set(nameof(CustomQuestionAnswers), value); }
        }
        /// <summary>The email address of the registrant.</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>The first name of the registrant.</summary>
        public string FirstName {
            get { return BackingStore?.Get<string>(nameof(FirstName)); }
            set { BackingStore?.Set(nameof(FirstName), value); }
        }
        /// <summary>The last name of the registrant.</summary>
        public string LastName {
            get { return BackingStore?.Get<string>(nameof(LastName)); }
            set { BackingStore?.Set(nameof(LastName), value); }
        }
        /// <summary>Time in UTC when the registrant registers for the meeting. Read-only.</summary>
        public DateTimeOffset? RegistrationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(RegistrationDateTime)); }
            set { BackingStore?.Set(nameof(RegistrationDateTime), value); }
        }
        /// <summary>The registration status of the registrant. Read-only.</summary>
        public MeetingRegistrantStatus? Status {
            get { return BackingStore?.Get<MeetingRegistrantStatus?>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
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
