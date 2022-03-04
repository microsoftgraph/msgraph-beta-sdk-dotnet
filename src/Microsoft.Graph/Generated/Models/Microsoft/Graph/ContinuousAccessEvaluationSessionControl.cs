using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ContinuousAccessEvaluationSessionControl : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Specifies continuous access evaluation settings. The possible values are: strictEnforcement, disabled, unknownFutureValue.</summary>
        public ContinuousAccessEvaluationMode? Mode { get; set; }
        /// <summary>
        /// Instantiates a new continuousAccessEvaluationSessionControl and sets the default values.
        /// </summary>
        public ContinuousAccessEvaluationSessionControl() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ContinuousAccessEvaluationSessionControl CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContinuousAccessEvaluationSessionControl();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"mode", (o,n) => { (o as ContinuousAccessEvaluationSessionControl).Mode = n.GetEnumValue<ContinuousAccessEvaluationMode>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ContinuousAccessEvaluationMode>("mode", Mode);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
