using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.Security {
    public class InformationProtection : Entity, IParsable {
        public InformationProtectionPolicySetting LabelPolicySettings { get; set; }
        public List<SensitivityLabel> SensitivityLabels { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new InformationProtection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new InformationProtection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"labelPolicySettings", (o,n) => { (o as InformationProtection).LabelPolicySettings = n.GetObjectValue<InformationProtectionPolicySetting>(InformationProtectionPolicySetting.CreateFromDiscriminatorValue); } },
                {"sensitivityLabels", (o,n) => { (o as InformationProtection).SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>(SensitivityLabel.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<InformationProtectionPolicySetting>("labelPolicySettings", LabelPolicySettings);
            writer.WriteCollectionOfObjectValues<SensitivityLabel>("sensitivityLabels", SensitivityLabels);
        }
    }
}
