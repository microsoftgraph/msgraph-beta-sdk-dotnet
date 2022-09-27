using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class CloudPcExportJob : Entity, IParsable {
        /// <summary>The expirationDateTime property</summary>
        public DateTimeOffset? ExpirationDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("expirationDateTime"); }
            set { BackingStore?.Set("expirationDateTime", value); }
        }
        /// <summary>The exportJobStatus property</summary>
        public CloudPcExportJobStatus? ExportJobStatus {
            get { return BackingStore?.Get<CloudPcExportJobStatus?>("exportJobStatus"); }
            set { BackingStore?.Set("exportJobStatus", value); }
        }
        /// <summary>The exportUrl property</summary>
        public string ExportUrl {
            get { return BackingStore?.Get<string>("exportUrl"); }
            set { BackingStore?.Set("exportUrl", value); }
        }
        /// <summary>The filter property</summary>
        public string Filter {
            get { return BackingStore?.Get<string>("filter"); }
            set { BackingStore?.Set("filter", value); }
        }
        /// <summary>The format property</summary>
        public string Format {
            get { return BackingStore?.Get<string>("format"); }
            set { BackingStore?.Set("format", value); }
        }
        /// <summary>The reportName property</summary>
        public CloudPcReportName? ReportName {
            get { return BackingStore?.Get<CloudPcReportName?>("reportName"); }
            set { BackingStore?.Set("reportName", value); }
        }
        /// <summary>The requestDateTime property</summary>
        public DateTimeOffset? RequestDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("requestDateTime"); }
            set { BackingStore?.Set("requestDateTime", value); }
        }
        /// <summary>The select property</summary>
        public List<string> Select {
            get { return BackingStore?.Get<List<string>>("select"); }
            set { BackingStore?.Set("select", value); }
        }
        /// <summary>
        /// Instantiates a new CloudPcExportJob and sets the default values.
        /// </summary>
        public CloudPcExportJob() : base() {
            OdataType = "#microsoft.graph.cloudPcExportJob";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CloudPcExportJob CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CloudPcExportJob();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expirationDateTime", n => { ExpirationDateTime = n.GetDateTimeOffsetValue(); } },
                {"exportJobStatus", n => { ExportJobStatus = n.GetEnumValue<CloudPcExportJobStatus>(); } },
                {"exportUrl", n => { ExportUrl = n.GetStringValue(); } },
                {"filter", n => { Filter = n.GetStringValue(); } },
                {"format", n => { Format = n.GetStringValue(); } },
                {"reportName", n => { ReportName = n.GetEnumValue<CloudPcReportName>(); } },
                {"requestDateTime", n => { RequestDateTime = n.GetDateTimeOffsetValue(); } },
                {"select", n => { Select = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
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
            writer.WriteEnumValue<CloudPcExportJobStatus>("exportJobStatus", ExportJobStatus);
            writer.WriteStringValue("exportUrl", ExportUrl);
            writer.WriteStringValue("filter", Filter);
            writer.WriteStringValue("format", Format);
            writer.WriteEnumValue<CloudPcReportName>("reportName", ReportName);
            writer.WriteDateTimeOffsetValue("requestDateTime", RequestDateTime);
            writer.WriteCollectionOfPrimitiveValues<string>("select", Select);
        }
    }
}
