using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getOffice365ServicesUserCounts method.</summary>
    public class Office365ServicesUserCounts : Entity, IParsable {
        /// <summary>The number of active users on Exchange. Any user who can read and send email is considered an active user.</summary>
        public int? ExchangeActive { get; set; }
        /// <summary>The number of inactive users on Exchange.</summary>
        public int? ExchangeInactive { get; set; }
        /// <summary>The number of active users on Microsoft 365.</summary>
        public int? Office365Active { get; set; }
        /// <summary>The number of inactive users on Microsoft 365.</summary>
        public int? Office365Inactive { get; set; }
        /// <summary>The number of active users on OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public int? OneDriveActive { get; set; }
        /// <summary>The number of inactive users on OneDrive.</summary>
        public int? OneDriveInactive { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active users on SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public int? SharePointActive { get; set; }
        /// <summary>The number of inactive users on SharePoint.</summary>
        public int? SharePointInactive { get; set; }
        /// <summary>The number of active users on Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public int? SkypeForBusinessActive { get; set; }
        /// <summary>The number of inactive users on Skype For Business.</summary>
        public int? SkypeForBusinessInactive { get; set; }
        /// <summary>The number of active users on Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public int? TeamsActive { get; set; }
        /// <summary>The number of inactive users on Microsoft Teams.</summary>
        public int? TeamsInactive { get; set; }
        /// <summary>The number of active users on Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public int? YammerActive { get; set; }
        /// <summary>The number of inactive users on Yammer.</summary>
        public int? YammerInactive { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365ServicesUserCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365ServicesUserCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exchangeActive", (o,n) => { (o as Office365ServicesUserCounts).ExchangeActive = n.GetIntValue(); } },
                {"exchangeInactive", (o,n) => { (o as Office365ServicesUserCounts).ExchangeInactive = n.GetIntValue(); } },
                {"office365Active", (o,n) => { (o as Office365ServicesUserCounts).Office365Active = n.GetIntValue(); } },
                {"office365Inactive", (o,n) => { (o as Office365ServicesUserCounts).Office365Inactive = n.GetIntValue(); } },
                {"oneDriveActive", (o,n) => { (o as Office365ServicesUserCounts).OneDriveActive = n.GetIntValue(); } },
                {"oneDriveInactive", (o,n) => { (o as Office365ServicesUserCounts).OneDriveInactive = n.GetIntValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365ServicesUserCounts).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365ServicesUserCounts).ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointActive", (o,n) => { (o as Office365ServicesUserCounts).SharePointActive = n.GetIntValue(); } },
                {"sharePointInactive", (o,n) => { (o as Office365ServicesUserCounts).SharePointInactive = n.GetIntValue(); } },
                {"skypeForBusinessActive", (o,n) => { (o as Office365ServicesUserCounts).SkypeForBusinessActive = n.GetIntValue(); } },
                {"skypeForBusinessInactive", (o,n) => { (o as Office365ServicesUserCounts).SkypeForBusinessInactive = n.GetIntValue(); } },
                {"teamsActive", (o,n) => { (o as Office365ServicesUserCounts).TeamsActive = n.GetIntValue(); } },
                {"teamsInactive", (o,n) => { (o as Office365ServicesUserCounts).TeamsInactive = n.GetIntValue(); } },
                {"yammerActive", (o,n) => { (o as Office365ServicesUserCounts).YammerActive = n.GetIntValue(); } },
                {"yammerInactive", (o,n) => { (o as Office365ServicesUserCounts).YammerInactive = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("exchangeActive", ExchangeActive);
            writer.WriteIntValue("exchangeInactive", ExchangeInactive);
            writer.WriteIntValue("office365Active", Office365Active);
            writer.WriteIntValue("office365Inactive", Office365Inactive);
            writer.WriteIntValue("oneDriveActive", OneDriveActive);
            writer.WriteIntValue("oneDriveInactive", OneDriveInactive);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteIntValue("sharePointActive", SharePointActive);
            writer.WriteIntValue("sharePointInactive", SharePointInactive);
            writer.WriteIntValue("skypeForBusinessActive", SkypeForBusinessActive);
            writer.WriteIntValue("skypeForBusinessInactive", SkypeForBusinessInactive);
            writer.WriteIntValue("teamsActive", TeamsActive);
            writer.WriteIntValue("teamsInactive", TeamsInactive);
            writer.WriteIntValue("yammerActive", YammerActive);
            writer.WriteIntValue("yammerInactive", YammerInactive);
        }
    }
}
