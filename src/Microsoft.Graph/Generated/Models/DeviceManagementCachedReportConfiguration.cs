using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// Entity representing the configuration of a cached report
    /// </summary>
    public class DeviceManagementCachedReportConfiguration : Entity, IParsable {
        /// <summary>Time that the cached report expires</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>Filters applied on report creation.</summary>
        public string Filter {
            get { return BackingStore?.Get<string>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
        /// <summary>Time that the cached report was last refreshed</summary>
        public DateTimeOffset? LastRefreshDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("lastRefreshDateTime"); }
            set { BackingStore?.Set("lastRefreshDateTime", value); }
        }
        /// <summary>Caller-managed metadata associated with the report</summary>
        public string Metadata {
            get { return BackingStore?.Get<string>("metadata"); }
            set { BackingStore?.Set("metadata", value); }
        }
        /// <summary>Ordering of columns in the report</summary>
        public List<string> OrderBy {
            get { return BackingStore?.Get<List<string>>("orderBy"); }
            set { BackingStore?.Set("orderBy", value); }
        }
        /// <summary>Name of the report</summary>
        public string ReportName {
            get { return BackingStore?.Get<string>("reportName"); }
            set { BackingStore?.Set("reportName", value); }
        }
        /// <summary>Columns selected from the report</summary>
        public List<string> Select {
            get { return BackingStore?.Get<List<string>>("select"); }
            set { BackingStore?.Set("select", value); }
        }
        /// <summary>Possible statuses associated with a generated report</summary>
        public DeviceManagementReportStatus? Status {
            get { return BackingStore?.Get<DeviceManagementReportStatus?>("status"); }
            set { BackingStore?.Set("status", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
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
                {"orderBy", n => { OrderBy = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"reportName", n => { ReportName = n.GetStringValue(); } },
                {"select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"status", n => { Status = n.GetEnumValue<DeviceManagementReportStatus>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
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
