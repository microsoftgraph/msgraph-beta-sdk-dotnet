using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the getOffice365GroupsActivityDetail method.</summary>
    public class Office365GroupsActivityDetail : Entity, IParsable {
        /// <summary>The storage used of the group mailbox.</summary>
        public int? ExchangeMailboxStorageUsedInBytes { get; set; }
        /// <summary>The number of items in the group mailbox.</summary>
        public int? ExchangeMailboxTotalItemCount { get; set; }
        /// <summary>The number of email that the group mailbox received.</summary>
        public int? ExchangeReceivedEmailCount { get; set; }
        /// <summary>The group external member count.</summary>
        public int? ExternalMemberCount { get; set; }
        /// <summary>The display name of the group.</summary>
        public string GroupDisplayName { get; set; }
        /// <summary>The group id.</summary>
        public string GroupId { get; set; }
        /// <summary>The group type. Possible values are: Public or Private.</summary>
        public string GroupType { get; set; }
        /// <summary>Whether this user has been deleted or soft deleted.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>The last activity date for the following scenarios:  group mailbox received email; user viewed, edited, shared, or synced files in SharePoint document library; user viewed SharePoint pages; user posted, read, or liked messages in Yammer groups.</summary>
        public Date? LastActivityDate { get; set; }
        /// <summary>The group member count.</summary>
        public int? MemberCount { get; set; }
        /// <summary>The group owner principal name.</summary>
        public string OwnerPrincipalName { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active files in SharePoint Group site.</summary>
        public int? SharePointActiveFileCount { get; set; }
        /// <summary>The storage used by SharePoint Group site.</summary>
        public int? SharePointSiteStorageUsedInBytes { get; set; }
        /// <summary>The total number of files in SharePoint Group site.</summary>
        public int? SharePointTotalFileCount { get; set; }
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public int? YammerLikedMessageCount { get; set; }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public int? YammerPostedMessageCount { get; set; }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public int? YammerReadMessageCount { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365GroupsActivityDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365GroupsActivityDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"exchangeMailboxStorageUsedInBytes", (o,n) => { (o as Office365GroupsActivityDetail).ExchangeMailboxStorageUsedInBytes = n.GetIntValue(); } },
                {"exchangeMailboxTotalItemCount", (o,n) => { (o as Office365GroupsActivityDetail).ExchangeMailboxTotalItemCount = n.GetIntValue(); } },
                {"exchangeReceivedEmailCount", (o,n) => { (o as Office365GroupsActivityDetail).ExchangeReceivedEmailCount = n.GetIntValue(); } },
                {"externalMemberCount", (o,n) => { (o as Office365GroupsActivityDetail).ExternalMemberCount = n.GetIntValue(); } },
                {"groupDisplayName", (o,n) => { (o as Office365GroupsActivityDetail).GroupDisplayName = n.GetStringValue(); } },
                {"groupId", (o,n) => { (o as Office365GroupsActivityDetail).GroupId = n.GetStringValue(); } },
                {"groupType", (o,n) => { (o as Office365GroupsActivityDetail).GroupType = n.GetStringValue(); } },
                {"isDeleted", (o,n) => { (o as Office365GroupsActivityDetail).IsDeleted = n.GetBoolValue(); } },
                {"lastActivityDate", (o,n) => { (o as Office365GroupsActivityDetail).LastActivityDate = n.GetDateValue(); } },
                {"memberCount", (o,n) => { (o as Office365GroupsActivityDetail).MemberCount = n.GetIntValue(); } },
                {"ownerPrincipalName", (o,n) => { (o as Office365GroupsActivityDetail).OwnerPrincipalName = n.GetStringValue(); } },
                {"reportPeriod", (o,n) => { (o as Office365GroupsActivityDetail).ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365GroupsActivityDetail).ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointActiveFileCount", (o,n) => { (o as Office365GroupsActivityDetail).SharePointActiveFileCount = n.GetIntValue(); } },
                {"sharePointSiteStorageUsedInBytes", (o,n) => { (o as Office365GroupsActivityDetail).SharePointSiteStorageUsedInBytes = n.GetIntValue(); } },
                {"sharePointTotalFileCount", (o,n) => { (o as Office365GroupsActivityDetail).SharePointTotalFileCount = n.GetIntValue(); } },
                {"yammerLikedMessageCount", (o,n) => { (o as Office365GroupsActivityDetail).YammerLikedMessageCount = n.GetIntValue(); } },
                {"yammerPostedMessageCount", (o,n) => { (o as Office365GroupsActivityDetail).YammerPostedMessageCount = n.GetIntValue(); } },
                {"yammerReadMessageCount", (o,n) => { (o as Office365GroupsActivityDetail).YammerReadMessageCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("exchangeMailboxStorageUsedInBytes", ExchangeMailboxStorageUsedInBytes);
            writer.WriteIntValue("exchangeMailboxTotalItemCount", ExchangeMailboxTotalItemCount);
            writer.WriteIntValue("exchangeReceivedEmailCount", ExchangeReceivedEmailCount);
            writer.WriteIntValue("externalMemberCount", ExternalMemberCount);
            writer.WriteStringValue("groupDisplayName", GroupDisplayName);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("groupType", GroupType);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteDateValue("lastActivityDate", LastActivityDate);
            writer.WriteIntValue("memberCount", MemberCount);
            writer.WriteStringValue("ownerPrincipalName", OwnerPrincipalName);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteIntValue("sharePointActiveFileCount", SharePointActiveFileCount);
            writer.WriteIntValue("sharePointSiteStorageUsedInBytes", SharePointSiteStorageUsedInBytes);
            writer.WriteIntValue("sharePointTotalFileCount", SharePointTotalFileCount);
            writer.WriteIntValue("yammerLikedMessageCount", YammerLikedMessageCount);
            writer.WriteIntValue("yammerPostedMessageCount", YammerPostedMessageCount);
            writer.WriteIntValue("yammerReadMessageCount", YammerReadMessageCount);
        }
    }
}
