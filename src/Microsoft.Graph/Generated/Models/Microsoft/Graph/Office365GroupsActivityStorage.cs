using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Office365GroupsActivityStorage : Entity, IParsable {
        /// <summary>The storage used in group mailbox.</summary>
        public long? MailboxStorageUsedInBytes { get; set; }
        /// <summary>The snapshot date for Exchange and SharePoint used storage.</summary>
        public Date? ReportDate { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The storage used in SharePoint document library.</summary>
        public long? SiteStorageUsedInBytes { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"mailboxStorageUsedInBytes", (o,n) => { (o as Office365GroupsActivityStorage).MailboxStorageUsedInBytes = n.GetLongValue(); } },
                {"reportDate", (o,n) => { (o as Office365GroupsActivityStorage).ReportDate = n.GetDateValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365GroupsActivityStorage).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365GroupsActivityStorage).ReportRefreshDate = n.GetDateValue(); } },
                {"siteStorageUsedInBytes", (o,n) => { (o as Office365GroupsActivityStorage).SiteStorageUsedInBytes = n.GetLongValue(); } },
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
