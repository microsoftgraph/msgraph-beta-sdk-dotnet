using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class ExactMatchJobBase : Entity, IParsable {
        /// <summary>The completionDateTime property</summary>
        public DateTimeOffset? CompletionDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("completionDateTime"); }
            set { BackingStore?.Set("completionDateTime", value); }
        }
        /// <summary>The creationDateTime property</summary>
        public DateTimeOffset? CreationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("creationDateTime"); }
            set { BackingStore?.Set("creationDateTime", value); }
        }
        /// <summary>The error property</summary>
        public ClassificationError Error {
            get { return BackingStore?.Get<ClassificationError>("error"); }
            set { BackingStore?.Set("error", value); }
        }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>The startDateTime property</summary>
        public DateTimeOffset? StartDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("startDateTime"); }
            set { BackingStore?.Set("startDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new exactMatchJobBase and sets the default values.
        /// </summary>
        public ExactMatchJobBase() : base() {
            OdataType = "#microsoft.graph.exactMatchJobBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchJobBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.exactMatchLookupJob" => new ExactMatchLookupJob(),
                "#microsoft.graph.exactMatchSession" => new ExactMatchSession(),
                "#microsoft.graph.exactMatchSessionBase" => new ExactMatchSessionBase(),
                _ => new ExactMatchJobBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"completionDateTime", n => { CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationDateTime", n => { CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", n => { Error = n.GetObjectValue<ClassificationError>(ClassificationError.CreateFromDiscriminatorValue); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"startDateTime", n => { StartDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("completionDateTime", CompletionDateTime);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<ClassificationError>("error", Error);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
        }
    }
}
