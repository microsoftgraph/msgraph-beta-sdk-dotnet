using Microsoft.Graph.Beta.Models.Security;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Security.InformationProtection.SensitivityLabels.EvaluateApplication {
    /// <summary>Provides operations to call the evaluateApplication method.</summary>
    public class EvaluateApplicationRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contentInfo property</summary>
        public Microsoft.Graph.Beta.Models.Security.ContentInfo ContentInfo { get; set; }
        /// <summary>The labelingOptions property</summary>
        public Microsoft.Graph.Beta.Models.Security.LabelingOptions LabelingOptions { get; set; }
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"contentInfo", n => { ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.ContentInfo>(Microsoft.Graph.Beta.Models.Security.ContentInfo.CreateFromDiscriminatorValue); } },
                {"labelingOptions", n => { LabelingOptions = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.LabelingOptions>(Microsoft.Graph.Beta.Models.Security.LabelingOptions.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.LabelingOptions>("labelingOptions", LabelingOptions);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
