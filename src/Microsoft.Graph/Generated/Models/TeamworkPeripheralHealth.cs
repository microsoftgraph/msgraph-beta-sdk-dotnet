using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class TeamworkPeripheralHealth : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The connected state and time since the peripheral device was connected.</summary>
        public TeamworkConnection Connection {
            get { return BackingStore?.Get<TeamworkConnection>("connection"); }
            set { BackingStore?.Set("connection", value); }
        }
        /// <summary>True if the peripheral is optional. Used for health computation.</summary>
        public bool? IsOptional {
            get { return BackingStore?.Get<bool?>("isOptional"); }
            set { BackingStore?.Set("isOptional", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>The peripheral property</summary>
        public TeamworkPeripheral Peripheral {
            get { return BackingStore?.Get<TeamworkPeripheral>("peripheral"); }
            set { BackingStore?.Set("peripheral", value); }
        }
        /// <summary>
        /// Instantiates a new teamworkPeripheralHealth and sets the default values.
        /// </summary>
        public TeamworkPeripheralHealth() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.teamworkPeripheralHealth";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static TeamworkPeripheralHealth CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TeamworkPeripheralHealth();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"connection", n => { Connection = n.GetObjectValue<TeamworkConnection>(TeamworkConnection.CreateFromDiscriminatorValue); } },
                {"isOptional", n => { IsOptional = n.GetBoolValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"peripheral", n => { Peripheral = n.GetObjectValue<TeamworkPeripheral>(TeamworkPeripheral.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<TeamworkConnection>("connection", Connection);
            writer.WriteBoolValue("isOptional", IsOptional);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<TeamworkPeripheral>("peripheral", Peripheral);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
