using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceProtectionOverview : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Clean device count.</summary>
        public int? CleanDeviceCount { get; set; }
        /// <summary>Critical failures device count.</summary>
        public int? CriticalFailuresDeviceCount { get; set; }
        /// <summary>Device with inactive threat agent count</summary>
        public int? InactiveThreatAgentDeviceCount { get; set; }
        /// <summary>Pending full scan device count.</summary>
        public int? PendingFullScanDeviceCount { get; set; }
        /// <summary>Pending manual steps device count.</summary>
        public int? PendingManualStepsDeviceCount { get; set; }
        /// <summary>Pending offline scan device count.</summary>
        public int? PendingOfflineScanDeviceCount { get; set; }
        /// <summary>Pending quick scan device count. Valid values -2147483648 to 2147483647</summary>
        public int? PendingQuickScanDeviceCount { get; set; }
        /// <summary>Pending restart device count.</summary>
        public int? PendingRestartDeviceCount { get; set; }
        /// <summary>Device with old signature count.</summary>
        public int? PendingSignatureUpdateDeviceCount { get; set; }
        /// <summary>Total device count.</summary>
        public int? TotalReportedDeviceCount { get; set; }
        /// <summary>Device with threat agent state as unknown count.</summary>
        public int? UnknownStateThreatAgentDeviceCount { get; set; }
        /// <summary>
        /// Instantiates a new deviceProtectionOverview and sets the default values.
        /// </summary>
        public DeviceProtectionOverview() {
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
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"cleanDeviceCount", (o,n) => { (o as DeviceProtectionOverview).CleanDeviceCount = n.GetIntValue(); } },
                {"criticalFailuresDeviceCount", (o,n) => { (o as DeviceProtectionOverview).CriticalFailuresDeviceCount = n.GetIntValue(); } },
                {"inactiveThreatAgentDeviceCount", (o,n) => { (o as DeviceProtectionOverview).InactiveThreatAgentDeviceCount = n.GetIntValue(); } },
                {"pendingFullScanDeviceCount", (o,n) => { (o as DeviceProtectionOverview).PendingFullScanDeviceCount = n.GetIntValue(); } },
                {"pendingManualStepsDeviceCount", (o,n) => { (o as DeviceProtectionOverview).PendingManualStepsDeviceCount = n.GetIntValue(); } },
                {"pendingOfflineScanDeviceCount", (o,n) => { (o as DeviceProtectionOverview).PendingOfflineScanDeviceCount = n.GetIntValue(); } },
                {"pendingQuickScanDeviceCount", (o,n) => { (o as DeviceProtectionOverview).PendingQuickScanDeviceCount = n.GetIntValue(); } },
                {"pendingRestartDeviceCount", (o,n) => { (o as DeviceProtectionOverview).PendingRestartDeviceCount = n.GetIntValue(); } },
                {"pendingSignatureUpdateDeviceCount", (o,n) => { (o as DeviceProtectionOverview).PendingSignatureUpdateDeviceCount = n.GetIntValue(); } },
                {"totalReportedDeviceCount", (o,n) => { (o as DeviceProtectionOverview).TotalReportedDeviceCount = n.GetIntValue(); } },
                {"unknownStateThreatAgentDeviceCount", (o,n) => { (o as DeviceProtectionOverview).UnknownStateThreatAgentDeviceCount = n.GetIntValue(); } },
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
