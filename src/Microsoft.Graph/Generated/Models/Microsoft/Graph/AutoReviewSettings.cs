using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AutoReviewSettings : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values: Approve, Deny, or Recommendation.  If Recommendation, then accessRecommendationsEnabled in the accessReviewSettings resource should also be set to true. If you want to have the system provide a decision even if the reviewer does not make a choice, set the autoReviewEnabled property in the accessReviewSettings resource to true and include an autoReviewSettings object with the notReviewedResult property. Then, when a review completes, based on the notReviewedResult property, the decision is recorded as either Approve or Deny.</summary>
        public string NotReviewedResult { get; set; }
        /// <summary>
        /// Instantiates a new autoReviewSettings and sets the default values.
        /// </summary>
        public AutoReviewSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"notReviewedResult", (o,n) => { (o as AutoReviewSettings).NotReviewedResult = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("notReviewedResult", NotReviewedResult);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
