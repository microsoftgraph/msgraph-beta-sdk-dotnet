using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365GroupsActivityGroupCounts : Entity, IParsable {
        /// <summary>The number of active groups. A group is considered active if any of the following occurred: group mailbox received email; user viewed, edited, shared, or synced files in SharePoint document library; user viewed SharePoint pages; user posted, read, or liked messages in Yammer groups.</summary>
        public long? Active {
            get { return BackingStore?.Get<long?>("active"); }
            set { BackingStore?.Set("active", value); }
        }
        /// <summary>The date on which a number of groups were active.</summary>
        public Date? ReportDate {
            get { return BackingStore?.Get<Date?>("reportDate"); }
            set { BackingStore?.Set("reportDate", value); }
        }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod {
            get { return BackingStore?.Get<string>("reportPeriod"); }
            set { BackingStore?.Set("reportPeriod", value); }
        }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate {
            get { return BackingStore?.Get<Date?>("reportRefreshDate"); }
            set { BackingStore?.Set("reportRefreshDate", value); }
        }
        /// <summary>The total number of groups.</summary>
        public long? Total {
            get { return BackingStore?.Get<long?>("total"); }
            set { BackingStore?.Set("total", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Office365GroupsActivityGroupCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityGroupCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"active", n => { Active = n.GetLongValue(); } },
                {"reportDate", n => { ReportDate = n.GetDateValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"total", n => { Total = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("active", Active);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("total", Total);
        }
    }
}
