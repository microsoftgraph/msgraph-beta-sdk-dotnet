using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ChecklistItem : Entity, IParsable {
        /// <summary>The date and time when the checklistItem was finished.</summary>
        public DateTimeOffset? CheckedDateTime { get; set; }
        /// <summary>The date and time when the checklistItem was created.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Field indicating the title of checklistItem.</summary>
        public string DisplayName { get; set; }
        /// <summary>State indicating whether the item is checked off or not.</summary>
        public bool? IsChecked { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChecklistItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChecklistItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"checkedDateTime", (o,n) => { (o as ChecklistItem).CheckedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdDateTime", (o,n) => { (o as ChecklistItem).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"displayName", (o,n) => { (o as ChecklistItem).DisplayName = n.GetStringValue(); } },
                {"isChecked", (o,n) => { (o as ChecklistItem).IsChecked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("checkedDateTime", CheckedDateTime);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isChecked", IsChecked);
        }
    }
}
