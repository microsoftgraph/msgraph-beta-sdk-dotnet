using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getOffice365GroupsActivityCounts method.</summary>
    public class Office365GroupsActivityCounts : Entity, IParsable {
        /// <summary>The number of emails received by Group mailboxes.</summary>
        public int? ExchangeEmailsReceived { get; set; }
        /// <summary>The date on which a number of emails were sent to a group mailbox or a number of messages were posted, read, or liked in a Yammer group</summary>
        public Date? ReportDate { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public int? YammerMessagesLiked { get; set; }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public int? YammerMessagesPosted { get; set; }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public int? YammerMessagesRead { get; set; }
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
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exchangeEmailsReceived", (o,n) => { (o as Office365GroupsActivityCounts).ExchangeEmailsReceived = n.GetIntValue(); } },
                {"reportDate", (o,n) => { (o as Office365GroupsActivityCounts).ReportDate = n.GetDateValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365GroupsActivityCounts).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365GroupsActivityCounts).ReportRefreshDate = n.GetDateValue(); } },
                {"yammerMessagesLiked", (o,n) => { (o as Office365GroupsActivityCounts).YammerMessagesLiked = n.GetIntValue(); } },
                {"yammerMessagesPosted", (o,n) => { (o as Office365GroupsActivityCounts).YammerMessagesPosted = n.GetIntValue(); } },
                {"yammerMessagesRead", (o,n) => { (o as Office365GroupsActivityCounts).YammerMessagesRead = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("exchangeEmailsReceived", ExchangeEmailsReceived);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteIntValue("yammerMessagesLiked", YammerMessagesLiked);
            writer.WriteIntValue("yammerMessagesPosted", YammerMessagesPosted);
            writer.WriteIntValue("yammerMessagesRead", YammerMessagesRead);
        }
    }
}
