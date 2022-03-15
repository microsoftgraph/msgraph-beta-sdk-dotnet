using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.InformationProtection.Policy.Labels.EvaluateApplication {
    /// <summary>Provides operations to call the evaluateApplication method.</summary>
    public class EvaluateApplicationRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo ContentInfo { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.LabelingOptions LabelingOptions { get; set; }
        /// <summary>
        /// Instantiates a new evaluateApplicationRequestBody and sets the default values.
        /// </summary>
        public EvaluateApplicationRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateApplicationRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateApplicationRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentInfo", (o,n) => { (o as EvaluateApplicationRequestBody).ContentInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo.CreateFromDiscriminatorValue); } },
                {"labelingOptions", (o,n) => { (o as EvaluateApplicationRequestBody).LabelingOptions = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.LabelingOptions>(MicrosoftGraphSdk.Models.Microsoft.Graph.LabelingOptions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.LabelingOptions>("labelingOptions", LabelingOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
