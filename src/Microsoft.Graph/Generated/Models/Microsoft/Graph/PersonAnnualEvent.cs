using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PersonAnnualEvent : ItemFacet, IParsable {
        public Date? Date { get; set; }
        public string DisplayName { get; set; }
        public PersonAnnualEventType? Type { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"date", (o,n) => { (o as PersonAnnualEvent).Date = n.GetDateValue(); } },
                {"displayName", (o,n) => { (o as PersonAnnualEvent).DisplayName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as PersonAnnualEvent).Type = n.GetEnumValue<PersonAnnualEventType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateValue("date", Date);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<PersonAnnualEventType>("type", Type);
        }
    }
}
