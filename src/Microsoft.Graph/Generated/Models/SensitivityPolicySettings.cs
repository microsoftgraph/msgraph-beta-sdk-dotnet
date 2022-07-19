using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SensitivityPolicySettings : Entity, IParsable {
        /// <summary>The applicableTo property</summary>
        public SensitivityLabelTarget? ApplicableTo {
            get { return BackingStore?.Get<SensitivityLabelTarget?>("applicableTo"); }
            set { BackingStore?.Set("applicableTo", value); }
        }
        /// <summary>The downgradeSensitivityRequiresJustification property</summary>
        public bool? DowngradeSensitivityRequiresJustification {
            get { return BackingStore?.Get<bool?>("downgradeSensitivityRequiresJustification"); }
            set { BackingStore?.Set("downgradeSensitivityRequiresJustification", value); }
        }
        /// <summary>The helpWebUrl property</summary>
        public string HelpWebUrl {
            get { return BackingStore?.Get<string>("helpWebUrl"); }
            set { BackingStore?.Set("helpWebUrl", value); }
        }
        /// <summary>The isMandatory property</summary>
        public bool? IsMandatory {
            get { return BackingStore?.Get<bool?>("isMandatory"); }
            set { BackingStore?.Set("isMandatory", value); }
        }
        /// <summary>
        /// Instantiates a new sensitivityPolicySettings and sets the default values.
        /// </summary>
        public SensitivityPolicySettings() : base() {
            OdataType = "#microsoft.graph.sensitivityPolicySettings";
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"applicableTo", n => { ApplicableTo = n.GetEnumValue<SensitivityLabelTarget>(); } },
                {"downgradeSensitivityRequiresJustification", n => { DowngradeSensitivityRequiresJustification = n.GetBoolValue(); } },
                {"helpWebUrl", n => { HelpWebUrl = n.GetStringValue(); } },
                {"isMandatory", n => { IsMandatory = n.GetBoolValue(); } },
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
