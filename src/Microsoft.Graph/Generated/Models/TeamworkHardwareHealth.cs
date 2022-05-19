using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkHardwareHealth : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The system health details for a teamworkDevice.</summary>
        public TeamworkPeripheralHealth ComputeHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>(nameof(ComputeHealth)); }
            set { BackingStore?.Set(nameof(ComputeHealth), value); }
        }
        /// <summary>The health details about the HDMI ingest of a device.</summary>
        public TeamworkPeripheralHealth HdmiIngestHealth {
            get { return BackingStore?.Get<TeamworkPeripheralHealth>(nameof(HdmiIngestHealth)); }
            set { BackingStore?.Set(nameof(HdmiIngestHealth), value); }
        }
        /// <summary>
        /// Instantiates a new teamworkHardwareHealth and sets the default values.
        /// </summary>
        public TeamworkHardwareHealth() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkHardwareHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkHardwareHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"computeHealth", n => { ComputeHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
                {"hdmiIngestHealth", n => { HdmiIngestHealth = n.GetObjectValue<TeamworkPeripheralHealth>(TeamworkPeripheralHealth.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheralHealth>("computeHealth", ComputeHealth);
            writer.WriteObjectValue<TeamworkPeripheralHealth>("hdmiIngestHealth", HdmiIngestHealth);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
