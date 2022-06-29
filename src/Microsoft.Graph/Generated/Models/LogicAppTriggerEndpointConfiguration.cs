using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class LogicAppTriggerEndpointConfiguration : CustomExtensionEndpointConfiguration, IParsable {
        /// <summary>The name of the logic app.</summary>
        public string LogicAppWorkflowName {
            get { return BackingStore?.Get<string>(nameof(LogicAppWorkflowName)); }
            set { BackingStore?.Set(nameof(LogicAppWorkflowName), value); }
        }
        /// <summary>The Azure resource group name for the logic app.</summary>
        public string ResourceGroupName {
            get { return BackingStore?.Get<string>(nameof(ResourceGroupName)); }
            set { BackingStore?.Set(nameof(ResourceGroupName), value); }
        }
        /// <summary>Identifier of the Azure subscription for the logic app.</summary>
        public string SubscriptionId {
            get { return BackingStore?.Get<string>(nameof(SubscriptionId)); }
            set { BackingStore?.Set(nameof(SubscriptionId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LogicAppTriggerEndpointConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LogicAppTriggerEndpointConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"logicAppWorkflowName", n => { LogicAppWorkflowName = n.GetStringValue(); } },
                {"resourceGroupName", n => { ResourceGroupName = n.GetStringValue(); } },
                {"subscriptionId", n => { SubscriptionId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("logicAppWorkflowName", LogicAppWorkflowName);
            writer.WriteStringValue("resourceGroupName", ResourceGroupName);
            writer.WriteStringValue("subscriptionId", SubscriptionId);
        }
    }
}
