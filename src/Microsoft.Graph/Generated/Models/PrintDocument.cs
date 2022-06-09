using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of administrativeUnit entities.</summary>
    public class PrintDocument : Entity, IParsable {
        /// <summary>The configuration property</summary>
        public PrinterDocumentConfiguration Configuration {
            get { return BackingStore?.Get<PrinterDocumentConfiguration>(nameof(Configuration)); }
            set { BackingStore?.Set(nameof(Configuration), value); }
        }
        /// <summary>The document&apos;s content (MIME) type. Read-only.</summary>
        public string ContentType {
            get { return BackingStore?.Get<string>(nameof(ContentType)); }
            set { BackingStore?.Set(nameof(ContentType), value); }
        }
        /// <summary>The document&apos;s name. Read-only.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The document&apos;s size in bytes. Read-only.</summary>
        public long? Size {
            get { return BackingStore?.Get<long?>(nameof(Size)); }
            set { BackingStore?.Set(nameof(Size), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PrintDocument CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PrintDocument();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configuration", n => { Configuration = n.GetObjectValue<PrinterDocumentConfiguration>(PrinterDocumentConfiguration.CreateFromDiscriminatorValue); } },
                {"contentType", n => { ContentType = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"size", n => { Size = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<PrinterDocumentConfiguration>("configuration", Configuration);
            writer.WriteStringValue("contentType", ContentType);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteLongValue("size", Size);
        }
    }
}
