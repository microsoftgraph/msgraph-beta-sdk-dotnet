using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentation : Entity, IParsable {
        /// <summary>The group policy definition associated with the presentation.</summary>
        public GroupPolicyDefinition Definition {
            get { return BackingStore?.Get<GroupPolicyDefinition>("definition"); }
            set { BackingStore?.Set("definition", value); }
        }
        /// <summary>Localized text label for any presentation entity. The default value is empty.</summary>
        public string Label {
            get { return BackingStore?.Get<string>("label"); }
            set { BackingStore?.Set("label", value); }
        }
        /// <summary>The date and time the entity was last modified.</summary>
        public DateTimeOffset? LastModifiedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastModifiedDateTime"); }
            set { BackingStore?.Set("lastModifiedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new groupPolicyPresentation and sets the default values.
        /// </summary>
        public GroupPolicyPresentation() : base() {
            OdataType = "#microsoft.graph.groupPolicyPresentation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.groupPolicyPresentationCheckBox" => new GroupPolicyPresentationCheckBox(),
                "#microsoft.graph.groupPolicyPresentationComboBox" => new GroupPolicyPresentationComboBox(),
                "#microsoft.graph.groupPolicyPresentationDecimalTextBox" => new GroupPolicyPresentationDecimalTextBox(),
                "#microsoft.graph.groupPolicyPresentationDropdownList" => new GroupPolicyPresentationDropdownList(),
                "#microsoft.graph.groupPolicyPresentationListBox" => new GroupPolicyPresentationListBox(),
                "#microsoft.graph.groupPolicyPresentationLongDecimalTextBox" => new GroupPolicyPresentationLongDecimalTextBox(),
                "#microsoft.graph.groupPolicyPresentationMultiTextBox" => new GroupPolicyPresentationMultiTextBox(),
                "#microsoft.graph.groupPolicyPresentationText" => new GroupPolicyPresentationText(),
                "#microsoft.graph.groupPolicyPresentationTextBox" => new GroupPolicyPresentationTextBox(),
                "#microsoft.graph.groupPolicyUploadedPresentation" => new GroupPolicyUploadedPresentation(),
                _ => new GroupPolicyPresentation(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"definition", n => { Definition = n.GetObjectValue<GroupPolicyDefinition>(GroupPolicyDefinition.CreateFromDiscriminatorValue); } },
                {"label", n => { Label = n.GetStringValue(); } },
                {"lastModifiedDateTime", n => { LastModifiedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<GroupPolicyDefinition>("definition", Definition);
            writer.WriteStringValue("label", Label);
            writer.WriteDateTimeOffsetValue("lastModifiedDateTime", LastModifiedDateTime);
        }
    }
}
