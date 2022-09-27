using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WindowsAutopilotSettings : Entity, IParsable {
        /// <summary>Last data sync date time with DDS service.</summary>
        public DateTimeOffset? LastManualSyncTriggerDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastManualSyncTriggerDateTime"); }
            set { BackingStore?.Set("lastManualSyncTriggerDateTime", value); }
        }
        /// <summary>Last data sync date time with DDS service.</summary>
        public DateTimeOffset? LastSyncDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastSyncDateTime"); }
            set { BackingStore?.Set("lastSyncDateTime", value); }
        }
        /// <summary>The syncStatus property</summary>
        public WindowsAutopilotSyncStatus? SyncStatus {
            get { return BackingStore?.Get<WindowsAutopilotSyncStatus?>("syncStatus"); }
            set { BackingStore?.Set("syncStatus", value); }
        }
        /// <summary>
        /// Instantiates a new WindowsAutopilotSettings and sets the default values.
        /// </summary>
        public WindowsAutopilotSettings() : base() {
            OdataType = "#microsoft.graph.windowsAutopilotSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WindowsAutopilotSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WindowsAutopilotSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"lastManualSyncTriggerDateTime", n => { LastManualSyncTriggerDateTime = n.GetDateTimeOffsetValue(); } },
                {"lastSyncDateTime", n => { LastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"syncStatus", n => { SyncStatus = n.GetEnumValue<WindowsAutopilotSyncStatus>(); } },
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
