using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class AttachmentSession : Entity, IParsable {
        /// <summary>The content streams that are uploaded.</summary>
        public byte[] Content {
            get { return BackingStore?.Get<byte[]>("content"); }
            set { BackingStore?.Set("content", value); }
        }
        /// <summary>The date and time in UTC when the upload session will expire. The complete file must be uploaded before this expiration time is reached.</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Indicates a single value {start} that represents the location in the file where the next upload should begin.</summary>
        public List<string> NextExpectedRanges {
            get { return BackingStore?.Get<List<string>>("nextExpectedRanges"); }
            set { BackingStore?.Set("nextExpectedRanges", value); }
        }
        /// <summary>
        /// Instantiates a new attachmentSession and sets the default values.
        /// </summary>
        public AttachmentSession() : base() {
            OdataType = "#microsoft.graph.attachmentSession";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AttachmentSession CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttachmentSession();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"content", n => { Content = n.GetByteArrayValue(); } },
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"nextExpectedRanges", n => { NextExpectedRanges = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("nextExpectedRanges", NextExpectedRanges);
        }
    }
}
