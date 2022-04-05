using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchJobBase : Entity, IParsable {
        /// <summary>The completionDateTime property</summary>
        public DateTimeOffset? CompletionDateTime { get; set; }
        /// <summary>The creationDateTime property</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        /// <summary>The error property</summary>
        public ClassificationError Error { get; set; }
        /// <summary>The lastUpdatedDateTime property</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>The startDateTime property</summary>
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
