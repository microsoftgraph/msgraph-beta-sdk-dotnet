using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Reports.Security.GetAttackSimulationTrainingUserCoverage {
    /// <summary>Provides operations to call the getAttackSimulationTrainingUserCoverage method.</summary>
    public class GetAttackSimulationTrainingUserCoverageResponse : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The value property</summary>
        public List<AttackSimulationTrainingUserCoverage> Value {
            get { return BackingStore?.Get<List<AttackSimulationTrainingUserCoverage>>("value"); }
            set { BackingStore?.Set("value", value); }
        }
        /// <summary>
        /// Instantiates a new getAttackSimulationTrainingUserCoverageResponse and sets the default values.
        /// </summary>
        public GetAttackSimulationTrainingUserCoverageResponse() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static GetAttackSimulationTrainingUserCoverageResponse CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new GetAttackSimulationTrainingUserCoverageResponse();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"value", n => { Value = n.GetCollectionOfObjectValues<AttackSimulationTrainingUserCoverage>(AttackSimulationTrainingUserCoverage.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteCollectionOfObjectValues<AttackSimulationTrainingUserCoverage>("value", Value);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
