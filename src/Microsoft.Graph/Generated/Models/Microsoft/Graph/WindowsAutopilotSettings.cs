using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class WindowsAutopilotSettings : Entity, IParsable {
        /// <summary>Last data sync date time with DDS service.</summary>
        public DateTimeOffset? LastManualSyncTriggerDateTime { get; set; }
        /// <summary>Last data sync date time with DDS service.</summary>
        public DateTimeOffset? LastSyncDateTime { get; set; }
        /// <summary>Indicates the status of sync with Device data sync (DDS) service. Possible values are: unknown, inProgress, completed, failed.</summary>
        public WindowsAutopilotSyncStatus? SyncStatus { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"lastManualSyncTriggerDateTime", (o,n) => { (o as WindowsAutopilotSettings).LastManualSyncTriggerDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", (o,n) => { (o as WindowsAutopilotSettings).LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"syncStatus", (o,n) => { (o as WindowsAutopilotSettings).SyncStatus = n.GetEnumValue<WindowsAutopilotSyncStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("lastManualSyncTriggerDateTime", LastManualSyncTriggerDateTime);
            writer.WriteDateTimeOffsetValue("lastSyncDateTime", LastSyncDateTime);
            writer.WriteEnumValue<WindowsAutopilotSyncStatus>("syncStatus", SyncStatus);
        }
    }
}
