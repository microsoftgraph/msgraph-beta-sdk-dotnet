using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the getOffice365GroupsActivityFileCounts method.</summary>
    public class Office365GroupsActivityFileCounts : Entity, IParsable {
        /// <summary>The number of files that were viewed, edited, shared, or synced in the group&apos;s SharePoint document library.</summary>
        public long? Active {
            get { return BackingStore?.Get<long?>(nameof(Active)); }
            set { BackingStore?.Set(nameof(Active), value); }
        }
        /// <summary>The date on which a number of files were active in the group&apos;s SharePoint site.</summary>
        public Date? ReportDate {
            get { return BackingStore?.Get<Date?>(nameof(ReportDate)); }
            set { BackingStore?.Set(nameof(ReportDate), value); }
        }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod {
            get { return BackingStore?.Get<string>(nameof(ReportPeriod)); }
            set { BackingStore?.Set(nameof(ReportPeriod), value); }
        }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate {
            get { return BackingStore?.Get<Date?>(nameof(ReportRefreshDate)); }
            set { BackingStore?.Set(nameof(ReportRefreshDate), value); }
        }
        /// <summary>The total number of files in the group&apos;s SharePoint document library.</summary>
        public long? Total {
            get { return BackingStore?.Get<long?>(nameof(Total)); }
            set { BackingStore?.Set(nameof(Total), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365GroupsActivityFileCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityFileCounts();
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
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
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
