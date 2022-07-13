using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the commsApplication singleton.</summary>
    public class MeetingRegistrationQuestion : Entity, IParsable {
        /// <summary>Answer input type of the custom registration question.</summary>
        public Microsoft.Graph.Beta.Models.AnswerInputType? AnswerInputType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AnswerInputType?>("answerInputType"); }
            set { BackingStore?.Set("answerInputType", value); }
        }
        /// <summary>Answer options when answerInputType is radioButton.</summary>
        public List<string> AnswerOptions {
            get { return BackingStore?.Get<List<string>>("answerOptions"); }
            set { BackingStore?.Set("answerOptions", value); }
        }
        /// <summary>Display name of the custom registration question.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Indicates whether the question is required. Default value is false.</summary>
        public bool? IsRequired {
            get { return BackingStore?.Get<bool?>("isRequired"); }
            set { BackingStore?.Set("isRequired", value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"answerInputType", n => { AnswerInputType = n.GetEnumValue<AnswerInputType>(); } },
                {"answerOptions", n => { AnswerOptions = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isRequired", n => { IsRequired = n.GetBoolValue(); } },
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
