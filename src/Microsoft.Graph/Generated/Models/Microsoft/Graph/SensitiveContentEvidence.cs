using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the classifyExactMatches method.</summary>
    public class SensitiveContentEvidence : IParsable, IAdditionalDataHolder {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? Length { get; set; }
        public string Match { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"length", (o,n) => { (o as SensitiveContentEvidence).Length = n.GetIntValue(); } },
                {"match", (o,n) => { (o as SensitiveContentEvidence).Match = n.GetStringValue(); } },
                {"offset", (o,n) => { (o as SensitiveContentEvidence).Offset = n.GetIntValue(); } },
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
