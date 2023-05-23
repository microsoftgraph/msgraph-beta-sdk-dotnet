using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class VirtualEventRegistrationQuestion : Entity, IParsable {
        /// <summary>The answerChoices property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AnswerChoices {
            get { return BackingStore?.Get<List<string>?>("answerChoices"); }
            set { BackingStore?.Set("answerChoices", value); }
        }
#nullable restore
#else
        public List<string> AnswerChoices {
            get { return BackingStore?.Get<List<string>>("answerChoices"); }
            set { BackingStore?.Set("answerChoices", value); }
        }
#endif
        /// <summary>The answerInputType property</summary>
        public VirtualEventRegistrationQuestionAnswerInputType? AnswerInputType {
            get { return BackingStore?.Get<VirtualEventRegistrationQuestionAnswerInputType?>("answerInputType"); }
            set { BackingStore?.Set("answerInputType", value); }
        }
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The isRequired property</summary>
        public bool? IsRequired {
            get { return BackingStore?.Get<bool?>("isRequired"); }
            set { BackingStore?.Set("isRequired", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new VirtualEventRegistrationQuestion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new VirtualEventRegistrationQuestion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"answerChoices", n => { AnswerChoices = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"answerInputType", n => { AnswerInputType = n.GetEnumValue<VirtualEventRegistrationQuestionAnswerInputType>(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"isRequired", n => { IsRequired = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("answerChoices", AnswerChoices);
            writer.WriteEnumValue<VirtualEventRegistrationQuestionAnswerInputType>("answerInputType", AnswerInputType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isRequired", IsRequired);
        }
    }
}
