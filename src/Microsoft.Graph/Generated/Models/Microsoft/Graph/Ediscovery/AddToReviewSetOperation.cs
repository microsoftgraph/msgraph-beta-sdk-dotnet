using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery {
    public class AddToReviewSetOperation : CaseOperation, IParsable {
        /// <summary>The review set to which items matching the source collection query are added to.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.ReviewSet ReviewSet { get; set; }
        /// <summary>The sourceCollection that items are being added from.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection SourceCollection { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AddToReviewSetOperation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddToReviewSetOperation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"reviewSet", (o,n) => { (o as AddToReviewSetOperation).ReviewSet = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.ReviewSet>(MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.ReviewSet.CreateFromDiscriminatorValue); } },
                {"sourceCollection", (o,n) => { (o as AddToReviewSetOperation).SourceCollection = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection>(MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.ReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection>("sourceCollection", SourceCollection);
        }
    }
}
