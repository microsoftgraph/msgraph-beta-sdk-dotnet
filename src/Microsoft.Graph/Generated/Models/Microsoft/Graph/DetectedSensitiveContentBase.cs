using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DetectedSensitiveContentBase : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The confidence property</summary>
        public int? Confidence { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>The recommendedConfidence property</summary>
        public int? RecommendedConfidence { get; set; }
        /// <summary>The uniqueCount property</summary>
        public int? UniqueCount { get; set; }
        /// <summary>
        /// Instantiates a new detectedSensitiveContentBase and sets the default values.
        /// </summary>
        public DetectedSensitiveContentBase() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DetectedSensitiveContentBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DetectedSensitiveContentBase();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"confidence", (o,n) => { (o as DetectedSensitiveContentBase).Confidence = n.GetIntValue(); } },
                {"displayName", (o,n) => { (o as DetectedSensitiveContentBase).DisplayName = n.GetStringValue(); } },
                {"id", (o,n) => { (o as DetectedSensitiveContentBase).Id = n.GetStringValue(); } },
                {"recommendedConfidence", (o,n) => { (o as DetectedSensitiveContentBase).RecommendedConfidence = n.GetIntValue(); } },
                {"uniqueCount", (o,n) => { (o as DetectedSensitiveContentBase).UniqueCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("id", Id);
            writer.WriteIntValue("recommendedConfidence", RecommendedConfidence);
            writer.WriteIntValue("uniqueCount", UniqueCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
