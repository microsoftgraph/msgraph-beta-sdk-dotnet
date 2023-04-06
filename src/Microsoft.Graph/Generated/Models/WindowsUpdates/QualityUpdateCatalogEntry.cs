using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class QualityUpdateCatalogEntry : SoftwareUpdateCatalogEntry, IParsable {
        /// <summary>Indicates whether the content can be deployed as an expedited quality update. Read-only.</summary>
        public bool? IsExpeditable {
            get { return BackingStore?.Get<bool?>("isExpeditable"); }
            set { BackingStore?.Set("isExpeditable", value); }
        }
        /// <summary>The qualityUpdateClassification property</summary>
        public Microsoft.Graph.Beta.Models.WindowsUpdates.QualityUpdateClassification? QualityUpdateClassification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.QualityUpdateClassification?>("qualityUpdateClassification"); }
            set { BackingStore?.Set("qualityUpdateClassification", value); }
        }
        /// <summary>
        /// Instantiates a new QualityUpdateCatalogEntry and sets the default values.
        /// </summary>
        public QualityUpdateCatalogEntry() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.qualityUpdateCatalogEntry";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new QualityUpdateCatalogEntry CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new QualityUpdateCatalogEntry();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"isExpeditable", n => { IsExpeditable = n.GetBoolValue(); } },
                {"qualityUpdateClassification", n => { QualityUpdateClassification = n.GetEnumValue<QualityUpdateClassification>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isExpeditable", IsExpeditable);
            writer.WriteEnumValue<QualityUpdateClassification>("qualityUpdateClassification", QualityUpdateClassification);
        }
    }
}
