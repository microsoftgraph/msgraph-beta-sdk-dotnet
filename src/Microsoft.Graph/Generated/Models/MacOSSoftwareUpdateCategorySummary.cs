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
            get { return BackingStore?.Get<string>("deviceId"); }
            set { BackingStore?.Set("deviceId", value); }
        }
        /// <summary>The name of the report</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>Number of failed updates on the device</summary>
        public int? FailedUpdateCount {
            get { return BackingStore?.Get<int?>("failedUpdateCount"); }
            set { BackingStore?.Set("failedUpdateCount", value); }
        }
        /// <summary>Last date time the report for this device was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastUpdatedDateTime"); }
            set { BackingStore?.Set("lastUpdatedDateTime", value); }
        }
        /// <summary>Number of successful updates on the device</summary>
        public int? SuccessfulUpdateCount {
            get { return BackingStore?.Get<int?>("successfulUpdateCount"); }
            set { BackingStore?.Set("successfulUpdateCount", value); }
        }
        /// <summary>Number of total updates on the device</summary>
        public int? TotalUpdateCount {
            get { return BackingStore?.Get<int?>("totalUpdateCount"); }
            set { BackingStore?.Set("totalUpdateCount", value); }
        }
        /// <summary>MacOS Software Update Category</summary>
        public MacOSSoftwareUpdateCategory? UpdateCategory {
            get { return BackingStore?.Get<MacOSSoftwareUpdateCategory?>("updateCategory"); }
            set { BackingStore?.Set("updateCategory", value); }
        }
        /// <summary>Summary of the update states.</summary>
        public List<MacOSSoftwareUpdateStateSummary> UpdateStateSummaries {
            get { return BackingStore?.Get<List<MacOSSoftwareUpdateStateSummary>>("updateStateSummaries"); }
            set { BackingStore?.Set("updateStateSummaries", value); }
        }
        /// <summary>The user ID.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>("userId"); }
            set { BackingStore?.Set("userId", value); }
        }
        /// <summary>
        /// Instantiates a new macOSSoftwareUpdateCategorySummary and sets the default values.
        /// </summary>
        public MacOSSoftwareUpdateCategorySummary() : base() {
            OdataType = "#microsoft.graph.macOSSoftwareUpdateCategorySummary";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"updateStateSummaries", n => { UpdateStateSummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateStateSummary>(MacOSSoftwareUpdateStateSummary.CreateFromDiscriminatorValue)?.ToList(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
