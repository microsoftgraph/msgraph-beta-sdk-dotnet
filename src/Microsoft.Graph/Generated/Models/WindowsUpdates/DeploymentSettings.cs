using Microsoft.Graph.Beta.Models.WindowsUpdates;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class DeploymentSettings : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Settings governing conditions to monitor and automated actions to take.</summary>
        public MonitoringSettings Monitoring {
            get { return BackingStore?.Get<MonitoringSettings>(nameof(Monitoring)); }
            set { BackingStore?.Set(nameof(Monitoring), value); }
        }
        /// <summary>Settings governing how the content is rolled out.</summary>
        public RolloutSettings Rollout {
            get { return BackingStore?.Get<RolloutSettings>(nameof(Rollout)); }
            set { BackingStore?.Set(nameof(Rollout), value); }
        }
        /// <summary>Settings governing safeguard holds on offering content.</summary>
        public SafeguardSettings Safeguard {
            get { return BackingStore?.Get<SafeguardSettings>(nameof(Safeguard)); }
            set { BackingStore?.Set(nameof(Safeguard), value); }
        }
        /// <summary>
        /// Instantiates a new deploymentSettings and sets the default values.
        /// </summary>
        public DeploymentSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeploymentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.windowsUpdates.windowsDeploymentSettings" => new WindowsDeploymentSettings(),
                _ => new DeploymentSettings(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"monitoring", n => { Monitoring = n.GetObjectValue<MonitoringSettings>(MonitoringSettings.CreateFromDiscriminatorValue); } },
                {"rollout", n => { Rollout = n.GetObjectValue<RolloutSettings>(RolloutSettings.CreateFromDiscriminatorValue); } },
                {"safeguard", n => { Safeguard = n.GetObjectValue<SafeguardSettings>(SafeguardSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MonitoringSettings>("monitoring", Monitoring);
            writer.WriteObjectValue<RolloutSettings>("rollout", Rollout);
            writer.WriteObjectValue<SafeguardSettings>("safeguard", Safeguard);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
