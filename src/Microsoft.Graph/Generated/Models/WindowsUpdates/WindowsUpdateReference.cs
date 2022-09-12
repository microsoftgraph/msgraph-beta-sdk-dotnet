using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class WindowsUpdateReference : SoftwareUpdateReference, IParsable {
        /// <summary>
        /// Instantiates a new WindowsUpdateReference and sets the default values.
        /// </summary>
        public WindowsUpdateReference() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.windowsUpdateReference";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsUpdateReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsUpdates.expeditedQualityUpdateReference" => new ExpeditedQualityUpdateReference(),
                "#microsoft.graph.windowsUpdates.featureUpdateReference" => new FeatureUpdateReference(),
                "#microsoft.graph.windowsUpdates.qualityUpdateReference" => new QualityUpdateReference(),
                _ => new WindowsUpdateReference(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
