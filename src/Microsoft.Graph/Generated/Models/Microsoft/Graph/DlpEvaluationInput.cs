using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DlpEvaluationInput : IParsable {
        public AccessScope? AccessScope { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public CurrentLabel CurrentLabel { get; set; }
        public List<DiscoveredSensitiveType> DiscoveredSensitiveTypes { get; set; }
        /// <summary>
        /// Instantiates a new dlpEvaluationInput and sets the default values.
        /// </summary>
        public DlpEvaluationInput() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"accessScope", (o,n) => { (o as DlpEvaluationInput).AccessScope = n.GetEnumValue<AccessScope>(); } },
                {"currentLabel", (o,n) => { (o as DlpEvaluationInput).CurrentLabel = n.GetObjectValue<CurrentLabel>(); } },
                {"discoveredSensitiveTypes", (o,n) => { (o as DlpEvaluationInput).DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<DiscoveredSensitiveType>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessScope>("accessScope", AccessScope);
            writer.WriteObjectValue<CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
