using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ContentClassification : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The confidence property</summary>
        public int? Confidence { get; set; }
        /// <summary>The matches property</summary>
        public List<MatchLocation> Matches { get; set; }
        /// <summary>The sensitiveTypeId property</summary>
        public string SensitiveTypeId { get; set; }
        /// <summary>The uniqueCount property</summary>
        public int? UniqueCount { get; set; }
        /// <summary>
        /// Instantiates a new contentClassification and sets the default values.
        /// </summary>
        public ContentClassification() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ContentClassification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentClassification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"confidence", n => { Confidence = n.GetIntValue(); } },
                {"matches", n => { Matches = n.GetCollectionOfObjectValues<MatchLocation>(MatchLocation.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitiveTypeId", n => { SensitiveTypeId = n.GetStringValue(); } },
                {"uniqueCount", n => { UniqueCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteCollectionOfObjectValues<MatchLocation>("matches", Matches);
            writer.WriteStringValue("sensitiveTypeId", SensitiveTypeId);
            writer.WriteIntValue("uniqueCount", UniqueCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
