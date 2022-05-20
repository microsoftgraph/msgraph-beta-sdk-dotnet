using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the getOffice365GroupsActivityCounts method.</summary>
    public class Office365GroupsActivityCounts : Entity, IParsable {
        /// <summary>The number of emails received by Group mailboxes.</summary>
        public long? ExchangeEmailsReceived {
            get { return BackingStore?.Get<long?>(nameof(ExchangeEmailsReceived)); }
            set { BackingStore?.Set(nameof(ExchangeEmailsReceived), value); }
        }
        /// <summary>The date on which a number of emails were sent to a group mailbox or a number of messages were posted, read, or liked in a Yammer group</summary>
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
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public long? YammerMessagesLiked {
            get { return BackingStore?.Get<long?>(nameof(YammerMessagesLiked)); }
            set { BackingStore?.Set(nameof(YammerMessagesLiked), value); }
        }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public long? YammerMessagesPosted {
            get { return BackingStore?.Get<long?>(nameof(YammerMessagesPosted)); }
            set { BackingStore?.Set(nameof(YammerMessagesPosted), value); }
        }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public long? YammerMessagesRead {
            get { return BackingStore?.Get<long?>(nameof(YammerMessagesRead)); }
            set { BackingStore?.Set(nameof(YammerMessagesRead), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365GroupsActivityCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exchangeEmailsReceived", n => { ExchangeEmailsReceived = n.GetLongValue(); } },
                {"reportDate", n => { ReportDate = n.GetDateValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"yammerMessagesLiked", n => { YammerMessagesLiked = n.GetLongValue(); } },
                {"yammerMessagesPosted", n => { YammerMessagesPosted = n.GetLongValue(); } },
                {"yammerMessagesRead", n => { YammerMessagesRead = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchangeEmailsReceived", ExchangeEmailsReceived);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("yammerMessagesLiked", YammerMessagesLiked);
            writer.WriteLongValue("yammerMessagesPosted", YammerMessagesPosted);
            writer.WriteLongValue("yammerMessagesRead", YammerMessagesRead);
        }
    }
}
