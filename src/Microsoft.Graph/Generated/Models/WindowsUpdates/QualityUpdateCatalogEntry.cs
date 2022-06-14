using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class QualityUpdateCatalogEntry : SoftwareUpdateCatalogEntry, IParsable {
        /// <summary>Indicates whether the content can be deployed as an expedited quality update. Read-only.</summary>
        public bool? IsExpeditable {
            get { return BackingStore?.Get<bool?>(nameof(IsExpeditable)); }
            set { BackingStore?.Set(nameof(IsExpeditable), value); }
        }
        /// <summary>The classification on the quality update. Possible values are: all, security, nonSecurity, unknownFutureValue. Read-only.</summary>
        public Microsoft.Graph.Beta.Models.WindowsUpdates.QualityUpdateClassification? QualityUpdateClassification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.WindowsUpdates.QualityUpdateClassification?>(nameof(QualityUpdateClassification)); }
            set { BackingStore?.Set(nameof(QualityUpdateClassification), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isExpeditable", IsExpeditable);
            writer.WriteEnumValue<QualityUpdateClassification>("qualityUpdateClassification", QualityUpdateClassification);
        }
    }
}
