using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class TaxArea : Entity, IParsable {
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string TaxType { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TaxArea CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TaxArea();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"code", (o,n) => { (o as TaxArea).Code = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TaxArea).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TaxArea).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"taxType", (o,n) => { (o as TaxArea).TaxType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("code", Code);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
            writer.WriteStringValue("taxType", TaxType);
        }
    }
}
