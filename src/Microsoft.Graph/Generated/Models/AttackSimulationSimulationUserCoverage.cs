using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AttackSimulationSimulationUserCoverage : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>User in an attack simulation and training campaign.</summary>
        public Microsoft.Graph.Beta.Models.AttackSimulationUser AttackSimulationUser {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.AttackSimulationUser>(nameof(AttackSimulationUser)); }
            set { BackingStore?.Set(nameof(AttackSimulationUser), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Number of link clicks in the received payloads by the user in attack simulation and training campaigns.</summary>
        public int? ClickCount {
            get { return BackingStore?.Get<int?>(nameof(ClickCount)); }
            set { BackingStore?.Set(nameof(ClickCount), value); }
        }
        /// <summary>Number of compromising actions by the user in attack simulation and training campaigns.</summary>
        public int? CompromisedCount {
            get { return BackingStore?.Get<int?>(nameof(CompromisedCount)); }
            set { BackingStore?.Set(nameof(CompromisedCount), value); }
        }
        /// <summary>Date and time of latest attack simulation and training campaign that the user was included in.</summary>
        public DateTimeOffset? LatestSimulationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LatestSimulationDateTime)); }
            set { BackingStore?.Set(nameof(LatestSimulationDateTime), value); }
        }
        /// <summary>Number of attack simulation and training campaigns that the user was included in.</summary>
        public int? SimulationCount {
            get { return BackingStore?.Get<int?>(nameof(SimulationCount)); }
            set { BackingStore?.Set(nameof(SimulationCount), value); }
        }
        /// <summary>
        /// Instantiates a new attackSimulationSimulationUserCoverage and sets the default values.
        /// </summary>
        public AttackSimulationSimulationUserCoverage() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AttackSimulationSimulationUserCoverage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationSimulationUserCoverage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attackSimulationUser", n => { AttackSimulationUser = n.GetObjectValue<Microsoft.Graph.Beta.Models.AttackSimulationUser>(Microsoft.Graph.Beta.Models.AttackSimulationUser.CreateFromDiscriminatorValue); } },
                {"clickCount", n => { ClickCount = n.GetIntValue(); } },
                {"compromisedCount", n => { CompromisedCount = n.GetIntValue(); } },
                {"latestSimulationDateTime", n => { LatestSimulationDateTime = n.GetDateTimeOffsetValue(); } },
                {"simulationCount", n => { SimulationCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.AttackSimulationUser>("attackSimulationUser", AttackSimulationUser);
            writer.WriteIntValue("clickCount", ClickCount);
            writer.WriteIntValue("compromisedCount", CompromisedCount);
            writer.WriteDateTimeOffsetValue("latestSimulationDateTime", LatestSimulationDateTime);
            writer.WriteIntValue("simulationCount", SimulationCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
