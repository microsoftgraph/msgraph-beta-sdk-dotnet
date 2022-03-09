using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the dataClassificationService singleton.</summary>
    public class ExactMatchJobBase : Entity, IParsable {
        public DateTimeOffset? CompletionDateTime { get; set; }
        public DateTimeOffset? CreationDateTime { get; set; }
        public ClassificationError Error { get; set; }
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchJobBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchJobBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"completionDateTime", (o,n) => { (o as ExactMatchJobBase).CompletionDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationDateTime", (o,n) => { (o as ExactMatchJobBase).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"error", (o,n) => { (o as ExactMatchJobBase).Error = n.GetObjectValue<ClassificationError>(ClassificationError.CreateFromDiscriminatorValue); } },
                {"lastUpdatedDateTime", (o,n) => { (o as ExactMatchJobBase).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"startDateTime", (o,n) => { (o as ExactMatchJobBase).StartDateTime = n.GetDateTimeOffsetValue(); } },
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
