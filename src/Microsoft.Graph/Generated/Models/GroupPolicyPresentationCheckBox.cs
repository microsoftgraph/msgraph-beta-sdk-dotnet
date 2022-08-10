using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class GroupPolicyPresentationCheckBox : GroupPolicyUploadedPresentation, IParsable {
        /// <summary>Default value for the check box. The default value is false.</summary>
        public bool? DefaultChecked {
            get { return BackingStore?.Get<bool?>("defaultChecked"); }
            set { BackingStore?.Set("defaultChecked", value); }
        }
        /// <summary>
        /// Instantiates a new GroupPolicyPresentationCheckBox and sets the default values.
        /// </summary>
        public GroupPolicyPresentationCheckBox() : base() {
            OdataType = "#microsoft.graph.groupPolicyPresentationCheckBox";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GroupPolicyPresentationCheckBox CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GroupPolicyPresentationCheckBox();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"defaultChecked", n => { DefaultChecked = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("defaultChecked", DefaultChecked);
        }
    }
}
