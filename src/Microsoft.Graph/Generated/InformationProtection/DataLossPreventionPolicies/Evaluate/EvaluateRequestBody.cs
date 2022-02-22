using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.InformationProtection.DataLossPreventionPolicies.Evaluate {
    public class EvaluateRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public DlpEvaluationInput EvaluationInput { get; set; }
        public DlpNotification NotificationInfo { get; set; }
        public string Target { get; set; }
        /// <summary>
        /// Instantiates a new evaluateRequestBody and sets the default values.
        /// </summary>
        public EvaluateRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"evaluationInput", (o,n) => { (o as EvaluateRequestBody).EvaluationInput = n.GetObjectValue<DlpEvaluationInput>(); } },
                {"notificationInfo", (o,n) => { (o as EvaluateRequestBody).NotificationInfo = n.GetObjectValue<DlpNotification>(); } },
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
