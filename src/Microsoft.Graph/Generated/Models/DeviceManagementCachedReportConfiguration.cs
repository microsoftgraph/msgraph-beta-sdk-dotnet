using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceManagementCachedReportConfiguration : Entity, IParsable {
        /// <summary>Time that the cached report expires</summary>
        public DateTimeOffset? ExpirationDateTime { get; set; }
        /// <summary>Filters applied on report creation.</summary>
        public string Filter { get; set; }
        /// <summary>Time that the cached report was last refreshed</summary>
        public DateTimeOffset? LastRefreshDateTime { get; set; }
        /// <summary>Caller-managed metadata associated with the report</summary>
        public string Metadata { get; set; }
        /// <summary>Ordering of columns in the report</summary>
        public List<string> OrderBy { get; set; }
        /// <summary>Name of the report</summary>
        public string ReportName { get; set; }
        /// <summary>Columns selected from the report</summary>
        public List<string> Select { get; set; }
        /// <summary>Status of the cached report. Possible values are: unknown, notStarted, inProgress, completed, failed.</summary>
        public DeviceManagementReportStatus? Status { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceManagementCachedReportConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceManagementCachedReportConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"filter", n => { Filter = n.GetStringValue(); } },
                {"lastRefreshDateTime", n => { LastRefreshDateTime = n.GetDateTimeOffsetValue(); } },
                {"metadata", n => { Metadata = n.GetStringValue(); } },
                {"orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"reportName", n => { ReportName = n.GetStringValue(); } },
                {"select", n => { Select = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"status", n => { Status = n.GetEnumValue<DeviceManagementReportStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expirationDateTime", ExpirationDateTime);
            writer.WriteStringValue("filter", Filter);
            writer.WriteDateTimeOffsetValue("lastRefreshDateTime", LastRefreshDateTime);
            writer.WriteStringValue("metadata", Metadata);
            writer.WriteCollectionOfPrimitiveValues<string>("orderBy", OrderBy);
            writer.WriteStringValue("reportName", ReportName);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
            writer.WriteEnumValue<DeviceManagementReportStatus>("status", Status);
        }
    }
}
