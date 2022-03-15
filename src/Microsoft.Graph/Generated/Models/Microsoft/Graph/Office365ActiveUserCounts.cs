using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getOffice365ActiveUserCounts method.</summary>
    public class Office365ActiveUserCounts : Entity, IParsable {
        /// <summary>The number of active users in Exchange. Any user who can read and send email is considered an active user.</summary>
        public int? Exchange { get; set; }
        /// <summary>The number of active users in Microsoft 365. This number includes all the active users in Exchange, OneDrive, SharePoint, Skype For Business, Yammer, and Microsoft Teams. You can find the definition of active user for each product in the respective property description.</summary>
        public int? Office365 { get; set; }
        /// <summary>The number of active users in OneDrive. Any user who viewed or edited files, shared files internally or externally, or synced files is considered an active user.</summary>
        public int? OneDrive { get; set; }
        /// <summary>The date on which a number of users were active.</summary>
        public Date? ReportDate { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active users in SharePoint. Any user who viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages is considered an active user.</summary>
        public int? SharePoint { get; set; }
        /// <summary>The number of active users in Skype For Business. Any user who organized or participated in conferences, or joined peer-to-peer sessions is considered an active user.</summary>
        public int? SkypeForBusiness { get; set; }
        /// <summary>The number of active users in Microsoft Teams. Any user who posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls is considered an active user.</summary>
        public int? Teams { get; set; }
        /// <summary>The number of active users in Yammer. Any user who can post, read, or like messages is considered an active user.</summary>
        public int? Yammer { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365ActiveUserCounts CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365ActiveUserCounts();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exchange", (o,n) => { (o as Office365ActiveUserCounts).Exchange = n.GetIntValue(); } },
                {"office365", (o,n) => { (o as Office365ActiveUserCounts).Office365 = n.GetIntValue(); } },
                {"oneDrive", (o,n) => { (o as Office365ActiveUserCounts).OneDrive = n.GetIntValue(); } },
                {"reportDate", (o,n) => { (o as Office365ActiveUserCounts).ReportDate = n.GetDateValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365ActiveUserCounts).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365ActiveUserCounts).ReportRefreshDate = n.GetDateValue(); } },
                {"sharePoint", (o,n) => { (o as Office365ActiveUserCounts).SharePoint = n.GetIntValue(); } },
                {"skypeForBusiness", (o,n) => { (o as Office365ActiveUserCounts).SkypeForBusiness = n.GetIntValue(); } },
                {"teams", (o,n) => { (o as Office365ActiveUserCounts).Teams = n.GetIntValue(); } },
                {"yammer", (o,n) => { (o as Office365ActiveUserCounts).Yammer = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("exchange", Exchange);
            writer.WriteIntValue("office365", Office365);
            writer.WriteIntValue("oneDrive", OneDrive);
            writer.WriteDateValue("reportDate", ReportDate);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteIntValue("sharePoint", SharePoint);
            writer.WriteIntValue("skypeForBusiness", SkypeForBusiness);
            writer.WriteIntValue("teams", Teams);
            writer.WriteIntValue("yammer", Yammer);
        }
    }
}
