using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PersonNamePronounciation : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The first property</summary>
        public string First { get; set; }
        /// <summary>The last property</summary>
        public string Last { get; set; }
        /// <summary>The maiden property</summary>
        public string Maiden { get; set; }
        /// <summary>The middle property</summary>
        public string Middle { get; set; }
        /// <summary>
        /// Instantiates a new personNamePronounciation and sets the default values.
        /// </summary>
        public PersonNamePronounciation() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static PersonNamePronounciation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonNamePronounciation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"displayName", (o,n) => { (o as PersonNamePronounciation).DisplayName = n.GetStringValue(); } },
                {"first", (o,n) => { (o as PersonNamePronounciation).First = n.GetStringValue(); } },
                {"last", (o,n) => { (o as PersonNamePronounciation).Last = n.GetStringValue(); } },
                {"maiden", (o,n) => { (o as PersonNamePronounciation).Maiden = n.GetStringValue(); } },
                {"middle", (o,n) => { (o as PersonNamePronounciation).Middle = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("first", First);
            writer.WriteStringValue("last", Last);
            writer.WriteStringValue("maiden", Maiden);
            writer.WriteStringValue("middle", Middle);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
