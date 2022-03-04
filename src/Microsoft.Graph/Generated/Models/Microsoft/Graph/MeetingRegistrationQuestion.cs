using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class MeetingRegistrationQuestion : Entity, IParsable {
        /// <summary>Answer input type of the custom registration question.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.AnswerInputType? AnswerInputType { get; set; }
        /// <summary>Answer options when answerInputType is radioButton.</summary>
        public List<string> AnswerOptions { get; set; }
        /// <summary>Display name of the custom registration question.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the question is required. Default value is false.</summary>
        public bool? IsRequired { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MeetingRegistrationQuestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MeetingRegistrationQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"answerInputType", (o,n) => { (o as MeetingRegistrationQuestion).AnswerInputType = n.GetEnumValue<AnswerInputType>(); } },
                {"answerOptions", (o,n) => { (o as MeetingRegistrationQuestion).AnswerOptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayName", (o,n) => { (o as MeetingRegistrationQuestion).DisplayName = n.GetStringValue(); } },
                {"isRequired", (o,n) => { (o as MeetingRegistrationQuestion).IsRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<AnswerInputType>("answerInputType", AnswerInputType);
            writer.WriteCollectionOfPrimitiveValues<string>("answerOptions", AnswerOptions);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isRequired", IsRequired);
        }
    }
}
