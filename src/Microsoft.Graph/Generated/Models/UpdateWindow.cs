using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UpdateWindow : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>End of a time window during which agents can receive updates</summary>
        public Time? UpdateWindowEndTime { get; set; }
        /// <summary>Start of a time window during which agents can receive updates</summary>
        public Time? UpdateWindowStartTime { get; set; }
        /// <summary>
        /// Instantiates a new updateWindow and sets the default values.
        /// </summary>
        public UpdateWindow() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UpdateWindow CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UpdateWindow();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"updateWindowEndTime", n => { UpdateWindowEndTime = n.GetTimeValue(); } },
                {"updateWindowStartTime", n => { UpdateWindowStartTime = n.GetTimeValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteTimeValue("updateWindowEndTime", UpdateWindowEndTime);
            writer.WriteTimeValue("updateWindowStartTime", UpdateWindowStartTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
