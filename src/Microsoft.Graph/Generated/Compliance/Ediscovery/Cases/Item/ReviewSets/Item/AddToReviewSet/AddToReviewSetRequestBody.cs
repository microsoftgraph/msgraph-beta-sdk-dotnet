using Microsoft.Kiota.Abstractions.Serialization;
using MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Compliance.Ediscovery.Cases.Item.ReviewSets.Item.AddToReviewSet {
    /// <summary>Provides operations to call the addToReviewSet method.</summary>
    public class AddToReviewSetRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.AdditionalDataOptions? AdditionalDataOptions { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection SourceCollection { get; set; }
        /// <summary>
        /// Instantiates a new addToReviewSetRequestBody and sets the default values.
        /// </summary>
        public AddToReviewSetRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AddToReviewSetRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddToReviewSetRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"additionalDataOptions", (o,n) => { (o as AddToReviewSetRequestBody).AdditionalDataOptions = n.GetEnumValue<AdditionalDataOptions>(); } },
                {"sourceCollection", (o,n) => { (o as AddToReviewSetRequestBody).SourceCollection = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection>(MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AdditionalDataOptions>("additionalDataOptions", AdditionalDataOptions);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Ediscovery.SourceCollection>("sourceCollection", SourceCollection);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
