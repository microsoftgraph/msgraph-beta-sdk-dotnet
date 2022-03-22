using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class GroupPolicyPresentation : Entity, IParsable {
        /// <summary>The group policy definition associated with the presentation.</summary>
        public GroupPolicyDefinition Definition { get; set; }
        /// <summary>Localized text label for any presentation entity. The default value is empty.</summary>
        public string Label { get; set; }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"definition", (o,n) => { (o as GroupPolicyPresentation).Definition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"label", (o,n) => { (o as GroupPolicyPresentation).Label = n.GetStringValue(); } },
                {"lastModifiedDateTime", (o,n) => { (o as GroupPolicyPresentation).LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GroupPolicyDefinition>("definition", Definition);
            writer.WriteStringValue("label", Label);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
