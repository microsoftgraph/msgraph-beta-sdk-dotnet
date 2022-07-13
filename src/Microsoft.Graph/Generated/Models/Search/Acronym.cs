using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Search {
    public class Acronym : SearchAnswer, IParsable {
        /// <summary>What the acronym stands for.</summary>
        public string StandsFor {
            get { return BackingStore?.Get<string>("standsFor"); }
            set { BackingStore?.Set("standsFor", value); }
        }
        /// <summary>The state property</summary>
        public AnswerState? State {
            get { return BackingStore?.Get<AnswerState?>("state"); }
            set { BackingStore?.Set("state", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Acronym CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Acronym();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"standsFor", n => { StandsFor = n.GetStringValue(); } },
                {"state", n => { State = n.GetEnumValue<AnswerState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("standsFor", StandsFor);
            writer.WriteEnumValue<AnswerState>("state", State);
        }
    }
}
