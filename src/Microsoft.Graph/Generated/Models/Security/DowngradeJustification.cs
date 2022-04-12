using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class DowngradeJustification : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The isDowngradeJustified property</summary>
        public bool? IsDowngradeJustified { get; set; }
        /// <summary>The justificationMessage property</summary>
        public string JustificationMessage { get; set; }
        /// <summary>
        /// Instantiates a new downgradeJustification and sets the default values.
        /// </summary>
        public DowngradeJustification() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DowngradeJustification CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DowngradeJustification();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"isDowngradeJustified", n => { IsDowngradeJustified = n.GetBoolValue(); } },
                {"justificationMessage", n => { JustificationMessage = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isDowngradeJustified", IsDowngradeJustified);
            writer.WriteStringValue("justificationMessage", JustificationMessage);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
