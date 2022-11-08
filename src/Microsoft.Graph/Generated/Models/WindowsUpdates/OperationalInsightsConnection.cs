using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class OperationalInsightsConnection : ResourceConnection, IParsable {
        /// <summary>The name of the Azure resource group that contains the Log Analytics workspace.</summary>
        public string AzureResourceGroupName {
            get { return BackingStore?.Get<string>("azureResourceGroupName"); }
            set { BackingStore?.Set("azureResourceGroupName", value); }
        }
        /// <summary>The Azure subscription ID that contains the Log Analytics workspace.</summary>
        public string AzureSubscriptionId {
            get { return BackingStore?.Get<string>("azureSubscriptionId"); }
            set { BackingStore?.Set("azureSubscriptionId", value); }
        }
        /// <summary>The name of the Log Analytics workspace.</summary>
        public string WorkspaceName {
            get { return BackingStore?.Get<string>("workspaceName"); }
            set { BackingStore?.Set("workspaceName", value); }
        }
        /// <summary>
        /// Instantiates a new OperationalInsightsConnection and sets the default values.
        /// </summary>
        public OperationalInsightsConnection() : base() {
            OdataType = "#microsoft.graph.windowsUpdates.operationalInsightsConnection";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("azureResourceGroupName", AzureResourceGroupName);
            writer.WriteStringValue("azureSubscriptionId", AzureSubscriptionId);
            writer.WriteStringValue("workspaceName", WorkspaceName);
        }
    }
}
