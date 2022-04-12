using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DlpEvaluationInput : IAdditionalDataHolder, IParsable {
        /// <summary>The accessScope property</summary>
        public Microsoft.Graph.Beta.Models.AccessScope? AccessScope { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The currentLabel property</summary>
        public Microsoft.Graph.Beta.Models.CurrentLabel CurrentLabel { get; set; }
        /// <summary>The discoveredSensitiveTypes property</summary>
        public List<DiscoveredSensitiveType> DiscoveredSensitiveTypes { get; set; }
        /// <summary>
        /// Instantiates a new dlpEvaluationInput and sets the default values.
        /// </summary>
        public DlpEvaluationInput() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DlpEvaluationInput CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DlpEvaluationInput();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"accessScope", n => { AccessScope = n.GetEnumValue<AccessScope>(); } },
                {"currentLabel", n => { CurrentLabel = n.GetObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>(Microsoft.Graph.Beta.Models.CurrentLabel.CreateFromDiscriminatorValue); } },
                {"discoveredSensitiveTypes", n => { DiscoveredSensitiveTypes = n.GetCollectionOfObjectValues<DiscoveredSensitiveType>(DiscoveredSensitiveType.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AccessScope>("accessScope", AccessScope);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.CurrentLabel>("currentLabel", CurrentLabel);
            writer.WriteCollectionOfObjectValues<DiscoveredSensitiveType>("discoveredSensitiveTypes", DiscoveredSensitiveTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
