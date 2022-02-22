using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class TaxGroup : Entity, IParsable {
        public string Code { get; set; }
        public string DisplayName { get; set; }
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        public string TaxType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"code", (o,n) => { (o as TaxGroup).Code = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as TaxGroup).DisplayName = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as TaxGroup).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
                {"taxType", (o,n) => { (o as TaxGroup).TaxType = n.GetStringValue(); } },
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
