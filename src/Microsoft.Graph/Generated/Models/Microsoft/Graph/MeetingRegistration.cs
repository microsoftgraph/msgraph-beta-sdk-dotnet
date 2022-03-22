using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MeetingRegistration : MeetingRegistrationBase, IParsable {
        /// <summary>Custom registration questions.</summary>
        public List<MeetingRegistrationQuestion> CustomQuestions { get; set; }
        /// <summary>The description of the meeting.</summary>
        public string Description { get; set; }
        /// <summary>The meeting end time in UTC.</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>The number of times the registration page has been visited. Read-only.</summary>
        public int? RegistrationPageViewCount { get; set; }
        /// <summary>The URL of the registration page. Read-only.</summary>
        public string RegistrationPageWebUrl { get; set; }
        /// <summary>The meeting speaker's information.</summary>
        public List<MeetingSpeaker> Speakers { get; set; }
        /// <summary>The meeting start time in UTC.</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>The subject of the meeting.</summary>
        public string Subject { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingRegistration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingRegistration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"customQuestions", (o,n) => { (o as MeetingRegistration).CustomQuestions = n.GetCollectionOfObjectValues<MeetingRegistrationQuestion>(MeetingRegistrationQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"description", (o,n) => { (o as MeetingRegistration).Description = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as MeetingRegistration).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"registrationPageViewCount", (o,n) => { (o as MeetingRegistration).RegistrationPageViewCount = n.GetIntValue(); } },
                {"registrationPageWebUrl", (o,n) => { (o as MeetingRegistration).RegistrationPageWebUrl = n.GetStringValue(); } },
                {"speakers", (o,n) => { (o as MeetingRegistration).Speakers = n.GetCollectionOfObjectValues<MeetingSpeaker>(MeetingSpeaker.CreateFromDiscriminatorValue).ToList(); } },
                {"startDateTime", (o,n) => { (o as MeetingRegistration).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", (o,n) => { (o as MeetingRegistration).Subject = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MeetingRegistrationQuestion>("customQuestions", CustomQuestions);
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteIntValue("registrationPageViewCount", RegistrationPageViewCount);
            writer.WriteStringValue("registrationPageWebUrl", RegistrationPageWebUrl);
            writer.WriteCollectionOfObjectValues<MeetingSpeaker>("speakers", Speakers);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteStringValue("subject", Subject);
        }
    }
}
