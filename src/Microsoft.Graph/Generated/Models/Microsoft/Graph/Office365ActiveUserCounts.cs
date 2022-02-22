using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class Office365ActiveUserCounts : Entity, IParsable {
        /// <summary>The number of active users in Exchange. Any user who can read and send email is considered an active user.</summary>
        public long? Exchange { get; set; }
        /// <summary>The number of active users in Microsoft 365. This number includes all the active users in Exchange, OneDrive, SharePoint, Skype For Business, Yammer, and Microsoft Teams. You can find the definition of active user for each product in the respective property description.</summary>
        public long? Office365 { get; set; }
        /// <summary>The number of active users in OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public long? OneDrive { get; set; }
        /// <summary>The date on which a number of users were active.</summary>
        public Date? ReportDate { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active users in SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public long? SharePoint { get; set; }
        /// <summary>The number of active users in Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public long? SkypeForBusiness { get; set; }
        /// <summary>The number of active users in Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public long? Teams { get; set; }
        /// <summary>The number of active users in Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public long? Yammer { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exchange", (o,n) => { (o as Office365ActiveUserCounts).Exchange = n.GetLongValue(); } },
                {"office365", (o,n) => { (o as Office365ActiveUserCounts).Office365 = n.GetLongValue(); } },
                {"oneDrive", (o,n) => { (o as Office365ActiveUserCounts).OneDrive = n.GetLongValue(); } },
                {"reportDate", (o,n) => { (o as Office365ActiveUserCounts).ReportDate = n.GetDateValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365ActiveUserCounts).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365ActiveUserCounts).ReportRefreshDate = n.GetDateValue(); } },
                {"sharePoint", (o,n) => { (o as Office365ActiveUserCounts).SharePoint = n.GetLongValue(); } },
                {"skypeForBusiness", (o,n) => { (o as Office365ActiveUserCounts).SkypeForBusiness = n.GetLongValue(); } },
                {"teams", (o,n) => { (o as Office365ActiveUserCounts).Teams = n.GetLongValue(); } },
                {"yammer", (o,n) => { (o as Office365ActiveUserCounts).Yammer = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchange", Exchange);
            writer.WriteLongValue("office365", Office365);
            writer.WriteLongValue("oneDrive", OneDrive);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePoint", SharePoint);
            writer.WriteLongValue("skypeForBusiness", SkypeForBusiness);
            writer.WriteLongValue("teams", Teams);
            writer.WriteLongValue("yammer", Yammer);
        }
    }
}
