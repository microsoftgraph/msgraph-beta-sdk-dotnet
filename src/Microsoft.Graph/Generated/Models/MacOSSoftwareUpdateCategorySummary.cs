using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>MacOS software update category summary report for a device and user</summary>
    public class MacOSSoftwareUpdateCategorySummary : Entity, IParsable {
        /// <summary>The device ID.</summary>
        public string DeviceId {
            get { return BackingStore?.Get<string>(nameof(DeviceId)); }
            set { BackingStore?.Set(nameof(DeviceId), value); }
        }
        /// <summary>The name of the report</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Number of failed updates on the device</summary>
        public int? FailedUpdateCount {
            get { return BackingStore?.Get<int?>(nameof(FailedUpdateCount)); }
            set { BackingStore?.Set(nameof(FailedUpdateCount), value); }
        }
        /// <summary>Last date time the report for this device was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>Number of successful updates on the device</summary>
        public int? SuccessfulUpdateCount {
            get { return BackingStore?.Get<int?>(nameof(SuccessfulUpdateCount)); }
            set { BackingStore?.Set(nameof(SuccessfulUpdateCount), value); }
        }
        /// <summary>Number of total updates on the device</summary>
        public int? TotalUpdateCount {
            get { return BackingStore?.Get<int?>(nameof(TotalUpdateCount)); }
            set { BackingStore?.Set(nameof(TotalUpdateCount), value); }
        }
        /// <summary>Software update type. Possible values are: critical, configurationDataFile, firmware, other.</summary>
        public MacOSSoftwareUpdateCategory? UpdateCategory {
            get { return BackingStore?.Get<MacOSSoftwareUpdateCategory?>(nameof(UpdateCategory)); }
            set { BackingStore?.Set(nameof(UpdateCategory), value); }
        }
        /// <summary>Summary of the update states.</summary>
        public List<MacOSSoftwareUpdateStateSummary> UpdateStateSummaries {
            get { return BackingStore?.Get<List<MacOSSoftwareUpdateStateSummary>>(nameof(UpdateStateSummaries)); }
            set { BackingStore?.Set(nameof(UpdateStateSummaries), value); }
        }
        /// <summary>The user ID.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSSoftwareUpdateCategorySummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSSoftwareUpdateCategorySummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceId", n => { DeviceId = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"failedUpdateCount", n => { FailedUpdateCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulUpdateCount", n => { SuccessfulUpdateCount = n.GetIntValue(); } },
                {"totalUpdateCount", n => { TotalUpdateCount = n.GetIntValue(); } },
                {"updateCategory", n => { UpdateCategory = n.GetEnumValue<MacOSSoftwareUpdateCategory>(); } },
                {"updateStateSummaries", n => { UpdateStateSummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateStateSummary>(MacOSSoftwareUpdateStateSummary.CreateFromDiscriminatorValue).ToList(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("deviceId", DeviceId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteIntValue("failedUpdateCount", FailedUpdateCount);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteIntValue("successfulUpdateCount", SuccessfulUpdateCount);
            writer.WriteIntValue("totalUpdateCount", TotalUpdateCount);
            writer.WriteEnumValue<MacOSSoftwareUpdateCategory>("updateCategory", UpdateCategory);
            writer.WriteCollectionOfObjectValues<MacOSSoftwareUpdateStateSummary>("updateStateSummaries", UpdateStateSummaries);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
