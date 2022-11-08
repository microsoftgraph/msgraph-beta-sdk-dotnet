using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.WindowsUpdates {
    public class MonitoringRule : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>The action triggered when the threshold for the given signal is met. Possible values are: alertError, pauseDeployment, unknownFutureValue.</summary>
        public MonitoringAction? Action {
            get { return BackingStore?.Get<MonitoringAction?>("action"); }
            set { BackingStore?.Set("action", value); }
        }
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
        /// <summary>The signal to monitor. Possible values are: rollback, unknownFutureValue.</summary>
        public MonitoringSignal? Signal {
            get { return BackingStore?.Get<MonitoringSignal?>("signal"); }
            set { BackingStore?.Set("signal", value); }
        }
        /// <summary>The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).</summary>
        public int? Threshold {
            get { return BackingStore?.Get<int?>("threshold"); }
            set { BackingStore?.Set("threshold", value); }
        }
        /// <summary>
        /// Instantiates a new monitoringRule and sets the default values.
        /// </summary>
        public MonitoringRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
            OdataType = "#microsoft.graph.windowsUpdates.monitoringRule";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static MonitoringRule CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MonitoringRule();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"action", n => { Action = n.GetEnumValue<MonitoringAction>(); } },
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"signal", n => { Signal = n.GetEnumValue<MonitoringSignal>(); } },
                {"threshold", n => { Threshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MonitoringAction>("action", Action);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteEnumValue<MonitoringSignal>("signal", Signal);
            writer.WriteIntValue("threshold", Threshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
