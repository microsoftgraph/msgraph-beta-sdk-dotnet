using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class OfficeUserCheckinSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total failed user check ins for the last 3 months.</summary>
        public int? FailedUserCount { get; set; }
        /// <summary>Total successful user check ins for the last 3 months.</summary>
        public int? SucceededUserCount { get; set; }
        /// <summary>
        /// Instantiates a new officeUserCheckinSummary and sets the default values.
        /// </summary>
        public OfficeUserCheckinSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static OfficeUserCheckinSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OfficeUserCheckinSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"failedUserCount", (o,n) => { (o as OfficeUserCheckinSummary).FailedUserCount = n.GetIntValue(); } },
                {"succeededUserCount", (o,n) => { (o as OfficeUserCheckinSummary).SucceededUserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("failedUserCount", FailedUserCount);
            writer.WriteIntValue("succeededUserCount", SucceededUserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
