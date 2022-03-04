using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.DataClassification.ClassifyExactMatches {
    public class ClassifyExactMatchesRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public List<ContentClassification> ContentClassifications { get; set; }
        public List<string> SensitiveTypeIds { get; set; }
        public string Text { get; set; }
        public string TimeoutInMs { get; set; }
        /// <summary>
        /// Instantiates a new classifyExactMatchesRequestBody and sets the default values.
        /// </summary>
        public ClassifyExactMatchesRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ClassifyExactMatchesRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ClassifyExactMatchesRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentClassifications", (o,n) => { (o as ClassifyExactMatchesRequestBody).ContentClassifications = n.GetCollectionOfObjectValues<ContentClassification>(ContentClassification.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitiveTypeIds", (o,n) => { (o as ClassifyExactMatchesRequestBody).SensitiveTypeIds = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"text", (o,n) => { (o as ClassifyExactMatchesRequestBody).Text = n.GetStringValue(); } },
                {"timeoutInMs", (o,n) => { (o as ClassifyExactMatchesRequestBody).TimeoutInMs = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ContentClassification>("contentClassifications", ContentClassifications);
            writer.WriteCollectionOfPrimitiveValues<string>("sensitiveTypeIds", SensitiveTypeIds);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("timeoutInMs", TimeoutInMs);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
