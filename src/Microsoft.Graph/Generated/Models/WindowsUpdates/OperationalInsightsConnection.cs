using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class OperationalInsightsConnection : ResourceConnection, IParsable {
        /// <summary>The azureResourceGroupName property</summary>
        public string AzureResourceGroupName {
            get { return BackingStore?.Get<string>(nameof(AzureResourceGroupName)); }
            set { BackingStore?.Set(nameof(AzureResourceGroupName), value); }
        }
        /// <summary>The azureSubscriptionId property</summary>
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>(nameof(AzureSubscriptionId)); }
            set { BackingStore?.Set(nameof(AzureSubscriptionId), value); }
        }
        /// <summary>The workspaceName property</summary>
        public string WorkspaceName {
            get { return BackingStore?.Get<string>(nameof(WorkspaceName)); }
            set { BackingStore?.Set(nameof(WorkspaceName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new OperationalInsightsConnection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new OperationalInsightsConnection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"azureResourceGroupName", n => { AzureResourceGroupName = n.GetStringValue(); } },
                {"azureSubscriptionId", n => { AzureSubscriptionId = n.GetStringValue(); } },
                {"workspaceName", n => { WorkspaceName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureResourceGroupName", AzureResourceGroupName);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("workspaceName", WorkspaceName);
        }
    }
}
