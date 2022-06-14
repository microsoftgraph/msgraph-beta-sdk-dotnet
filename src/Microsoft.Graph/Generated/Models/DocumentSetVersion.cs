using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DocumentSetVersion : ListItemVersion, IParsable {
        /// <summary>Comment about the captured version.</summary>
        public string Comment {
            get { return BackingStore?.Get<string>(nameof(Comment)); }
            set { BackingStore?.Set(nameof(Comment), value); }
        }
        /// <summary>User who captured the version.</summary>
        public IdentitySet CreatedBy {
            get { return BackingStore?.Get<IdentitySet>(nameof(CreatedBy)); }
            set { BackingStore?.Set(nameof(CreatedBy), value); }
        }
        /// <summary>Date and time when this version was created.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Items within the document set that are captured as part of this version.</summary>
        public List<DocumentSetVersionItem> Items {
            get { return BackingStore?.Get<List<DocumentSetVersionItem>>(nameof(Items)); }
            set { BackingStore?.Set(nameof(Items), value); }
        }
        /// <summary>If true, minor versions of items are also captured; otherwise, only major versions will be captured. Default value is false.</summary>
        public bool? ShouldCaptureMinorVersion {
            get { return BackingStore?.Get<bool?>(nameof(ShouldCaptureMinorVersion)); }
            set { BackingStore?.Set(nameof(ShouldCaptureMinorVersion), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DocumentSetVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DocumentSetVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"comment", n => { Comment = n.GetStringValue(); } },
                {"createdBy", n => { CreatedBy = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"items", n => { Items = n.GetCollectionOfObjectValues<DocumentSetVersionItem>(DocumentSetVersionItem.CreateFromDiscriminatorValue).ToList(); } },
                {"shouldCaptureMinorVersion", n => { ShouldCaptureMinorVersion = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("comment", Comment);
            writer.WriteObjectValue<IdentitySet>("createdBy", CreatedBy);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteCollectionOfObjectValues<DocumentSetVersionItem>("items", Items);
            writer.WriteBoolValue("shouldCaptureMinorVersion", ShouldCaptureMinorVersion);
        }
    }
}
