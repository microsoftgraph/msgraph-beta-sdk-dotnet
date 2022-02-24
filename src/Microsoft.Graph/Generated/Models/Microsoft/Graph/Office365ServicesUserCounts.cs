using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Office365ServicesUserCounts : Entity, IParsable {
        /// <summary>The number of active users on Exchange. Any user who can read and send email is considered an active user.</summary>
        public long? ExchangeActive { get; set; }
        /// <summary>The number of inactive users on Exchange.</summary>
        public long? ExchangeInactive { get; set; }
        /// <summary>The number of active users on Microsoft 365.</summary>
        public long? Office365Active { get; set; }
        /// <summary>The number of inactive users on Microsoft 365.</summary>
        public long? Office365Inactive { get; set; }
        /// <summary>The number of active users on OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public long? OneDriveActive { get; set; }
        /// <summary>The number of inactive users on OneDrive.</summary>
        public long? OneDriveInactive { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active users on SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public long? SharePointActive { get; set; }
        /// <summary>The number of inactive users on SharePoint.</summary>
        public long? SharePointInactive { get; set; }
        /// <summary>The number of active users on Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public long? SkypeForBusinessActive { get; set; }
        /// <summary>The number of inactive users on Skype For Business.</summary>
        public long? SkypeForBusinessInactive { get; set; }
        /// <summary>The number of active users on Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public long? TeamsActive { get; set; }
        /// <summary>The number of inactive users on Microsoft Teams.</summary>
        public long? TeamsInactive { get; set; }
        /// <summary>The number of active users on Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public long? YammerActive { get; set; }
        /// <summary>The number of inactive users on Yammer.</summary>
        public long? YammerInactive { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exchangeActive", (o,n) => { (o as Office365ServicesUserCounts).ExchangeActive = n.GetLongValue(); } },
                {"exchangeInactive", (o,n) => { (o as Office365ServicesUserCounts).ExchangeInactive = n.GetLongValue(); } },
                {"office365Active", (o,n) => { (o as Office365ServicesUserCounts).Office365Active = n.GetLongValue(); } },
                {"office365Inactive", (o,n) => { (o as Office365ServicesUserCounts).Office365Inactive = n.GetLongValue(); } },
                {"oneDriveActive", (o,n) => { (o as Office365ServicesUserCounts).OneDriveActive = n.GetLongValue(); } },
                {"oneDriveInactive", (o,n) => { (o as Office365ServicesUserCounts).OneDriveInactive = n.GetLongValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365ServicesUserCounts).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365ServicesUserCounts).ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointActive", (o,n) => { (o as Office365ServicesUserCounts).SharePointActive = n.GetLongValue(); } },
                {"sharePointInactive", (o,n) => { (o as Office365ServicesUserCounts).SharePointInactive = n.GetLongValue(); } },
                {"skypeForBusinessActive", (o,n) => { (o as Office365ServicesUserCounts).SkypeForBusinessActive = n.GetLongValue(); } },
                {"skypeForBusinessInactive", (o,n) => { (o as Office365ServicesUserCounts).SkypeForBusinessInactive = n.GetLongValue(); } },
                {"teamsActive", (o,n) => { (o as Office365ServicesUserCounts).TeamsActive = n.GetLongValue(); } },
                {"teamsInactive", (o,n) => { (o as Office365ServicesUserCounts).TeamsInactive = n.GetLongValue(); } },
                {"yammerActive", (o,n) => { (o as Office365ServicesUserCounts).YammerActive = n.GetLongValue(); } },
                {"yammerInactive", (o,n) => { (o as Office365ServicesUserCounts).YammerInactive = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchangeActive", ExchangeActive);
            writer.WriteLongValue("exchangeInactive", ExchangeInactive);
            writer.WriteLongValue("office365Active", Office365Active);
            writer.WriteLongValue("office365Inactive", Office365Inactive);
            writer.WriteLongValue("oneDriveActive", OneDriveActive);
            writer.WriteLongValue("oneDriveInactive", OneDriveInactive);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePointActive", SharePointActive);
            writer.WriteLongValue("sharePointInactive", SharePointInactive);
            writer.WriteLongValue("skypeForBusinessActive", SkypeForBusinessActive);
            writer.WriteLongValue("skypeForBusinessInactive", SkypeForBusinessInactive);
            writer.WriteLongValue("teamsActive", TeamsActive);
            writer.WriteLongValue("teamsInactive", TeamsInactive);
            writer.WriteLongValue("yammerActive", YammerActive);
            writer.WriteLongValue("yammerInactive", YammerInactive);
        }
    }
}
