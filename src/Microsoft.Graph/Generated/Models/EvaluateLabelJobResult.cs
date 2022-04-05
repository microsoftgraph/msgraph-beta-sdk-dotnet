using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class EvaluateLabelJobResult : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The responsiblePolicy property</summary>
        public Microsoft.Graph.Beta.Models.ResponsiblePolicy ResponsiblePolicy { get; set; }
        /// <summary>The responsibleSensitiveTypes property</summary>
        public List<ResponsibleSensitiveType> ResponsibleSensitiveTypes { get; set; }
        /// <summary>The sensitivityLabel property</summary>
        public MatchingLabel SensitivityLabel { get; set; }
        /// <summary>
        /// Instantiates a new evaluateLabelJobResult and sets the default values.
        /// </summary>
        public EvaluateLabelJobResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateLabelJobResult CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateLabelJobResult();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"responsiblePolicy", (o,n) => { (o as EvaluateLabelJobResult).ResponsiblePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.ResponsiblePolicy>(Microsoft.Graph.Beta.Models.ResponsiblePolicy.CreateFromDiscriminatorValue); } },
                {"responsibleSensitiveTypes", (o,n) => { (o as EvaluateLabelJobResult).ResponsibleSensitiveTypes = n.GetCollectionOfObjectValues<ResponsibleSensitiveType>(ResponsibleSensitiveType.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitivityLabel", (o,n) => { (o as EvaluateLabelJobResult).SensitivityLabel = n.GetObjectValue<MatchingLabel>(MatchingLabel.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ResponsiblePolicy>("responsiblePolicy", ResponsiblePolicy);
            writer.WriteCollectionOfObjectValues<ResponsibleSensitiveType>("responsibleSensitiveTypes", ResponsibleSensitiveTypes);
            writer.WriteObjectValue<MatchingLabel>("sensitivityLabel", SensitivityLabel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
