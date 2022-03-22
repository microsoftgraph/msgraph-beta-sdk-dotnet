using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RankedEmailAddress : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The email address.</summary>
        public string Address { get; set; }
        /// <summary>The rank of the email address. A rank is used as a sort key, in relation to the other returned results. A higher rank value corresponds to a more relevant result. Relevance is determined by communication, collaboration, and business relationship signals.</summary>
        public double? Rank { get; set; }
        /// <summary>
        /// Instantiates a new rankedEmailAddress and sets the default values.
        /// </summary>
        public RankedEmailAddress() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static RankedEmailAddress CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RankedEmailAddress();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"address", (o,n) => { (o as RankedEmailAddress).Address = n.GetStringValue(); } },
                {"rank", (o,n) => { (o as RankedEmailAddress).Rank = n.GetDoubleValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("address", Address);
            writer.WriteDoubleValue("rank", Rank);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
