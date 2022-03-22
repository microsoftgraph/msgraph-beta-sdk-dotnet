using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Search {
    public class Acronym : SearchAnswer, IParsable {
        /// <summary>What the acronym stands for.</summary>
        public string StandsFor { get; set; }
        /// <summary>State of the acronym. Possible values are: published, draft, excluded, or unknownFutureValue.</summary>
        public AnswerState? State { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"standsFor", (o,n) => { (o as Acronym).StandsFor = n.GetStringValue(); } },
                {"state", (o,n) => { (o as Acronym).State = n.GetEnumValue<AnswerState>(); } },
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
