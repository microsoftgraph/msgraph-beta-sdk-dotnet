using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class File : Entity, IParsable {
        /// <summary>The content property</summary>
        public byte[] Content { get; set; }
        /// <summary>The dateTime property</summary>
        public DateTimeOffset? DateTime { get; set; }
        /// <summary>The extension property</summary>
        public string Extension { get; set; }
        /// <summary>The extractedTextContent property</summary>
        public byte[] ExtractedTextContent { get; set; }
        /// <summary>The mediaType property</summary>
        public string MediaType { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The otherProperties property</summary>
        public StringValueDictionary OtherProperties { get; set; }
        /// <summary>The processingStatus property</summary>
        public FileProcessingStatus? ProcessingStatus { get; set; }
        /// <summary>The senderOrAuthors property</summary>
        public List<string> SenderOrAuthors { get; set; }
        /// <summary>The size property</summary>
        public long? Size { get; set; }
        /// <summary>The sourceType property</summary>
        public Microsoft.Graph.Beta.Models.Security.SourceType? SourceType { get; set; }
        /// <summary>The subjectTitle property</summary>
        public string SubjectTitle { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new File CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new File();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"dateTime", n => { DateTime = n.GetDateTimeOffsetValue(); } },
                {"extension", n => { Extension = n.GetStringValue(); } },
                {"extractedTextContent", n => { ExtractedTextContent = n.GetByteArrayValue(); } },
                {"mediaType", n => { MediaType = n.GetStringValue(); } },
                {"name", n => { Name = n.GetStringValue(); } },
                {"otherProperties", n => { OtherProperties = n.GetObjectValue<StringValueDictionary>(StringValueDictionary.CreateFromDiscriminatorValue); } },
                {"processingStatus", n => { ProcessingStatus = n.GetEnumValue<FileProcessingStatus>(); } },
                {"senderOrAuthors", n => { SenderOrAuthors = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"size", n => { Size = n.GetLongValue(); } },
                {"sourceType", n => { SourceType = n.GetEnumValue<SourceType>(); } },
                {"subjectTitle", n => { SubjectTitle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("content", Content);
            writer.WriteDateTimeOffsetValue("dateTime", DateTime);
            writer.WriteStringValue("extension", Extension);
            writer.WriteByteArrayValue("extractedTextContent", ExtractedTextContent);
            writer.WriteStringValue("mediaType", MediaType);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<StringValueDictionary>("otherProperties", OtherProperties);
            writer.WriteEnumValue<FileProcessingStatus>("processingStatus", ProcessingStatus);
            writer.WriteCollectionOfPrimitiveValues<string>("senderOrAuthors", SenderOrAuthors);
            writer.WriteLongValue("size", Size);
            writer.WriteEnumValue<SourceType>("sourceType", SourceType);
            writer.WriteStringValue("subjectTitle", SubjectTitle);
        }
    }
}
