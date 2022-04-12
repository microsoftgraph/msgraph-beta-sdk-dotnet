using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
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
        /// <summary>The meeting speaker&apos;s information.</summary>
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"customQuestions", n => { CustomQuestions = n.GetCollectionOfObjectValues<MeetingRegistrationQuestion>(MeetingRegistrationQuestion.CreateFromDiscriminatorValue).ToList(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"endDateTime", n => { EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"registrationPageViewCount", n => { RegistrationPageViewCount = n.GetIntValue(); } },
                {"registrationPageWebUrl", n => { RegistrationPageWebUrl = n.GetStringValue(); } },
                {"speakers", n => { Speakers = n.GetCollectionOfObjectValues<MeetingSpeaker>(MeetingSpeaker.CreateFromDiscriminatorValue).ToList(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"subject", n => { Subject = n.GetStringValue(); } },
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
