using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class DispositionReviewStage : Entity, IParsable {
        /// <summary>Name representing each stage within a collection.</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>A collection of reviewers at each stage.</summary>
        public List<string> ReviewersEmailAddresses {
            get { return BackingStore?.Get<List<string>>(nameof(ReviewersEmailAddresses)); }
            set { BackingStore?.Set(nameof(ReviewersEmailAddresses), value); }
        }
        /// <summary>The sequence number for each stage of the disposition review.</summary>
        public int? StageNumber {
            get { return BackingStore?.Get<int?>(nameof(StageNumber)); }
            set { BackingStore?.Set(nameof(StageNumber), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DispositionReviewStage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DispositionReviewStage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"name", n => { Name = n.GetStringValue(); } },
                {"reviewersEmailAddresses", n => { ReviewersEmailAddresses = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"stageNumber", n => { StageNumber = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("name", Name);
            writer.WriteCollectionOfPrimitiveValues<string>("reviewersEmailAddresses", ReviewersEmailAddresses);
            writer.WriteIntValue("stageNumber", StageNumber);
        }
    }
}
