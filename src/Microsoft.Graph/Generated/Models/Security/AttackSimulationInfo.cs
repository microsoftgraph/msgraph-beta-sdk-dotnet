using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class AttackSimulationInfo : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>The date and time of the attack simulation.</summary>
        public DateTimeOffset? AttackSimDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("attackSimDateTime"); }
            set { BackingStore?.Set("attackSimDateTime", value); }
        }
        /// <summary>The duration (in time) for the attack simulation.</summary>
        public TimeSpan? AttackSimDurationTime {
            get { return BackingStore?.Get<TimeSpan?>("attackSimDurationTime"); }
            set { BackingStore?.Set("attackSimDurationTime", value); }
        }
        /// <summary>The activity ID for the attack simulation.</summary>
        public string AttackSimId {
            get { return BackingStore?.Get<string>("attackSimId"); }
            set { BackingStore?.Set("attackSimId", value); }
        }
        /// <summary>The unique identifier for the user who got the attack simulation email.</summary>
        public string AttackSimUserId {
            get { return BackingStore?.Get<string>("attackSimUserId"); }
            set { BackingStore?.Set("attackSimUserId", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>
        /// Instantiates a new attackSimulationInfo and sets the default values.
        /// </summary>
        public AttackSimulationInfo() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.security.attackSimulationInfo";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static AttackSimulationInfo CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AttackSimulationInfo();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"attackSimDateTime", n => { AttackSimDateTime = n.GetDateTimeOffsetValue(); } },
                {"attackSimDurationTime", n => { AttackSimDurationTime = n.GetTimeSpanValue(); } },
                {"attackSimId", n => { AttackSimId = n.GetStringValue(); } },
                {"attackSimUserId", n => { AttackSimUserId = n.GetStringValue(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteDateTimeOffsetValue("attackSimDateTime", AttackSimDateTime);
            writer.WriteTimeSpanValue("attackSimDurationTime", AttackSimDurationTime);
            writer.WriteStringValue("attackSimId", AttackSimId);
            writer.WriteStringValue("attackSimUserId", AttackSimUserId);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
