using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SuggestedEnrollmentLimit : IParsable {
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
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"suggestedDailyLimit", (o,n) => { (o as SuggestedEnrollmentLimit).SuggestedDailyLimit = n.GetIntValue(); } },
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
