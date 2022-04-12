using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ContentInfo : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Possible values are: default, email.</summary>
        public ContentFormat? Format { get; set; }
        /// <summary>Identifier used for Azure Information Protection Analytics.</summary>
        public string Identifier { get; set; }
        /// <summary>Existing Microsoft Information Protection metadata is passed as key/value pairs, where the key is the MSIP_Label_GUID_PropName.</summary>
        public List<KeyValuePair> Metadata { get; set; }
        /// <summary>Possible values are: rest, motion, use.</summary>
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
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"format", n => { Format = n.GetEnumValue<ContentFormat>(); } },
                {"identifier", n => { Identifier = n.GetStringValue(); } },
                {"metadata", n => { Metadata = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"state", n => { State = n.GetEnumValue<ContentState>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<ContentFormat>("format", Format);
            writer.WriteStringValue("identifier", Identifier);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("metadata", Metadata);
            writer.WriteEnumValue<ContentState>("state", State);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
