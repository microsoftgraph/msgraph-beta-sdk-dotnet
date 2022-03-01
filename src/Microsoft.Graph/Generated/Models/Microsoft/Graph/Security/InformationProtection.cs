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
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"labelPolicySettings", (o,n) => { (o as InformationProtection).LabelPolicySettings = n.GetObjectValue<InformationProtectionPolicySetting>(); } },
                {"sensitivityLabels", (o,n) => { (o as InformationProtection).SensitivityLabels = n.GetCollectionOfObjectValues<SensitivityLabel>().ToList(); } },
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
