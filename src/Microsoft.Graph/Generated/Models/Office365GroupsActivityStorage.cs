using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365GroupsActivityStorage : Entity, IParsable {
        /// <summary>The storage used in group mailbox.</summary>
        public long? MailboxStorageUsedInBytes {
            get { return BackingStore?.Get<long?>(nameof(MailboxStorageUsedInBytes)); }
            set { BackingStore?.Set(nameof(MailboxStorageUsedInBytes), value); }
        }
        /// <summary>The snapshot date for Exchange and SharePoint used storage.</summary>
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
        /// <summary>The storage used in SharePoint document library.</summary>
        public long? SiteStorageUsedInBytes {
            get { return BackingStore?.Get<long?>(nameof(SiteStorageUsedInBytes)); }
            set { BackingStore?.Set(nameof(SiteStorageUsedInBytes), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365GroupsActivityStorage CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityStorage();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"mailboxStorageUsedInBytes", n => { MailboxStorageUsedInBytes = n.GetLongValue(); } },
                {"reportDate", n => { ReportDate = n.GetDateValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"siteStorageUsedInBytes", n => { SiteStorageUsedInBytes = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("mailboxStorageUsedInBytes", MailboxStorageUsedInBytes);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("siteStorageUsedInBytes", SiteStorageUsedInBytes);
        }
    }
}
