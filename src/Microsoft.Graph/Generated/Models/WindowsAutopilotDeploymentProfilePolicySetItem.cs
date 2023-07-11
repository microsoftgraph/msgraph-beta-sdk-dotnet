using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// A class containing the properties used for windows autopilot deployment profile PolicySetItem.
    /// </summary>
    public class WindowsAutopilotDeploymentProfilePolicySetItem : PolicySetItem, IParsable {
        /// <summary>
        /// Instantiates a new windowsAutopilotDeploymentProfilePolicySetItem and sets the default values.
        /// </summary>
        public WindowsAutopilotDeploymentProfilePolicySetItem() : base() {
            OdataType = "#microsoft.graph.windowsAutopilotDeploymentProfilePolicySetItem";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WindowsAutopilotDeploymentProfilePolicySetItem CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAutopilotDeploymentProfilePolicySetItem();
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
