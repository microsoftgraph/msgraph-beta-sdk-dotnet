using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph.WindowsUpdates {
    public class DeploymentSettings : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Settings governing conditions to monitor and automated actions to take.</summary>
        public MonitoringSettings Monitoring { get; set; }
        /// <summary>Settings governing how the content is rolled out.</summary>
        public RolloutSettings Rollout { get; set; }
        /// <summary>Settings governing safeguard holds on offering content.</summary>
        public SafeguardSettings Safeguard { get; set; }
        /// <summary>
        /// Instantiates a new deploymentSettings and sets the default values.
        /// </summary>
        public DeploymentSettings() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeploymentSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeploymentSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"monitoring", (o,n) => { (o as DeploymentSettings).Monitoring = n.GetObjectValue<MonitoringSettings>(MonitoringSettings.CreateFromDiscriminatorValue); } },
                {"rollout", (o,n) => { (o as DeploymentSettings).Rollout = n.GetObjectValue<RolloutSettings>(RolloutSettings.CreateFromDiscriminatorValue); } },
                {"safeguard", (o,n) => { (o as DeploymentSettings).Safeguard = n.GetObjectValue<SafeguardSettings>(SafeguardSettings.CreateFromDiscriminatorValue); } },
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
