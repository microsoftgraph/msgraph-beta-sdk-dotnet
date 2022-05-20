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
            get { return BackingStore?.Get<MonitoringAction?>(nameof(Action)); }
            set { BackingStore?.Set(nameof(Action), value); }
        }
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>The signal to monitor. Possible values are: rollback, unknownFutureValue.</summary>
        public MonitoringSignal? Signal {
            get { return BackingStore?.Get<MonitoringSignal?>(nameof(Signal)); }
            set { BackingStore?.Set(nameof(Signal), value); }
        }
        /// <summary>The threshold for a signal at which to trigger action. An integer from 1 to 100 (inclusive).</summary>
        public int? Threshold {
            get { return BackingStore?.Get<int?>(nameof(Threshold)); }
            set { BackingStore?.Set(nameof(Threshold), value); }
        }
        /// <summary>
        /// Instantiates a new monitoringRule and sets the default values.
        /// </summary>
        public MonitoringRule() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
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
                {"signal", n => { Signal = n.GetEnumValue<MonitoringSignal>(); } },
                {"threshold", n => { Threshold = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<MonitoringAction>("action", Action);
            writer.WriteEnumValue<MonitoringSignal>("signal", Signal);
            writer.WriteIntValue("threshold", Threshold);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
