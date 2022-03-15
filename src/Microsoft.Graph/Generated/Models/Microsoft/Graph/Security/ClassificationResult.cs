using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    /// <summary>Provides operations to call the evaluateClassificationResults method.</summary>
    public class ClassificationResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? ConfidenceLevel { get; set; }
        public int? Count { get; set; }
        public string SensitiveTypeId { get; set; }
        /// <summary>
        /// Instantiates a new classificationResult and sets the default values.
        /// </summary>
        public ClassificationResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassificationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassificationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"confidenceLevel", (o,n) => { (o as ClassificationResult).ConfidenceLevel = n.GetIntValue(); } },
                {"count", (o,n) => { (o as ClassificationResult).Count = n.GetIntValue(); } },
                {"sensitiveTypeId", (o,n) => { (o as ClassificationResult).SensitiveTypeId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidenceLevel", ConfidenceLevel);
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("sensitiveTypeId", SensitiveTypeId);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
