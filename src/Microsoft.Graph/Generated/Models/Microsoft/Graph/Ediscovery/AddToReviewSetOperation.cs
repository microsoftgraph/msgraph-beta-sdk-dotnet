using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class AddToReviewSetOperation : CaseOperation, IParsable {
        /// <summary>The review set to which items matching the source collection query are added to.</summary>
        public ReviewSet ReviewSet { get; set; }
        /// <summary>The sourceCollection that items are being added from.</summary>
        public SourceCollection SourceCollection { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"reviewSet", (o,n) => { (o as AddToReviewSetOperation).ReviewSet = n.GetObjectValue<ReviewSet>(); } },
                {"sourceCollection", (o,n) => { (o as AddToReviewSetOperation).SourceCollection = n.GetObjectValue<SourceCollection>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<SourceCollection>("sourceCollection", SourceCollection);
        }
    }
}
