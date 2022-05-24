using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Casts the previous resource to user.</summary>
    public class SensitivityPolicySettings : Entity, IParsable {
        /// <summary>The applicableTo property</summary>
        public SensitivityLabelTarget? ApplicableTo {
            get { return BackingStore?.Get<SensitivityLabelTarget?>(nameof(ApplicableTo)); }
            set { BackingStore?.Set(nameof(ApplicableTo), value); }
        }
        /// <summary>The downgradeSensitivityRequiresJustification property</summary>
        public bool? DowngradeSensitivityRequiresJustification {
            get { return BackingStore?.Get<bool?>(nameof(DowngradeSensitivityRequiresJustification)); }
            set { BackingStore?.Set(nameof(DowngradeSensitivityRequiresJustification), value); }
        }
        /// <summary>The helpWebUrl property</summary>
        public string HelpWebUrl {
            get { return BackingStore?.Get<string>(nameof(HelpWebUrl)); }
            set { BackingStore?.Set(nameof(HelpWebUrl), value); }
        }
        /// <summary>The isMandatory property</summary>
        public bool? IsMandatory {
            get { return BackingStore?.Get<bool?>(nameof(IsMandatory)); }
            set { BackingStore?.Set(nameof(IsMandatory), value); }
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
