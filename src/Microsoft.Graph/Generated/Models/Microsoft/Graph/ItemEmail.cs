using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ItemEmail : ItemFacet, IParsable {
        /// <summary>The email address itself.</summary>
        public string Address { get; set; }
        /// <summary>The name or label a user has associated with a particular email address.</summary>
        public string DisplayName { get; set; }
        /// <summary>The type of email address. Possible values are: unknown, work, personal, main, other.</summary>
        public EmailType? Type { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ItemEmail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ItemEmail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"address", (o,n) => { (o as ItemEmail).Address = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as ItemEmail).DisplayName = n.GetStringValue(); } },
                {"type", (o,n) => { (o as ItemEmail).Type = n.GetEnumValue<EmailType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("address", Address);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteEnumValue<EmailType>("type", Type);
        }
    }
}
