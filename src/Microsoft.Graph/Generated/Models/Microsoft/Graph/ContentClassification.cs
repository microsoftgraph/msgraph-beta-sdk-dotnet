using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ContentClassification : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public int? Confidence { get; set; }
        public List<MatchLocation> Matches { get; set; }
        public string SensitiveTypeId { get; set; }
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"confidence", (o,n) => { (o as ContentClassification).Confidence = n.GetIntValue(); } },
                {"matches", (o,n) => { (o as ContentClassification).Matches = n.GetCollectionOfObjectValues<MatchLocation>(MatchLocation.CreateFromDiscriminatorValue).ToList(); } },
                {"sensitiveTypeId", (o,n) => { (o as ContentClassification).SensitiveTypeId = n.GetStringValue(); } },
                {"uniqueCount", (o,n) => { (o as ContentClassification).UniqueCount = n.GetIntValue(); } },
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
