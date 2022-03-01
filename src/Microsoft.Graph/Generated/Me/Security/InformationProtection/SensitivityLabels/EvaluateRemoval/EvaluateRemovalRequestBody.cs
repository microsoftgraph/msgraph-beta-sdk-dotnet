using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Security;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.Security.InformationProtection.SensitivityLabels.EvaluateRemoval {
    public class EvaluateRemovalRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public ContentInfo ContentInfo { get; set; }
        public DowngradeJustification DowngradeJustification { get; set; }
        /// <summary>
        /// Instantiates a new evaluateRemovalRequestBody and sets the default values.
        /// </summary>
        public EvaluateRemovalRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentInfo", (o,n) => { (o as EvaluateRemovalRequestBody).ContentInfo = n.GetObjectValue<ContentInfo>(); } },
                {"downgradeJustification", (o,n) => { (o as EvaluateRemovalRequestBody).DowngradeJustification = n.GetObjectValue<DowngradeJustification>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
