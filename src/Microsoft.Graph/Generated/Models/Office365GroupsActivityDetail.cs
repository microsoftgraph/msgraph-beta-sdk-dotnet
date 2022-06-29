using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365GroupsActivityDetail : Entity, IParsable {
        /// <summary>The storage used of the group mailbox.</summary>
        public long? ExchangeMailboxStorageUsedInBytes {
            get { return BackingStore?.Get<long?>(nameof(ExchangeMailboxStorageUsedInBytes)); }
            set { BackingStore?.Set(nameof(ExchangeMailboxStorageUsedInBytes), value); }
        }
        /// <summary>The number of items in the group mailbox.</summary>
        public long? ExchangeMailboxTotalItemCount {
            get { return BackingStore?.Get<long?>(nameof(ExchangeMailboxTotalItemCount)); }
            set { BackingStore?.Set(nameof(ExchangeMailboxTotalItemCount), value); }
        }
        /// <summary>The number of email that the group mailbox received.</summary>
        public long? ExchangeReceivedEmailCount {
            get { return BackingStore?.Get<long?>(nameof(ExchangeReceivedEmailCount)); }
            set { BackingStore?.Set(nameof(ExchangeReceivedEmailCount), value); }
        }
        /// <summary>The group external member count.</summary>
        public long? ExternalMemberCount {
            get { return BackingStore?.Get<long?>(nameof(ExternalMemberCount)); }
            set { BackingStore?.Set(nameof(ExternalMemberCount), value); }
        }
        /// <summary>The display name of the group.</summary>
        public string GroupDisplayName {
            get { return BackingStore?.Get<string>(nameof(GroupDisplayName)); }
            set { BackingStore?.Set(nameof(GroupDisplayName), value); }
        }
        /// <summary>The group id.</summary>
        public string GroupId {
            get { return BackingStore?.Get<string>(nameof(GroupId)); }
            set { BackingStore?.Set(nameof(GroupId), value); }
        }
        /// <summary>The group type. Possible values are: Public or Private.</summary>
        public string GroupType {
            get { return BackingStore?.Get<string>(nameof(GroupType)); }
            set { BackingStore?.Set(nameof(GroupType), value); }
        }
        /// <summary>Whether this user has been deleted or soft deleted.</summary>
        public bool? IsDeleted {
            get { return BackingStore?.Get<bool?>(nameof(IsDeleted)); }
            set { BackingStore?.Set(nameof(IsDeleted), value); }
        }
        /// <summary>The last activity date for the following scenarios:  group mailbox received email; user viewed, edited, shared, or synced files in SharePoint document library; user viewed SharePoint pages; user posted, read, or liked messages in Yammer groups.</summary>
        public Date? LastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(LastActivityDate)); }
            set { BackingStore?.Set(nameof(LastActivityDate), value); }
        }
        /// <summary>The group member count.</summary>
        public long? MemberCount {
            get { return BackingStore?.Get<long?>(nameof(MemberCount)); }
            set { BackingStore?.Set(nameof(MemberCount), value); }
        }
        /// <summary>The group owner principal name.</summary>
        public string OwnerPrincipalName {
            get { return BackingStore?.Get<string>(nameof(OwnerPrincipalName)); }
            set { BackingStore?.Set(nameof(OwnerPrincipalName), value); }
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
        /// <summary>The number of active files in SharePoint Group site.</summary>
        public long? SharePointActiveFileCount {
            get { return BackingStore?.Get<long?>(nameof(SharePointActiveFileCount)); }
            set { BackingStore?.Set(nameof(SharePointActiveFileCount), value); }
        }
        /// <summary>The storage used by SharePoint Group site.</summary>
        public long? SharePointSiteStorageUsedInBytes {
            get { return BackingStore?.Get<long?>(nameof(SharePointSiteStorageUsedInBytes)); }
            set { BackingStore?.Set(nameof(SharePointSiteStorageUsedInBytes), value); }
        }
        /// <summary>The total number of files in SharePoint Group site.</summary>
        public long? SharePointTotalFileCount {
            get { return BackingStore?.Get<long?>(nameof(SharePointTotalFileCount)); }
            set { BackingStore?.Set(nameof(SharePointTotalFileCount), value); }
        }
        /// <summary>The number of messages liked in Yammer groups.</summary>
        public long? YammerLikedMessageCount {
            get { return BackingStore?.Get<long?>(nameof(YammerLikedMessageCount)); }
            set { BackingStore?.Set(nameof(YammerLikedMessageCount), value); }
        }
        /// <summary>The number of messages posted to Yammer groups.</summary>
        public long? YammerPostedMessageCount {
            get { return BackingStore?.Get<long?>(nameof(YammerPostedMessageCount)); }
            set { BackingStore?.Set(nameof(YammerPostedMessageCount), value); }
        }
        /// <summary>The number of messages read in Yammer groups.</summary>
        public long? YammerReadMessageCount {
            get { return BackingStore?.Get<long?>(nameof(YammerReadMessageCount)); }
            set { BackingStore?.Set(nameof(YammerReadMessageCount), value); }
        }
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
