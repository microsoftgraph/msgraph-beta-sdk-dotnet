using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class ContentInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The contentFormat property</summary>
        public string ContentFormat { get; set; }
        /// <summary>The identifier property</summary>
        public string Identifier { get; set; }
        /// <summary>The metadata property</summary>
        public List<KeyValuePair> Metadata { get; set; }
        /// <summary>The state property</summary>
        public ContentState? State { get; set; }
        /// <summary>
        /// Instantiates a new contentInfo and sets the default values.
        /// </summary>
        public ContentInfo() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ContentInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ContentInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"contentFormat", (o,n) => { (o as ContentInfo).ContentFormat = n.GetStringValue(); } },
                {"identifier", (o,n) => { (o as ContentInfo).Identifier = n.GetStringValue(); } },
                {"metadata", (o,n) => { (o as ContentInfo).Metadata = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"state", (o,n) => { (o as ContentInfo).State = n.GetEnumValue<ContentState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("contentFormat", ContentFormat);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("metadata", Metadata);
            writer.WriteEnumValue<ContentState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
