using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class PersonAnnualEvent : ItemFacet, IParsable {
        public Date? Date { get; set; }
        public string DisplayName { get; set; }
        public PersonAnnualEventType? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PersonAnnualEvent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PersonAnnualEvent();
        }
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
