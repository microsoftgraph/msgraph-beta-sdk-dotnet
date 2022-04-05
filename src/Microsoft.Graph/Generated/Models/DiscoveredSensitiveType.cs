using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DiscoveredSensitiveType : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The classificationAttributes property</summary>
        public List<ClassificationAttribute> ClassificationAttributes { get; set; }
        /// <summary>The confidence property</summary>
        public int? Confidence { get; set; }
        /// <summary>The count property</summary>
        public int? Count { get; set; }
        /// <summary>The id property</summary>
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new discoveredSensitiveType and sets the default values.
        /// </summary>
        public DiscoveredSensitiveType() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DiscoveredSensitiveType CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DiscoveredSensitiveType();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"classificationAttributes", (o,n) => { (o as DiscoveredSensitiveType).ClassificationAttributes = n.GetCollectionOfObjectValues<ClassificationAttribute>(ClassificationAttribute.CreateFromDiscriminatorValue).ToList(); } },
                {"confidence", (o,n) => { (o as DiscoveredSensitiveType).Confidence = n.GetIntValue(); } },
                {"count", (o,n) => { (o as DiscoveredSensitiveType).Count = n.GetIntValue(); } },
                {"id", (o,n) => { (o as DiscoveredSensitiveType).Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<ClassificationAttribute>("classificationAttributes", ClassificationAttributes);
            writer.WriteIntValue("confidence", Confidence);
            writer.WriteIntValue("count", Count);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
