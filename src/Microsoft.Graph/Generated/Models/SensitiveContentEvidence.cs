using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitiveContentEvidence : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The length property</summary>
        public int? Length { get; set; }
        /// <summary>The match property</summary>
        public string Match { get; set; }
        /// <summary>The offset property</summary>
        public int? Offset { get; set; }
        /// <summary>
        /// Instantiates a new sensitiveContentEvidence and sets the default values.
        /// </summary>
        public SensitiveContentEvidence() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SensitiveContentEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveContentEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"length", n => { Length = n.GetIntValue(); } },
                {"match", n => { Match = n.GetStringValue(); } },
                {"offset", n => { Offset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("length", Length);
            writer.WriteStringValue("match", Match);
            writer.WriteIntValue("offset", Offset);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
