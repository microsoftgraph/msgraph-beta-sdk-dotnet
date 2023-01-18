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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Settings governing conditions to monitor and automated actions to take.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public MonitoringSettings? Monitoring {
            get { return BackingStore?.Get<MonitoringSettings?>("monitoring"); }
            set { BackingStore?.Set("monitoring", value); }
        }
#else
        public MonitoringSettings Monitoring {
            get { return BackingStore?.Get<MonitoringSettings>("monitoring"); }
            set { BackingStore?.Set("monitoring", value); }
        }
#endif
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>Settings governing how the content is rolled out.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public RolloutSettings? Rollout {
            get { return BackingStore?.Get<RolloutSettings?>("rollout"); }
            set { BackingStore?.Set("rollout", value); }
        }
#else
        public RolloutSettings Rollout {
            get { return BackingStore?.Get<RolloutSettings>("rollout"); }
            set { BackingStore?.Set("rollout", value); }
        }
#endif
        /// <summary>Settings governing safeguard holds on offering content.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
        public SafeguardSettings? Safeguard {
            get { return BackingStore?.Get<SafeguardSettings?>("safeguard"); }
            set { BackingStore?.Set("safeguard", value); }
        }
#else
        public SafeguardSettings Safeguard {
            get { return BackingStore?.Get<SafeguardSettings>("safeguard"); }
            set { BackingStore?.Set("safeguard", value); }
        }
#endif
        /// <summary>
        /// Instantiates a new deploymentSettings and sets the default values.
        /// </summary>
        public DeploymentSettings() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static DeploymentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValue = parseNode.GetChildNode("@odata.type")?.GetStringValue();
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"rollout", n => { Rollout = n.GetObjectValue<RolloutSettings>(RolloutSettings.CreateFromDiscriminatorValue); } },
                {"safeguard", n => { Safeguard = n.GetObjectValue<SafeguardSettings>(SafeguardSettings.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<MonitoringSettings>("monitoring", Monitoring);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<RolloutSettings>("rollout", Rollout);
            writer.WriteObjectValue<SafeguardSettings>("safeguard", Safeguard);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
