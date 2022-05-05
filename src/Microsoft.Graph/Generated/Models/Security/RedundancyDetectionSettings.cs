using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class RedundancyDetectionSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isEnabled property</summary>
        public bool? IsEnabled { get; set; }
        /// <summary>The maxWords property</summary>
        public int? MaxWords { get; set; }
        /// <summary>The minWords property</summary>
        public int? MinWords { get; set; }
        /// <summary>The similarityThreshold property</summary>
        public int? SimilarityThreshold { get; set; }
        /// <summary>
        /// Instantiates a new redundancyDetectionSettings and sets the default values.
        /// </summary>
        public RedundancyDetectionSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RedundancyDetectionSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedundancyDetectionSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isEnabled", n => { IsEnabled = n.GetBoolValue(); } },
                {"maxWords", n => { MaxWords = n.GetIntValue(); } },
                {"minWords", n => { MinWords = n.GetIntValue(); } },
                {"similarityThreshold", n => { SimilarityThreshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isEnabled", IsEnabled);
            writer.WriteIntValue("maxWords", MaxWords);
            writer.WriteIntValue("minWords", MinWords);
            writer.WriteIntValue("similarityThreshold", SimilarityThreshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
