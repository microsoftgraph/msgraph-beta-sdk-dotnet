using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AddContentFooterAction : InformationProtectionAction, IParsable {
        /// <summary>The alignment property</summary>
        public ContentAlignment? Alignment {
            get { return BackingStore?.Get<ContentAlignment?>(nameof(Alignment)); }
            set { BackingStore?.Set(nameof(Alignment), value); }
        }
        /// <summary>The fontColor property</summary>
        public string FontColor {
            get { return BackingStore?.Get<string>(nameof(FontColor)); }
            set { BackingStore?.Set(nameof(FontColor), value); }
        }
        /// <summary>The fontName property</summary>
        public string FontName {
            get { return BackingStore?.Get<string>(nameof(FontName)); }
            set { BackingStore?.Set(nameof(FontName), value); }
        }
        /// <summary>The fontSize property</summary>
        public int? FontSize {
            get { return BackingStore?.Get<int?>(nameof(FontSize)); }
            set { BackingStore?.Set(nameof(FontSize), value); }
        }
        /// <summary>The margin property</summary>
        public int? Margin {
            get { return BackingStore?.Get<int?>(nameof(Margin)); }
            set { BackingStore?.Set(nameof(Margin), value); }
        }
        /// <summary>The text property</summary>
        public string Text {
            get { return BackingStore?.Get<string>(nameof(Text)); }
            set { BackingStore?.Set(nameof(Text), value); }
        }
        /// <summary>The uiElementName property</summary>
        public string UiElementName {
            get { return BackingStore?.Get<string>(nameof(UiElementName)); }
            set { BackingStore?.Set(nameof(UiElementName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AddContentFooterAction CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AddContentFooterAction();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"alignment", n => { Alignment = n.GetEnumValue<ContentAlignment>(); } },
                {"fontColor", n => { FontColor = n.GetStringValue(); } },
                {"fontName", n => { FontName = n.GetStringValue(); } },
                {"fontSize", n => { FontSize = n.GetIntValue(); } },
                {"margin", n => { Margin = n.GetIntValue(); } },
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
            writer.WriteEnumValue<ContentAlignment>("alignment", Alignment);
            writer.WriteStringValue("fontColor", FontColor);
            writer.WriteStringValue("fontName", FontName);
            writer.WriteIntValue("fontSize", FontSize);
            writer.WriteIntValue("margin", Margin);
            writer.WriteStringValue("text", Text);
            writer.WriteStringValue("uiElementName", UiElementName);
        }
    }
}
