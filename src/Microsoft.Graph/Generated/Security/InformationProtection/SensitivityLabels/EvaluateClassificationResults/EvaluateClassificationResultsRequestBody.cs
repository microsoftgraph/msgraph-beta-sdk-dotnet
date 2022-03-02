using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Security.InformationProtection.SensitivityLabels.EvaluateClassificationResults {
    public class EvaluateClassificationResultsRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ClassificationResult> ClassificationResults { get; set; }
        public ContentInfo ContentInfo { get; set; }
        /// <summary>
        /// Instantiates a new evaluateClassificationResultsRequestBody and sets the default values.
        /// </summary>
        public EvaluateClassificationResultsRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classificationResults", (o,n) => { (o as EvaluateClassificationResultsRequestBody).ClassificationResults = n.GetCollectionOfObjectValues<ClassificationResult>().ToList(); } },
                {"contentInfo", (o,n) => { (o as EvaluateClassificationResultsRequestBody).ContentInfo = n.GetObjectValue<ContentInfo>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationResult>("classificationResults", ClassificationResults);
            writer.WriteObjectValue<ContentInfo>("contentInfo", ContentInfo);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
