using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class SensitivityPolicySettings : Entity, IParsable {
        /// <summary>The applicableTo property</summary>
        public SensitivityLabelTarget? ApplicableTo { get; set; }
        /// <summary>The downgradeSensitivityRequiresJustification property</summary>
        public bool? DowngradeSensitivityRequiresJustification { get; set; }
        /// <summary>The helpWebUrl property</summary>
        public string HelpWebUrl { get; set; }
        /// <summary>The isMandatory property</summary>
        public bool? IsMandatory { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SensitivityPolicySettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SensitivityPolicySettings();
        }
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
