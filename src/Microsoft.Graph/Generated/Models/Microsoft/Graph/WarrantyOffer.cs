using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WarrantyOffer : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Warranty offer description</summary>
        public string Description { get; set; }
        /// <summary>Warranty offer end date</summary>
        public DateTimeOffset? EndDateTime { get; set; }
        /// <summary>Warranty offer start date</summary>
        public DateTimeOffset? StartDateTime { get; set; }
        /// <summary>Warranty offer type. Possible values are: unknown, manufacturer, contractual, unknownFutureValue.</summary>
        public WarrantyType? Type { get; set; }
        /// <summary>
        /// Instantiates a new warrantyOffer and sets the default values.
        /// </summary>
        public WarrantyOffer() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static WarrantyOffer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WarrantyOffer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"description", (o,n) => { (o as WarrantyOffer).Description = n.GetStringValue(); } },
                {"endDateTime", (o,n) => { (o as WarrantyOffer).EndDateTime = n.GetDateTimeOffsetValue(); } },
                {"startDateTime", (o,n) => { (o as WarrantyOffer).StartDateTime = n.GetDateTimeOffsetValue(); } },
                {"type", (o,n) => { (o as WarrantyOffer).Type = n.GetEnumValue<WarrantyType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("description", Description);
            writer.WriteDateTimeOffsetValue("endDateTime", EndDateTime);
            writer.WriteDateTimeOffsetValue("startDateTime", StartDateTime);
            writer.WriteEnumValue<WarrantyType>("type", Type);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
