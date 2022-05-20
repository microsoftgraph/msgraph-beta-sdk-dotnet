using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Hardware information of a given device.</summary>
    public class DeviceProtectionOverview : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>(nameof(AdditionalData)); }
            set { BackingStore?.Set(nameof(AdditionalData), value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Clean device count.</summary>
        public int? CleanDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(CleanDeviceCount)); }
            set { BackingStore?.Set(nameof(CleanDeviceCount), value); }
        }
        /// <summary>Critical failures device count.</summary>
        public int? CriticalFailuresDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(CriticalFailuresDeviceCount)); }
            set { BackingStore?.Set(nameof(CriticalFailuresDeviceCount), value); }
        }
        /// <summary>Device with inactive threat agent count</summary>
        public int? InactiveThreatAgentDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(InactiveThreatAgentDeviceCount)); }
            set { BackingStore?.Set(nameof(InactiveThreatAgentDeviceCount), value); }
        }
        /// <summary>Pending full scan device count.</summary>
        public int? PendingFullScanDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingFullScanDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingFullScanDeviceCount), value); }
        }
        /// <summary>Pending manual steps device count.</summary>
        public int? PendingManualStepsDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingManualStepsDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingManualStepsDeviceCount), value); }
        }
        /// <summary>Pending offline scan device count.</summary>
        public int? PendingOfflineScanDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingOfflineScanDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingOfflineScanDeviceCount), value); }
        }
        /// <summary>Pending quick scan device count. Valid values -2147483648 to 2147483647</summary>
        public int? PendingQuickScanDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingQuickScanDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingQuickScanDeviceCount), value); }
        }
        /// <summary>Pending restart device count.</summary>
        public int? PendingRestartDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingRestartDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingRestartDeviceCount), value); }
        }
        /// <summary>Device with old signature count.</summary>
        public int? PendingSignatureUpdateDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(PendingSignatureUpdateDeviceCount)); }
            set { BackingStore?.Set(nameof(PendingSignatureUpdateDeviceCount), value); }
        }
        /// <summary>Total device count.</summary>
        public int? TotalReportedDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(TotalReportedDeviceCount)); }
            set { BackingStore?.Set(nameof(TotalReportedDeviceCount), value); }
        }
        /// <summary>Device with threat agent state as unknown count.</summary>
        public int? UnknownStateThreatAgentDeviceCount {
            get { return BackingStore?.Get<int?>(nameof(UnknownStateThreatAgentDeviceCount)); }
            set { BackingStore?.Set(nameof(UnknownStateThreatAgentDeviceCount), value); }
        }
        /// <summary>
        /// Instantiates a new deviceProtectionOverview and sets the default values.
        /// </summary>
        public DeviceProtectionOverview() {
            BackingStore = BackingStoreFactorySingleton.Instance.CreateBackingStore();
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static DeviceProtectionOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceProtectionOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"cleanDeviceCount", n => { CleanDeviceCount = n.GetIntValue(); } },
                {"criticalFailuresDeviceCount", n => { CriticalFailuresDeviceCount = n.GetIntValue(); } },
                {"inactiveThreatAgentDeviceCount", n => { InactiveThreatAgentDeviceCount = n.GetIntValue(); } },
                {"pendingFullScanDeviceCount", n => { PendingFullScanDeviceCount = n.GetIntValue(); } },
                {"pendingManualStepsDeviceCount", n => { PendingManualStepsDeviceCount = n.GetIntValue(); } },
                {"pendingOfflineScanDeviceCount", n => { PendingOfflineScanDeviceCount = n.GetIntValue(); } },
                {"pendingQuickScanDeviceCount", n => { PendingQuickScanDeviceCount = n.GetIntValue(); } },
                {"pendingRestartDeviceCount", n => { PendingRestartDeviceCount = n.GetIntValue(); } },
                {"pendingSignatureUpdateDeviceCount", n => { PendingSignatureUpdateDeviceCount = n.GetIntValue(); } },
                {"totalReportedDeviceCount", n => { TotalReportedDeviceCount = n.GetIntValue(); } },
                {"unknownStateThreatAgentDeviceCount", n => { UnknownStateThreatAgentDeviceCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("cleanDeviceCount", CleanDeviceCount);
            writer.WriteIntValue("criticalFailuresDeviceCount", CriticalFailuresDeviceCount);
            writer.WriteIntValue("inactiveThreatAgentDeviceCount", InactiveThreatAgentDeviceCount);
            writer.WriteIntValue("pendingFullScanDeviceCount", PendingFullScanDeviceCount);
            writer.WriteIntValue("pendingManualStepsDeviceCount", PendingManualStepsDeviceCount);
            writer.WriteIntValue("pendingOfflineScanDeviceCount", PendingOfflineScanDeviceCount);
            writer.WriteIntValue("pendingQuickScanDeviceCount", PendingQuickScanDeviceCount);
            writer.WriteIntValue("pendingRestartDeviceCount", PendingRestartDeviceCount);
            writer.WriteIntValue("pendingSignatureUpdateDeviceCount", PendingSignatureUpdateDeviceCount);
            writer.WriteIntValue("totalReportedDeviceCount", TotalReportedDeviceCount);
            writer.WriteIntValue("unknownStateThreatAgentDeviceCount", UnknownStateThreatAgentDeviceCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
