using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkHardwareConfiguration : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The compute property</summary>
        public TeamworkPeripheral Compute {
            get { return BackingStore?.Get<TeamworkPeripheral>(nameof(Compute)); }
            set { BackingStore?.Set(nameof(Compute), value); }
        }
        /// <summary>The hdmiIngest property</summary>
        public TeamworkPeripheral HdmiIngest {
            get { return BackingStore?.Get<TeamworkPeripheral>(nameof(HdmiIngest)); }
            set { BackingStore?.Set(nameof(HdmiIngest), value); }
        }
        /// <summary>The CPU model on the device.</summary>
        public string ProcessorModel {
            get { return BackingStore?.Get<string>(nameof(ProcessorModel)); }
            set { BackingStore?.Set(nameof(ProcessorModel), value); }
        }
        /// <summary>
        /// Instantiates a new teamworkHardwareConfiguration and sets the default values.
        /// </summary>
        public TeamworkHardwareConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkHardwareConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkHardwareConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"compute", n => { Compute = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"hdmiIngest", n => { HdmiIngest = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
                {"processorModel", n => { ProcessorModel = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("compute", Compute);
            writer.WriteObjectValue<TeamworkPeripheral>("hdmiIngest", HdmiIngest);
            writer.WriteStringValue("processorModel", ProcessorModel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
