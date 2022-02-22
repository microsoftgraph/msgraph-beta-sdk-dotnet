using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SensitivityPolicySettings : Entity, IParsable {
        public SensitivityLabelTarget? ApplicableTo { get; set; }
        public bool? DowngradeSensitivityRequiresJustification { get; set; }
        public string HelpWebUrl { get; set; }
        public bool? IsMandatory { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"applicableTo", (o,n) => { (o as SensitivityPolicySettings).ApplicableTo = n.GetEnumValue<SensitivityLabelTarget>(); } },
                {"downgradeSensitivityRequiresJustification", (o,n) => { (o as SensitivityPolicySettings).DowngradeSensitivityRequiresJustification = n.GetBoolValue(); } },
                {"helpWebUrl", (o,n) => { (o as SensitivityPolicySettings).HelpWebUrl = n.GetStringValue(); } },
                {"isMandatory", (o,n) => { (o as SensitivityPolicySettings).IsMandatory = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<SensitivityLabelTarget>("applicableTo", ApplicableTo);
            writer.WriteBoolValue("downgradeSensitivityRequiresJustification", DowngradeSensitivityRequiresJustification);
            writer.WriteStringValue("helpWebUrl", HelpWebUrl);
            writer.WriteBoolValue("isMandatory", IsMandatory);
        }
    }
}
