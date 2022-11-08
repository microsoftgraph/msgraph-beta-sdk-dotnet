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
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The compute property</summary>
        public TeamworkPeripheral Compute {
            get { return BackingStore?.Get<TeamworkPeripheral>("compute"); }
            set { BackingStore?.Set("compute", value); }
        }
        /// <summary>The hdmiIngest property</summary>
        public TeamworkPeripheral HdmiIngest {
            get { return BackingStore?.Get<TeamworkPeripheral>("hdmiIngest"); }
            set { BackingStore?.Set("hdmiIngest", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The CPU model on the device.</summary>
        public string ProcessorModel {
            get { return BackingStore?.Get<string>("processorModel"); }
            set { BackingStore?.Set("processorModel", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkHardwareConfiguration and sets the default values.
        /// </summary>
        public TeamworkHardwareConfiguration() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkHardwareConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"processorModel", n => { ProcessorModel = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkPeripheral>("compute", Compute);
            writer.WriteObjectValue<TeamworkPeripheral>("hdmiIngest", HdmiIngest);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteStringValue("processorModel", ProcessorModel);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
