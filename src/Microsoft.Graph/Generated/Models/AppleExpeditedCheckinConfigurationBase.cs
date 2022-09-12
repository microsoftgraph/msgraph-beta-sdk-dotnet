using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AppleExpeditedCheckinConfigurationBase : DeviceConfiguration, IParsable {
        /// <summary>Gets or sets whether to enable expedited device check-ins.</summary>
        public bool? EnableExpeditedCheckin {
            get { return BackingStore?.Get<bool?>("enableExpeditedCheckin"); }
            set { BackingStore?.Set("enableExpeditedCheckin", value); }
        }
        /// <summary>
        /// Instantiates a new AppleExpeditedCheckinConfigurationBase and sets the default values.
        /// </summary>
        public AppleExpeditedCheckinConfigurationBase() : base() {
            OdataType = "#microsoft.graph.appleExpeditedCheckinConfigurationBase";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AppleExpeditedCheckinConfigurationBase CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.iosExpeditedCheckinConfiguration" => new IosExpeditedCheckinConfiguration(),
                _ => new AppleExpeditedCheckinConfigurationBase(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"enableExpeditedCheckin", n => { EnableExpeditedCheckin = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("enableExpeditedCheckin", EnableExpeditedCheckin);
        }
    }
}
