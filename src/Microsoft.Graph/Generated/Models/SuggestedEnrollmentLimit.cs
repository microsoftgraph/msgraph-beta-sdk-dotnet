using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>The suggestedEnrollmentLimit resource represents the suggested enrollment limit when given an enrollment type.</summary>
    public class SuggestedEnrollmentLimit : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The suggested enrollment limit within a day</summary>
        public int? SuggestedDailyLimit { get; set; }
        /// <summary>
        /// Instantiates a new suggestedEnrollmentLimit and sets the default values.
        /// </summary>
        public SuggestedEnrollmentLimit() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static SuggestedEnrollmentLimit CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SuggestedEnrollmentLimit();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"suggestedDailyLimit", n => { SuggestedDailyLimit = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("suggestedDailyLimit", SuggestedDailyLimit);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
