using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class SensitivityLabel : Entity, IParsable {
        public string Color { get; set; }
        public List<string> ContentFormats { get; set; }
        public string Description { get; set; }
        public bool? HasProtection { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsAppliable { get; set; }
        public string Name { get; set; }
        public SensitivityLabel Parent { get; set; }
        public int? Sensitivity { get; set; }
        public string Tooltip { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"color", (o,n) => { (o as SensitivityLabel).Color = n.GetStringValue(); } },
                {"contentFormats", (o,n) => { (o as SensitivityLabel).ContentFormats = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"description", (o,n) => { (o as SensitivityLabel).Description = n.GetStringValue(); } },
                {"hasProtection", (o,n) => { (o as SensitivityLabel).HasProtection = n.GetBoolValue(); } },
                {"isActive", (o,n) => { (o as SensitivityLabel).IsActive = n.GetBoolValue(); } },
                {"isAppliable", (o,n) => { (o as SensitivityLabel).IsAppliable = n.GetBoolValue(); } },
                {"name", (o,n) => { (o as SensitivityLabel).Name = n.GetStringValue(); } },
                {"parent", (o,n) => { (o as SensitivityLabel).Parent = n.GetObjectValue<SensitivityLabel>(); } },
                {"sensitivity", (o,n) => { (o as SensitivityLabel).Sensitivity = n.GetIntValue(); } },
                {"tooltip", (o,n) => { (o as SensitivityLabel).Tooltip = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("contentFormats", ContentFormats);
            writer.WriteStringValue("description", Description);
            writer.WriteBoolValue("hasProtection", HasProtection);
            writer.WriteBoolValue("isActive", IsActive);
            writer.WriteBoolValue("isAppliable", IsAppliable);
            writer.WriteStringValue("name", Name);
            writer.WriteObjectValue<SensitivityLabel>("parent", Parent);
            writer.WriteIntValue("sensitivity", Sensitivity);
            writer.WriteStringValue("tooltip", Tooltip);
        }
    }
}
