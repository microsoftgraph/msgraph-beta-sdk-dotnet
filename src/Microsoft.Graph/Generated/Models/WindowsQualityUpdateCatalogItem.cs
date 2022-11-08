using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsQualityUpdateCatalogItem : WindowsUpdateCatalogItem, IParsable {
        /// <summary>Windows quality update classification</summary>
        public WindowsQualityUpdateClassification? Classification {
            get { return BackingStore?.Get<WindowsQualityUpdateClassification?>("classification"); }
            set { BackingStore?.Set("classification", value); }
        }
        /// <summary>Flag indicating if update qualifies for expedite</summary>
        public bool? IsExpeditable {
            get { return BackingStore?.Get<bool?>("isExpeditable"); }
            set { BackingStore?.Set("isExpeditable", value); }
        }
        /// <summary>Knowledge base article id</summary>
        public string KbArticleId {
            get { return BackingStore?.Get<string>("kbArticleId"); }
            set { BackingStore?.Set("kbArticleId", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsQualityUpdateCatalogItem and sets the default values.
        /// </summary>
        public WindowsQualityUpdateCatalogItem() : base() {
            OdataType = "#microsoft.graph.windowsQualityUpdateCatalogItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsQualityUpdateCatalogItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsQualityUpdateCatalogItem();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"classification", n => { Classification = n.GetEnumValue<WindowsQualityUpdateClassification>(); } },
                {"isExpeditable", n => { IsExpeditable = n.GetBoolValue(); } },
                {"kbArticleId", n => { KbArticleId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WindowsQualityUpdateClassification>("classification", Classification);
            writer.WriteBoolValue("isExpeditable", IsExpeditable);
            writer.WriteStringValue("kbArticleId", KbArticleId);
        }
    }
}
