using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class MacOSSoftwareUpdateCategorySummary : Entity, IParsable {
        /// <summary>The device ID.</summary>
        public string DeviceId { get; set; }
        /// <summary>The name of the report</summary>
        public string DisplayName { get; set; }
        /// <summary>Number of failed updates on the device</summary>
        public int? FailedUpdateCount { get; set; }
        /// <summary>Last date time the report for this device was updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime { get; set; }
        /// <summary>Number of successful updates on the device</summary>
        public int? SuccessfulUpdateCount { get; set; }
        /// <summary>Number of total updates on the device</summary>
        public int? TotalUpdateCount { get; set; }
        /// <summary>Software update type. Possible values are: critical, configurationDataFile, firmware, other.</summary>
        public MacOSSoftwareUpdateCategory? UpdateCategory { get; set; }
        /// <summary>Summary of the update states.</summary>
        public List<MacOSSoftwareUpdateStateSummary> UpdateStateSummaries { get; set; }
        /// <summary>The user ID.</summary>
        public string UserId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceId", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).DeviceId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).DisplayName = n.GetStringValue(); } },
                {"failedUpdateCount", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).FailedUpdateCount = n.GetIntValue(); } },
                {"lastUpdatedDateTime", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"successfulUpdateCount", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).SuccessfulUpdateCount = n.GetIntValue(); } },
                {"totalUpdateCount", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).TotalUpdateCount = n.GetIntValue(); } },
                {"updateCategory", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).UpdateCategory = n.GetEnumValue<MacOSSoftwareUpdateCategory>(); } },
                {"updateStateSummaries", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).UpdateStateSummaries = n.GetCollectionOfObjectValues<MacOSSoftwareUpdateStateSummary>().ToList(); } },
                {"userId", (o,n) => { (o as MacOSSoftwareUpdateCategorySummary).UserId = n.GetStringValue(); } },
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
