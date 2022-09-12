using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MarkContent : LabelActionBase, IParsable {
        /// <summary>The fontColor property</summary>
        public string FontColor {
            get { return BackingStore?.Get<string>("fontColor"); }
            set { BackingStore?.Set("fontColor", value); }
        }
        /// <summary>The fontSize property</summary>
        public long? FontSize {
            get { return BackingStore?.Get<long?>("fontSize"); }
            set { BackingStore?.Set("fontSize", value); }
        }
        /// <summary>The text property</summary>
        public string Text {
            get { return BackingStore?.Get<string>("text"); }
            set { BackingStore?.Set("text", value); }
        }
        /// <summary>
        /// Instantiates a new MarkContent and sets the default values.
        /// </summary>
        public MarkContent() : base() {
            OdataType = "#microsoft.graph.markContent";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MarkContent CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.addFooter" => new AddFooter(),
                "#microsoft.graph.addHeader" => new AddHeader(),
                "#microsoft.graph.addWatermark" => new AddWatermark(),
                _ => new MarkContent(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"fontColor", n => { FontColor = n.GetStringValue(); } },
                {"fontSize", n => { FontSize = n.GetLongValue(); } },
                {"text", n => { Text = n.GetStringValue(); } },
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
            writer.WriteLongValue("fontSize", FontSize);
            writer.WriteStringValue("text", Text);
        }
    }
}
