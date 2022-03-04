using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ExactMatchClassificationResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ExactMatchDetectedSensitiveContent> Classification { get; set; }
        public List<ClassificationError> Errors { get; set; }
        /// <summary>
        /// Instantiates a new exactMatchClassificationResult and sets the default values.
        /// </summary>
        public ExactMatchClassificationResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ExactMatchClassificationResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchClassificationResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classification", (o,n) => { (o as ExactMatchClassificationResult).Classification = n.GetCollectionOfObjectValues<ExactMatchDetectedSensitiveContent>(ExactMatchDetectedSensitiveContent.CreateFromDiscriminatorValue).ToList(); } },
                {"errors", (o,n) => { (o as ExactMatchClassificationResult).Errors = n.GetCollectionOfObjectValues<ClassificationError>(ClassificationError.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ExactMatchDetectedSensitiveContent>("classification", Classification);
            writer.WriteCollectionOfObjectValues<ClassificationError>("errors", Errors);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
