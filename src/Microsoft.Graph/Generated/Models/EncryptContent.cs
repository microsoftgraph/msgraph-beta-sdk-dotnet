using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EncryptContent : LabelActionBase, IParsable {
        /// <summary>The encryptWith property</summary>
        public Microsoft.Graph.Beta.Models.EncryptWith? EncryptWith {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.EncryptWith?>("encryptWith"); }
            set { BackingStore?.Set("encryptWith", value); }
        }
        /// <summary>
        /// Instantiates a new EncryptContent and sets the default values.
        /// </summary>
        public EncryptContent() : base() {
            Type = "#microsoft.graph.encryptContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new EncryptContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.encryptWithTemplate" => new EncryptWithTemplate(),
                "#microsoft.graph.encryptWithUserDefinedRights" => new EncryptWithUserDefinedRights(),
                _ => new EncryptContent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"encryptWith", n => { EncryptWith = n.GetEnumValue<EncryptWith>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<EncryptWith>("encryptWith", EncryptWith);
        }
    }
}
