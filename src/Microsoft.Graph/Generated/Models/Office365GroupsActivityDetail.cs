using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365GroupsActivityDetail : Entity, IParsable {
        /// <summary>The storage used of the group mailbox.</summary>
        public long? ExchangeMailboxStorageUsedInBytes { get; set; }
        /// <summary>The number of items in the group mailbox.</summary>
        public long? ExchangeMailboxTotalItemCount { get; set; }
        /// <summary>The number of email that the group mailbox received.</summary>
        public long? ExchangeReceivedEmailCount { get; set; }
        /// <summary>The group external member count.</summary>
        public long? ExternalMemberCount { get; set; }
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
        public long? MemberCount { get; set; }
        /// <summary>The group owner principal name.</summary>
        public string OwnerPrincipalName { get; set; }
        /// <summary>The number of days the report covers.</summary>
        public string ReportPeriod { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The number of active files in SharePoint Group site.</summary>
        public long? SharePointActiveFileCount { get; set; }
        /// <summary>The storage used by SharePoint Group site.</summary>
        public long? SharePointSiteStorageUsedInBytes { get; set; }
        /// <summary>The total number of files in SharePoint Group site.</summary>
        public long? SharePointTotalFileCount { get; set; }
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public long? YammerLikedMessageCount { get; set; }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public long? YammerPostedMessageCount { get; set; }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public long? YammerReadMessageCount { get; set; }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"exchangeMailboxStorageUsedInBytes", n => { ExchangeMailboxStorageUsedInBytes = n.GetLongValue(); } },
                {"exchangeMailboxTotalItemCount", n => { ExchangeMailboxTotalItemCount = n.GetLongValue(); } },
                {"exchangeReceivedEmailCount", n => { ExchangeReceivedEmailCount = n.GetLongValue(); } },
                {"externalMemberCount", n => { ExternalMemberCount = n.GetLongValue(); } },
                {"groupDisplayName", n => { GroupDisplayName = n.GetStringValue(); } },
                {"groupId", n => { GroupId = n.GetStringValue(); } },
                {"groupType", n => { GroupType = n.GetStringValue(); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"lastActivityDate", n => { LastActivityDate = n.GetDateValue(); } },
                {"memberCount", n => { MemberCount = n.GetLongValue(); } },
                {"ownerPrincipalName", n => { OwnerPrincipalName = n.GetStringValue(); } },
                {"reportPeriod", n => { ReportPeriod = n.GetStringValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointActiveFileCount", n => { SharePointActiveFileCount = n.GetLongValue(); } },
                {"sharePointSiteStorageUsedInBytes", n => { SharePointSiteStorageUsedInBytes = n.GetLongValue(); } },
                {"sharePointTotalFileCount", n => { SharePointTotalFileCount = n.GetLongValue(); } },
                {"yammerLikedMessageCount", n => { YammerLikedMessageCount = n.GetLongValue(); } },
                {"yammerPostedMessageCount", n => { YammerPostedMessageCount = n.GetLongValue(); } },
                {"yammerReadMessageCount", n => { YammerReadMessageCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("exchangeMailboxStorageUsedInBytes", ExchangeMailboxStorageUsedInBytes);
            writer.WriteLongValue("exchangeMailboxTotalItemCount", ExchangeMailboxTotalItemCount);
            writer.WriteLongValue("exchangeReceivedEmailCount", ExchangeReceivedEmailCount);
            writer.WriteLongValue("externalMemberCount", ExternalMemberCount);
            writer.WriteStringValue("groupDisplayName", GroupDisplayName);
            writer.WriteStringValue("groupId", GroupId);
            writer.WriteStringValue("groupType", GroupType);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteDateValue("lastActivityDate", LastActivityDate);
            writer.WriteLongValue("memberCount", MemberCount);
            writer.WriteStringValue("ownerPrincipalName", OwnerPrincipalName);
            writer.WriteStringValue("reportPeriod", ReportPeriod);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteLongValue("sharePointActiveFileCount", SharePointActiveFileCount);
            writer.WriteLongValue("sharePointSiteStorageUsedInBytes", SharePointSiteStorageUsedInBytes);
            writer.WriteLongValue("sharePointTotalFileCount", SharePointTotalFileCount);
            writer.WriteLongValue("yammerLikedMessageCount", YammerLikedMessageCount);
            writer.WriteLongValue("yammerPostedMessageCount", YammerPostedMessageCount);
            writer.WriteLongValue("yammerReadMessageCount", YammerReadMessageCount);
        }
    }
}
