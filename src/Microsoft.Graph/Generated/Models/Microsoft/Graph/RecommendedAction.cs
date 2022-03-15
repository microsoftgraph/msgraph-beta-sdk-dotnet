using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the attackSimulation property of the microsoft.graph.security entity.</summary>
    public class RecommendedAction : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RecommendedAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RecommendedAction();
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
