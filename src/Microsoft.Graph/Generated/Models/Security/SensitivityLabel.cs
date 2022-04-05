using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class SensitivityLabel : Entity, IParsable {
        /// <summary>The color property</summary>
        public string Color { get; set; }
        /// <summary>The contentFormats property</summary>
        public List<string> ContentFormats { get; set; }
        /// <summary>The description property</summary>
        public string Description { get; set; }
        /// <summary>The hasProtection property</summary>
        public bool? HasProtection { get; set; }
        /// <summary>The isActive property</summary>
        public bool? IsActive { get; set; }
        /// <summary>The isAppliable property</summary>
        public bool? IsAppliable { get; set; }
        /// <summary>The name property</summary>
        public string Name { get; set; }
        /// <summary>The parent property</summary>
        public SensitivityLabel Parent { get; set; }
        /// <summary>The sensitivity property</summary>
        public int? Sensitivity { get; set; }
        /// <summary>The tooltip property</summary>
        public string Tooltip { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SensitivityLabel CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitivityLabel();
        }
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
                {"parent", (o,n) => { (o as SensitivityLabel).Parent = n.GetObjectValue<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue); } },
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
