using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    /// <summary>Provides operations to manage the security singleton.</summary>
    public class FileObject : Entity, IParsable {
        /// <summary>The content property</summary>
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>(nameof(Content)); }
            set { BackingStore?.Set(nameof(Content), value); }
        }
        /// <summary>The dateTime property</summary>
        public DateTimeOffset? DateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DateTime)); }
            set { BackingStore?.Set(nameof(DateTime), value); }
        }
        /// <summary>The extension property</summary>
        public string Extension {
            get { return BackingStore?.Get<string>(nameof(Extension)); }
            set { BackingStore?.Set(nameof(Extension), value); }
        }
        /// <summary>The extractedTextContent property</summary>
        public byte[] ExtractedTextContent {
            get { return BackingStore?.Get<byte[]>(nameof(ExtractedTextContent)); }
            set { BackingStore?.Set(nameof(ExtractedTextContent), value); }
        }
        /// <summary>The mediaType property</summary>
        public string MediaType {
            get { return BackingStore?.Get<string>(nameof(MediaType)); }
            set { BackingStore?.Set(nameof(MediaType), value); }
        }
        /// <summary>The name property</summary>
        public string Name {
            get { return BackingStore?.Get<string>(nameof(Name)); }
            set { BackingStore?.Set(nameof(Name), value); }
        }
        /// <summary>The otherProperties property</summary>
        public StringValueDictionary OtherProperties {
            get { return BackingStore?.Get<StringValueDictionary>(nameof(OtherProperties)); }
            set { BackingStore?.Set(nameof(OtherProperties), value); }
        }
        /// <summary>The processingStatus property</summary>
        public FileProcessingStatus? ProcessingStatus {
            get { return BackingStore?.Get<FileProcessingStatus?>(nameof(ProcessingStatus)); }
            set { BackingStore?.Set(nameof(ProcessingStatus), value); }
        }
        /// <summary>The senderOrAuthors property</summary>
        public List<string> SenderOrAuthors {
            get { return BackingStore?.Get<List<string>>(nameof(SenderOrAuthors)); }
            set { BackingStore?.Set(nameof(SenderOrAuthors), value); }
        }
        /// <summary>The size property</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>The sourceType property</summary>
        public Microsoft.Graph.Beta.Models.Security.SourceType? SourceType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.SourceType?>(nameof(SourceType)); }
            set { BackingStore?.Set(nameof(SourceType), value); }
        }
        /// <summary>The subjectTitle property</summary>
        public string SubjectTitle {
            get { return BackingStore?.Get<string>(nameof(SubjectTitle)); }
            set { BackingStore?.Set(nameof(SubjectTitle), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new FileObject CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.security.ediscoveryFile" => new EdiscoveryFile(),
                _ => new FileObject(),
            };
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
