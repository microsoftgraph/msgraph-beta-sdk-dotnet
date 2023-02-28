using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlayPromptOperation : CommsOperation, IParsable {
        /// <summary>Possible values are: unknown, completedSuccessfully, mediaOperationCanceled.</summary>
        public PlayPromptCompletionReason? CompletionReason {
            get { return BackingStore?.Get<PlayPromptCompletionReason?>("completionReason"); }
            set { BackingStore?.Set("completionReason", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new PlayPromptOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlayPromptOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completionReason", n => { CompletionReason = n.GetEnumValue<PlayPromptCompletionReason>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<PlayPromptCompletionReason>("completionReason", CompletionReason);
        }
    }
}
