using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TextColumn : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Whether to allow multiple lines of text.</summary>
        public bool? AllowMultipleLines {
            get { return BackingStore?.Get<bool?>(nameof(AllowMultipleLines)); }
            set { BackingStore?.Set(nameof(AllowMultipleLines), value); }
        }
        /// <summary>Whether updates to this column should replace existing text, or append to it.</summary>
        public bool? AppendChangesToExistingText {
            get { return BackingStore?.Get<bool?>(nameof(AppendChangesToExistingText)); }
            set { BackingStore?.Set(nameof(AppendChangesToExistingText), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The size of the text box.</summary>
        public int? LinesForEditing {
            get { return BackingStore?.Get<int?>(nameof(LinesForEditing)); }
            set { BackingStore?.Set(nameof(LinesForEditing), value); }
        }
        /// <summary>The maximum number of characters for the value.</summary>
        public int? MaxLength {
            get { return BackingStore?.Get<int?>(nameof(MaxLength)); }
            set { BackingStore?.Set(nameof(MaxLength), value); }
        }
        /// <summary>The type of text being stored. Must be one of plain or richText</summary>
        public string TextType {
            get { return BackingStore?.Get<string>(nameof(TextType)); }
            set { BackingStore?.Set(nameof(TextType), value); }
        }
        /// <summary>
        /// Instantiates a new textColumn and sets the default values.
        /// </summary>
        public TextColumn() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TextColumn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TextColumn();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"allowMultipleLines", n => { AllowMultipleLines = n.GetBoolValue(); } },
                {"appendChangesToExistingText", n => { AppendChangesToExistingText = n.GetBoolValue(); } },
                {"linesForEditing", n => { LinesForEditing = n.GetIntValue(); } },
                {"maxLength", n => { MaxLength = n.GetIntValue(); } },
                {"textType", n => { TextType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("allowMultipleLines", AllowMultipleLines);
            writer.WriteBoolValue("appendChangesToExistingText", AppendChangesToExistingText);
            writer.WriteIntValue("linesForEditing", LinesForEditing);
            writer.WriteIntValue("maxLength", MaxLength);
            writer.WriteStringValue("textType", TextType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
