using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AddWatermarkAction : InformationProtectionAction, IParsable {
        /// <summary>Color of the font to use for the watermark.</summary>
        public string FontColor {
            get { return BackingStore?.Get<string>(nameof(FontColor)); }
            set { BackingStore?.Set(nameof(FontColor), value); }
        }
        /// <summary>Name of the font to use for the watermark.</summary>
        public string FontName {
            get { return BackingStore?.Get<string>(nameof(FontName)); }
            set { BackingStore?.Set(nameof(FontName), value); }
        }
        /// <summary>Font size to use for the watermark.</summary>
        public int? FontSize {
            get { return BackingStore?.Get<int?>(nameof(FontSize)); }
            set { BackingStore?.Set(nameof(FontSize), value); }
        }
        /// <summary>Possible values are: horizontal, diagonal.</summary>
        public WatermarkLayout? Layout {
            get { return BackingStore?.Get<WatermarkLayout?>(nameof(Layout)); }
            set { BackingStore?.Set(nameof(Layout), value); }
        }
        /// <summary>The contents of the watermark itself.</summary>
        public string Text {
            get { return BackingStore?.Get<string>(nameof(Text)); }
            set { BackingStore?.Set(nameof(Text), value); }
        }
        /// <summary>The name of the UI element where the watermark should be placed.</summary>
        public string UiElementName {
            get { return BackingStore?.Get<string>(nameof(UiElementName)); }
            set { BackingStore?.Set(nameof(UiElementName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AddWatermarkAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddWatermarkAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fontColor", n => { FontColor = n.GetStringValue(); } },
                {"fontName", n => { FontName = n.GetStringValue(); } },
                {"fontSize", n => { FontSize = n.GetIntValue(); } },
                {"layout", n => { Layout = n.GetEnumValue<WatermarkLayout>(); } },
                {"text", n => { Text = n.GetStringValue(); } },
                {"uiElementName", n => { UiElementName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("fontColor", FontColor);
            writer.WriteStringValue("fontName", FontName);
            writer.WriteIntValue("fontSize", FontSize);
            writer.WriteEnumValue<WatermarkLayout>("layout", Layout);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("uiElementName", UiElementName);
        }
    }
}
