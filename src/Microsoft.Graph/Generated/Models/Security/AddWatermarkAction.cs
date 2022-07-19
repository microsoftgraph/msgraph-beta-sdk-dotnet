using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AddWatermarkAction : InformationProtectionAction, IParsable {
        /// <summary>The fontColor property</summary>
        public string FontColor {
            get { return BackingStore?.Get<string>("fontColor"); }
            set { BackingStore?.Set("fontColor", value); }
        }
        /// <summary>The fontName property</summary>
        public string FontName {
            get { return BackingStore?.Get<string>("fontName"); }
            set { BackingStore?.Set("fontName", value); }
        }
        /// <summary>The fontSize property</summary>
        public int? FontSize {
            get { return BackingStore?.Get<int?>("fontSize"); }
            set { BackingStore?.Set("fontSize", value); }
        }
        /// <summary>The layout property</summary>
        public WatermarkLayout? Layout {
            get { return BackingStore?.Get<WatermarkLayout?>("layout"); }
            set { BackingStore?.Set("layout", value); }
        }
        /// <summary>The text property</summary>
        public string Text {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
        /// <summary>The uiElementName property</summary>
        public string UiElementName {
            get { return BackingStore?.Get<string>("uiElementName"); }
            set { BackingStore?.Set("uiElementName", value); }
        }
        /// <summary>
        /// Instantiates a new AddWatermarkAction and sets the default values.
        /// </summary>
        public AddWatermarkAction() : base() {
            OdataType = "#microsoft.graph.security.addWatermarkAction";
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
