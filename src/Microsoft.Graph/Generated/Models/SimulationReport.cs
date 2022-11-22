using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SimulationReport : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Overview of an attack simulation and training campaign.</summary>
        public SimulationReportOverview Overview {
            get { return BackingStore?.Get<SimulationReportOverview>("overview"); }
            set { BackingStore?.Set("overview", value); }
        }
        /// <summary>The tenant users and their online actions in an attack simulation and training campaign.</summary>
        public List<UserSimulationDetails> SimulationUsers {
            get { return BackingStore?.Get<List<UserSimulationDetails>>("simulationUsers"); }
            set { BackingStore?.Set("simulationUsers", value); }
        }
        /// <summary>
        /// Instantiates a new simulationReport and sets the default values.
        /// </summary>
        public SimulationReport() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static SimulationReport CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SimulationReport();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"overview", n => { Overview = n.GetObjectValue<SimulationReportOverview>(SimulationReportOverview.CreateFromDiscriminatorValue); } },
                {"simulationUsers", n => { SimulationUsers = n.GetCollectionOfObjectValues<UserSimulationDetails>(UserSimulationDetails.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteObjectValue<SimulationReportOverview>("overview", Overview);
            writer.WriteCollectionOfObjectValues<UserSimulationDetails>("simulationUsers", SimulationUsers);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
