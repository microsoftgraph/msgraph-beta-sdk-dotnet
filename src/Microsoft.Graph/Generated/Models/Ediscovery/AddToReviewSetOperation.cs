using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Ediscovery {
    public class AddToReviewSetOperation : CaseOperation, IParsable {
        /// <summary>The review set to which items matching the source collection query are added to.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet ReviewSet {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet>(nameof(ReviewSet)); }
            set { BackingStore?.Set(nameof(ReviewSet), value); }
        }
        /// <summary>The sourceCollection that items are being added from.</summary>
        public Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection SourceCollection {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>(nameof(SourceCollection)); }
            set { BackingStore?.Set(nameof(SourceCollection), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"reviewSet", n => { ReviewSet = n.GetObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet>(Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet.CreateFromDiscriminatorValue); } },
                {"sourceCollection", n => { SourceCollection = n.GetObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>(Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.ReviewSet>("reviewSet", ReviewSet);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Ediscovery.SourceCollection>("sourceCollection", SourceCollection);
        }
    }
}
