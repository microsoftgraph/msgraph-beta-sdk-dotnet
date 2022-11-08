using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EncryptWithTemplate : EncryptContent, IParsable {
        /// <summary>The availableForEncryption property</summary>
        public bool? AvailableForEncryption {
            get { return BackingStore?.Get<bool?>("availableForEncryption"); }
            set { BackingStore?.Set("availableForEncryption", value); }
        }
        /// <summary>The templateId property</summary>
        public string TemplateId {
            get { return BackingStore?.Get<string>("templateId"); }
            set { BackingStore?.Set("templateId", value); }
        }
        /// <summary>
        /// Instantiates a new EncryptWithTemplate and sets the default values.
        /// </summary>
        public EncryptWithTemplate() : base() {
            OdataType = "#microsoft.graph.encryptWithTemplate";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new EncryptWithTemplate CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EncryptWithTemplate();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"availableForEncryption", n => { AvailableForEncryption = n.GetBoolValue(); } },
                {"templateId", n => { TemplateId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("availableForEncryption", AvailableForEncryption);
            writer.WriteStringValue("templateId", TemplateId);
        }
    }
}
