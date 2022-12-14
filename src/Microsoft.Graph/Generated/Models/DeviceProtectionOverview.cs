using Microsoft.Kiota.Abstractions.Serialization;
using Microsoft.Kiota.Abstractions.Store;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Hardware information of a given device.
    /// </summary>
    public class DeviceProtectionOverview : IAdditionalDataHolder, IBackedModel, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData {
            get { return BackingStore?.Get<IDictionary<string, object>>("additionalData"); }
            set { BackingStore?.Set("additionalData", value); }
        }
        /// <summary>Stores model information.</summary>
        public IBackingStore BackingStore { get; private set; }
        /// <summary>Clean device count.</summary>
        public int? CleanDeviceCount {
            get { return BackingStore?.Get<int?>("cleanDeviceCount"); }
            set { BackingStore?.Set("cleanDeviceCount", value); }
        }
        /// <summary>Critical failures device count.</summary>
        public int? CriticalFailuresDeviceCount {
            get { return BackingStore?.Get<int?>("criticalFailuresDeviceCount"); }
            set { BackingStore?.Set("criticalFailuresDeviceCount", value); }
        }
        /// <summary>Device with inactive threat agent count</summary>
        public int? InactiveThreatAgentDeviceCount {
            get { return BackingStore?.Get<int?>("inactiveThreatAgentDeviceCount"); }
            set { BackingStore?.Set("inactiveThreatAgentDeviceCount", value); }
        }
        /// <summary>The OdataType property</summary>
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
        /// <summary>Pending full scan device count.</summary>
        public int? PendingFullScanDeviceCount {
            get { return BackingStore?.Get<int?>("pendingFullScanDeviceCount"); }
            set { BackingStore?.Set("pendingFullScanDeviceCount", value); }
        }
        /// <summary>Pending manual steps device count.</summary>
        public int? PendingManualStepsDeviceCount {
            get { return BackingStore?.Get<int?>("pendingManualStepsDeviceCount"); }
            set { BackingStore?.Set("pendingManualStepsDeviceCount", value); }
        }
        /// <summary>Pending offline scan device count.</summary>
        public int? PendingOfflineScanDeviceCount {
            get { return BackingStore?.Get<int?>("pendingOfflineScanDeviceCount"); }
            set { BackingStore?.Set("pendingOfflineScanDeviceCount", value); }
        }
        /// <summary>Pending quick scan device count. Valid values -2147483648 to 2147483647</summary>
        public int? PendingQuickScanDeviceCount {
            get { return BackingStore?.Get<int?>("pendingQuickScanDeviceCount"); }
            set { BackingStore?.Set("pendingQuickScanDeviceCount", value); }
        }
        /// <summary>Pending restart device count.</summary>
        public int? PendingRestartDeviceCount {
            get { return BackingStore?.Get<int?>("pendingRestartDeviceCount"); }
            set { BackingStore?.Set("pendingRestartDeviceCount", value); }
        }
        /// <summary>Device with old signature count.</summary>
        public int? PendingSignatureUpdateDeviceCount {
            get { return BackingStore?.Get<int?>("pendingSignatureUpdateDeviceCount"); }
            set { BackingStore?.Set("pendingSignatureUpdateDeviceCount", value); }
        }
        /// <summary>Total device count.</summary>
        public int? TotalReportedDeviceCount {
            get { return BackingStore?.Get<int?>("totalReportedDeviceCount"); }
            set { BackingStore?.Set("totalReportedDeviceCount", value); }
        }
        /// <summary>Device with threat agent state as unknown count.</summary>
        public int? UnknownStateThreatAgentDeviceCount {
            get { return BackingStore?.Get<int?>("unknownStateThreatAgentDeviceCount"); }
            set { BackingStore?.Set("unknownStateThreatAgentDeviceCount", value); }
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
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
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteIntValue("cleanDeviceCount", CleanDeviceCount);
            writer.WriteIntValue("criticalFailuresDeviceCount", CriticalFailuresDeviceCount);
            writer.WriteIntValue("inactiveThreatAgentDeviceCount", InactiveThreatAgentDeviceCount);
            writer.WriteStringValue("@odata.type", OdataType);
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
