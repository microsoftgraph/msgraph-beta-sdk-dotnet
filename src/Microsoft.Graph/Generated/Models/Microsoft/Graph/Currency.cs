using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Currency : Entity, IParsable {
        /// <summary>The amountDecimalPlaces property</summary>
        public string AmountDecimalPlaces { get; set; }
        /// <summary>The amountRoundingPrecision property</summary>
        public decimal? AmountRoundingPrecision { get; set; }
        /// <summary>The code property</summary>
        public string Code { get; set; }
        /// <summary>The displayName property</summary>
        public string DisplayName { get; set; }
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>The symbol property</summary>
        public string Symbol { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Currency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Currency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"amountDecimalPlaces", (o,n) => { (o as Currency).AmountDecimalPlaces = n.GetStringValue(); } },
                {"amountRoundingPrecision", (o,n) => { (o as Currency).AmountRoundingPrecision = n.GetDecimalValue(); } },
                {"code", (o,n) => { (o as Currency).Code = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as Currency).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as Currency).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"symbol", (o,n) => { (o as Currency).Symbol = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("amountDecimalPlaces", AmountDecimalPlaces);
            writer.WriteDecimalValue("amountRoundingPrecision", AmountRoundingPrecision);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("symbol", Symbol);
        }
    }
}
