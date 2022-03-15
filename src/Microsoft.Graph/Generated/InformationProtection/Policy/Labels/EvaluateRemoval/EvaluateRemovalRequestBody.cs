using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.InformationProtection.Policy.Labels.EvaluateRemoval {
    /// <summary>Provides operations to call the evaluateRemoval method.</summary>
    public class EvaluateRemovalRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo ContentInfo { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DowngradeJustification DowngradeJustification { get; set; }
        /// <summary>
        /// Instantiates a new evaluateRemovalRequestBody and sets the default values.
        /// </summary>
        public EvaluateRemovalRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static EvaluateRemovalRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new EvaluateRemovalRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentInfo", (o,n) => { (o as EvaluateRemovalRequestBody).ContentInfo = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo>(MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo.CreateFromDiscriminatorValue); } },
                {"downgradeJustification", (o,n) => { (o as EvaluateRemovalRequestBody).DowngradeJustification = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DowngradeJustification>(MicrosoftGraphSdk.Models.Microsoft.Graph.DowngradeJustification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
