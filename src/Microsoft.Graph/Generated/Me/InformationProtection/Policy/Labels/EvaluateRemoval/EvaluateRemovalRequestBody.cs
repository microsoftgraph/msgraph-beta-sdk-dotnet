using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Me.InformationProtection.Policy.Labels.EvaluateRemoval {
    /// <summary>Provides operations to call the evaluateRemoval method.</summary>
    public class EvaluateRemovalRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contentInfo property</summary>
        public Microsoft.Graph.Beta.Models.ContentInfo ContentInfo { get; set; }
        /// <summary>The downgradeJustification property</summary>
        public Microsoft.Graph.Beta.Models.DowngradeJustification DowngradeJustification { get; set; }
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
                {"contentInfo", (o,n) => { (o as EvaluateRemovalRequestBody).ContentInfo = n.GetObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>(Microsoft.Graph.Beta.Models.ContentInfo.CreateFromDiscriminatorValue); } },
                {"downgradeJustification", (o,n) => { (o as EvaluateRemovalRequestBody).DowngradeJustification = n.GetObjectValue<Microsoft.Graph.Beta.Models.DowngradeJustification>(Microsoft.Graph.Beta.Models.DowngradeJustification.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ContentInfo>("contentInfo", ContentInfo);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DowngradeJustification>("downgradeJustification", DowngradeJustification);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
