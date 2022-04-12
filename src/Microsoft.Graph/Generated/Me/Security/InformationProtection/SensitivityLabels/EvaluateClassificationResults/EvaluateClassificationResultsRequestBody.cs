using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.Security.InformationProtection.SensitivityLabels.EvaluateClassificationResults {
    /// <summary>Provides operations to call the evaluateClassificationResults method.</summary>
    public class EvaluateClassificationResultsRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The classificationResults property</summary>
        public List<ClassificationResult> ClassificationResults { get; set; }
        /// <summary>The contentInfo property</summary>
        public Microsoft.Graph.Beta.Models.Security.ContentInfo ContentInfo { get; set; }
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"classificationResults", n => { ClassificationResults = n.GetCollectionOfObjectValues<ClassificationResult>(ClassificationResult.CreateFromDiscriminatorValue).ToList(); } },
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.ContentInfo>(Microsoft.Graph.Beta.Models.Security.ContentInfo.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationResult>("classificationResults", ClassificationResults);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
