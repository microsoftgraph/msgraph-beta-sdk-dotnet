using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class InformationProtectionLabel : Entity, IParsable {
        /// <summary>The color that the UI should display for the label, if configured.</summary>
        public string Color { get; set; }
        /// <summary>The admin-defined description for the label.</summary>
        public string Description { get; set; }
        /// <summary>Indicates whether the label is active or not. Active labels should be hidden or disabled in UI.</summary>
        public bool? IsActive { get; set; }
        /// <summary>The plaintext name of the label.</summary>
        public string Name { get; set; }
        /// <summary>The parent label associated with a child label. Null if label has no parent.</summary>
        public ParentLabelDetails Parent { get; set; }
        /// <summary>The sensitivity value of the label, where lower is less sensitive.</summary>
        public int? Sensitivity { get; set; }
        /// <summary>The tooltip that should be displayed for the label in a UI.</summary>
        public string Tooltip { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"color", (o,n) => { (o as InformationProtectionLabel).Color = n.GetStringValue(); } },
                {"description", (o,n) => { (o as InformationProtectionLabel).Description = n.GetStringValue(); } },
                {"isActive", (o,n) => { (o as InformationProtectionLabel).IsActive = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as InformationProtectionLabel).Name = n.GetStringValue(); } },
                {"parent", (o,n) => { (o as InformationProtectionLabel).Parent = n.GetObjectValue<ParentLabelDetails>(); } },
                {"sensitivity", (o,n) => { (o as InformationProtectionLabel).Sensitivity = n.GetIntValue(); } },
                {"tooltip", (o,n) => { (o as InformationProtectionLabel).Tooltip = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("color", Color);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<ParentLabelDetails>("parent", Parent);
            writer.WriteIntValue("sensitivity", Sensitivity);
            writer.WriteStringValue("tooltip", Tooltip);
        }
    }
}
