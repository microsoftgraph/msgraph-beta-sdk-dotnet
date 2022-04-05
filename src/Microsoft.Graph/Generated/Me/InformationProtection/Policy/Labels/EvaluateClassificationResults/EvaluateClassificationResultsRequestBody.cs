using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.InformationProtection.Policy.Labels.EvaluateClassificationResults {
    /// <summary>Provides operations to call the evaluateClassificationResults method.</summary>
    public class EvaluateClassificationResultsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The classificationResults property</summary>
        public List<ClassificationResult> ClassificationResults { get; set; }
        /// <summary>The contentInfo property</summary>
        public Microsoft.Graph.Beta.Models.ContentInfo ContentInfo { get; set; }
        /// <summary>
        /// Instantiates a new evaluateClassificationResultsRequestBody and sets the default values.
        /// </summary>
        public EvaluateClassificationResultsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateClassificationResultsRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateClassificationResultsRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classificationResults", (o,n) => { (o as EvaluateClassificationResultsRequestBody).ClassificationResults = n.GetCollectionOfObjectValues<ClassificationResult>(ClassificationResult.CreateFromDiscriminatorValue).ToList(); } },
                {"contentInfo", (o,n) => { (o as EvaluateClassificationResultsRequestBody).ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>(Microsoft.Graph.Beta.Models.ContentInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationResult>("classificationResults", ClassificationResults);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
