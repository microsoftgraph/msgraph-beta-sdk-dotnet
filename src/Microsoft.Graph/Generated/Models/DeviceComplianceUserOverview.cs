using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the deviceManagement singleton.</summary>
    public class DeviceComplianceUserOverview : Entity, IParsable {
        /// <summary>Version of the policy for that overview</summary>
        public int? ConfigurationVersion {
            get { return BackingStore?.Get<int?>(nameof(ConfigurationVersion)); }
            set { BackingStore?.Set(nameof(ConfigurationVersion), value); }
        }
        /// <summary>Number of users in conflict</summary>
        public int? ConflictCount {
            get { return BackingStore?.Get<int?>(nameof(ConflictCount)); }
            set { BackingStore?.Set(nameof(ConflictCount), value); }
        }
        /// <summary>Number of error Users</summary>
        public int? ErrorCount {
            get { return BackingStore?.Get<int?>(nameof(ErrorCount)); }
            set { BackingStore?.Set(nameof(ErrorCount), value); }
        }
        /// <summary>Number of failed Users</summary>
        public int? FailedCount {
            get { return BackingStore?.Get<int?>(nameof(FailedCount)); }
            set { BackingStore?.Set(nameof(FailedCount), value); }
        }
        /// <summary>Last update time</summary>
        public DateTimeOffset? LastUpdateDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdateDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdateDateTime), value); }
        }
        /// <summary>Number of not applicable users</summary>
        public int? NotApplicableCount {
            get { return BackingStore?.Get<int?>(nameof(NotApplicableCount)); }
            set { BackingStore?.Set(nameof(NotApplicableCount), value); }
        }
        /// <summary>Number of pending Users</summary>
        public int? PendingCount {
            get { return BackingStore?.Get<int?>(nameof(PendingCount)); }
            set { BackingStore?.Set(nameof(PendingCount), value); }
        }
        /// <summary>Number of succeeded Users</summary>
        public int? SuccessCount {
            get { return BackingStore?.Get<int?>(nameof(SuccessCount)); }
            set { BackingStore?.Set(nameof(SuccessCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceComplianceUserOverview CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceComplianceUserOverview();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"configurationVersion", n => { ConfigurationVersion = n.GetIntValue(); } },
                {"conflictCount", n => { ConflictCount = n.GetIntValue(); } },
                {"errorCount", n => { ErrorCount = n.GetIntValue(); } },
                {"failedCount", n => { FailedCount = n.GetIntValue(); } },
                {"lastUpdateDateTime", n => { LastUpdateDateTime = n.GetDateTimeOffsetValue(); } },
                {"notApplicableCount", n => { NotApplicableCount = n.GetIntValue(); } },
                {"pendingCount", n => { PendingCount = n.GetIntValue(); } },
                {"successCount", n => { SuccessCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("configurationVersion", ConfigurationVersion);
            writer.WriteIntValue("conflictCount", ConflictCount);
            writer.WriteIntValue("errorCount", ErrorCount);
            writer.WriteIntValue("failedCount", FailedCount);
            writer.WriteDateTimeOffsetValue("lastUpdateDateTime", LastUpdateDateTime);
            writer.WriteIntValue("notApplicableCount", NotApplicableCount);
            writer.WriteIntValue("pendingCount", PendingCount);
            writer.WriteIntValue("successCount", SuccessCount);
        }
    }
}
