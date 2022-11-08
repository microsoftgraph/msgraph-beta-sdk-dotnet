using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyUploadedPresentation : GroupPolicyPresentation, IParsable {
        /// <summary>
        /// Instantiates a new GroupPolicyUploadedPresentation and sets the default values.
        /// </summary>
        public GroupPolicyUploadedPresentation() : base() {
            OdataType = "#microsoft.graph.groupPolicyUploadedPresentation";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new GroupPolicyUploadedPresentation CreateFromDiscriminatorValue(IParseNode parseNode) {
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
                _ => new GroupPolicyUploadedPresentation(),
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
        }
    }
}
