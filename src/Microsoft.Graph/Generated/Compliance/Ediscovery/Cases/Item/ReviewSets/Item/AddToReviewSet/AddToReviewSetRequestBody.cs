using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraph.Models.Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.AddToReviewSet {
    public class AddToReviewSetRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public AdditionalDataOptions? AdditionalDataOptions { get; set; }
        public SourceCollection SourceCollection { get; set; }
        /// <summary>
        /// Instantiates a new addToReviewSetRequestBody and sets the default values.
        /// </summary>
        public AddToReviewSetRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalDataOptions", (o,n) => { (o as AddToReviewSetRequestBody).AdditionalDataOptions = n.GetEnumValue<AdditionalDataOptions>(); } },
                {"sourceCollection", (o,n) => { (o as AddToReviewSetRequestBody).SourceCollection = n.GetObjectValue<SourceCollection>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdditionalDataOptions>("additionalDataOptions", AdditionalDataOptions);
            writer.WriteObjectValue<SourceCollection>("sourceCollection", SourceCollection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
