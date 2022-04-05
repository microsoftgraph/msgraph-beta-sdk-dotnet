using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.InformationProtection.DataLossPreventionPolicies.Evaluate {
    /// <summary>Provides operations to call the evaluate method.</summary>
    public class EvaluateRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The evaluationInput property</summary>
        public DlpEvaluationInput EvaluationInput { get; set; }
        /// <summary>The notificationInfo property</summary>
        public DlpNotification NotificationInfo { get; set; }
        /// <summary>The target property</summary>
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new evaluateRequestBody and sets the default values.
        /// </summary>
        public EvaluateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"evaluationInput", (o,n) => { (o as EvaluateRequestBody).EvaluationInput = n.GetObjectValue<DlpEvaluationInput>(DlpEvaluationInput.CreateFromDiscriminatorValue); } },
                {"notificationInfo", (o,n) => { (o as EvaluateRequestBody).NotificationInfo = n.GetObjectValue<DlpNotification>(DlpNotification.CreateFromDiscriminatorValue); } },
                {"target", (o,n) => { (o as EvaluateRequestBody).Target = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<DlpEvaluationInput>("evaluationInput", EvaluationInput);
            writer.WriteObjectValue<DlpNotification>("notificationInfo", NotificationInfo);
            writer.WriteStringValue("target", Target);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
