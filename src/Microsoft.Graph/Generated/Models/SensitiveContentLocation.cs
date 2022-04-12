using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitiveContentLocation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The confidence property</summary>
        public int? Confidence { get; set; }
        /// <summary>The evidences property</summary>
        public List<SensitiveContentEvidence> Evidences { get; set; }
        /// <summary>The idMatch property</summary>
        public string IdMatch { get; set; }
        /// <summary>The length property</summary>
        public int? Length { get; set; }
        /// <summary>The offset property</summary>
        public int? Offset { get; set; }
        /// <summary>
        /// Instantiates a new sensitiveContentLocation and sets the default values.
        /// </summary>
        public SensitiveContentLocation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SensitiveContentLocation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitiveContentLocation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"evidences", n => { Evidences = n.GetCollectionOfObjectValues<SensitiveContentEvidence>(SensitiveContentEvidence.CreateFromDiscriminatorValue).ToList(); } },
                {"idMatch", n => { IdMatch = n.GetStringValue(); } },
                {"length", n => { Length = n.GetIntValue(); } },
                {"offset", n => { Offset = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<SensitiveContentEvidence>("evidences", Evidences);
            writer.WriteStringValue("idMatch", IdMatch);
            writer.WriteIntValue("length", Length);
            writer.WriteIntValue("offset", Offset);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
