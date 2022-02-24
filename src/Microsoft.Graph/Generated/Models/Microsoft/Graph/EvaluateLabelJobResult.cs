using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class EvaluateLabelJobResult : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ResponsiblePolicy ResponsiblePolicy { get; set; }
        public List<ResponsibleSensitiveType> ResponsibleSensitiveTypes { get; set; }
        public MatchingLabel SensitivityLabel { get; set; }
        /// <summary>
        /// Instantiates a new evaluateLabelJobResult and sets the default values.
        /// </summary>
        public EvaluateLabelJobResult() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"responsiblePolicy", (o,n) => { (o as EvaluateLabelJobResult).ResponsiblePolicy = n.GetObjectValue<ResponsiblePolicy>(); } },
                {"responsibleSensitiveTypes", (o,n) => { (o as EvaluateLabelJobResult).ResponsibleSensitiveTypes = n.GetCollectionOfObjectValues<ResponsibleSensitiveType>().ToList(); } },
                {"sensitivityLabel", (o,n) => { (o as EvaluateLabelJobResult).SensitivityLabel = n.GetObjectValue<MatchingLabel>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ResponsiblePolicy>("responsiblePolicy", ResponsiblePolicy);
            writer.WriteCollectionOfObjectValues<ResponsibleSensitiveType>("responsibleSensitiveTypes", ResponsibleSensitiveTypes);
            writer.WriteObjectValue<MatchingLabel>("sensitivityLabel", SensitivityLabel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
