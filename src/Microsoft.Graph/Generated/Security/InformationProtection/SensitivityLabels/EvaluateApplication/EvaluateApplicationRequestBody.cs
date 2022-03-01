using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Security.InformationProtection.SensitivityLabels.EvaluateApplication {
    public class EvaluateApplicationRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ContentInfo ContentInfo { get; set; }
        public LabelingOptions LabelingOptions { get; set; }
        /// <summary>
        /// Instantiates a new evaluateApplicationRequestBody and sets the default values.
        /// </summary>
        public EvaluateApplicationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentInfo", (o,n) => { (o as EvaluateApplicationRequestBody).ContentInfo = n.GetObjectValue<ContentInfo>(); } },
                {"labelingOptions", (o,n) => { (o as EvaluateApplicationRequestBody).LabelingOptions = n.GetObjectValue<LabelingOptions>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<LabelingOptions>("labelingOptions", LabelingOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
