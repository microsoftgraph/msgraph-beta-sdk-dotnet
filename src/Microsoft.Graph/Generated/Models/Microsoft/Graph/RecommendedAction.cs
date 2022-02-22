using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class RecommendedAction : IParsable {
        /// <summary>Web URL to the recommended action.</summary>
        public string ActionWebUrl { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Potential improvement in security score of the tenant from the recommended action.</summary>
        public double? PotentialScoreImpact { get; set; }
        /// <summary>Title of the recommended action.</summary>
        public string Title { get; set; }
        /// <summary>
        /// Instantiates a new recommendedAction and sets the default values.
        /// </summary>
        public RecommendedAction() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionWebUrl", (o,n) => { (o as RecommendedAction).ActionWebUrl = n.GetStringValue(); } },
                {"potentialScoreImpact", (o,n) => { (o as RecommendedAction).PotentialScoreImpact = n.GetDoubleValue(); } },
                {"title", (o,n) => { (o as RecommendedAction).Title = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("actionWebUrl", ActionWebUrl);
            writer.WriteDoubleValue("potentialScoreImpact", PotentialScoreImpact);
            writer.WriteStringValue("title", Title);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
