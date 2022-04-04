using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ActionStep : IAdditionalDataHolder, IParsable {
        /// <summary>The actionUrl property</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl ActionUrl { get; set; }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The stepNumber property</summary>
        public long? StepNumber { get; set; }
        /// <summary>The text property</summary>
        public string Text { get; set; }
        /// <summary>
        /// Instantiates a new actionStep and sets the default values.
        /// </summary>
        public ActionStep() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ActionStep CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ActionStep();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"actionUrl", (o,n) => { (o as ActionStep).ActionUrl = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl>(MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl.CreateFromDiscriminatorValue); } },
                {"stepNumber", (o,n) => { (o as ActionStep).StepNumber = n.GetLongValue(); } },
                {"text", (o,n) => { (o as ActionStep).Text = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.ActionUrl>("actionUrl", ActionUrl);
            writer.WriteLongValue("stepNumber", StepNumber);
            writer.WriteStringValue("text", Text);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
