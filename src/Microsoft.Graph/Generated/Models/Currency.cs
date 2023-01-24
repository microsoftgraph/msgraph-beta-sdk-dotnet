using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Currency : Entity, IParsable {
        /// <summary>The amountDecimalPlaces property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? AmountDecimalPlaces {
            get { return BackingStore?.Get<string?>("amountDecimalPlaces"); }
            set { BackingStore?.Set("amountDecimalPlaces", value); }
        }
#nullable restore
#else
        public string AmountDecimalPlaces {
            get { return BackingStore?.Get<string>("amountDecimalPlaces"); }
            set { BackingStore?.Set("amountDecimalPlaces", value); }
        }
#endif
        /// <summary>The amountRoundingPrecision property</summary>
        public decimal? AmountRoundingPrecision {
            get { return BackingStore?.Get<decimal?>("amountRoundingPrecision"); }
            set { BackingStore?.Set("amountRoundingPrecision", value); }
        }
        /// <summary>The code property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Code {
            get { return BackingStore?.Get<string?>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#nullable restore
#else
        public string Code {
            get { return BackingStore?.Get<string>("code"); }
            set { BackingStore?.Set("code", value); }
        }
#endif
        /// <summary>The displayName property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? DisplayName {
            get { return BackingStore?.Get<string?>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#nullable restore
#else
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
#endif
        /// <summary>The lastModifiedDateTime property</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>The symbol property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? Symbol {
            get { return BackingStore?.Get<string?>("symbol"); }
            set { BackingStore?.Set("symbol", value); }
        }
#nullable restore
#else
        public string Symbol {
            get { return BackingStore?.Get<string>("symbol"); }
            set { BackingStore?.Set("symbol", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Currency CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Currency();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"amountDecimalPlaces", n => { AmountDecimalPlaces = n.GetStringValue(); } },
                {"amountRoundingPrecision", n => { AmountRoundingPrecision = n.GetDecimalValue(); } },
                {"code", n => { Code = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"symbol", n => { Symbol = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
