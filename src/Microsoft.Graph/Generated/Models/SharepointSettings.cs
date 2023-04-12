using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class SharepointSettings : Entity, IParsable {
        /// <summary>The allowedDomainGuidsForSyncApp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<Guid?>? AllowedDomainGuidsForSyncApp {
            get { return BackingStore?.Get<List<Guid?>?>("allowedDomainGuidsForSyncApp"); }
            set { BackingStore?.Set("allowedDomainGuidsForSyncApp", value); }
        }
#nullable restore
#else
        public List<Guid?> AllowedDomainGuidsForSyncApp {
            get { return BackingStore?.Get<List<Guid?>>("allowedDomainGuidsForSyncApp"); }
            set { BackingStore?.Set("allowedDomainGuidsForSyncApp", value); }
        }
#endif
        /// <summary>The availableManagedPathsForSiteCreation property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? AvailableManagedPathsForSiteCreation {
            get { return BackingStore?.Get<List<string>?>("availableManagedPathsForSiteCreation"); }
            set { BackingStore?.Set("availableManagedPathsForSiteCreation", value); }
        }
#nullable restore
#else
        public List<string> AvailableManagedPathsForSiteCreation {
            get { return BackingStore?.Get<List<string>>("availableManagedPathsForSiteCreation"); }
            set { BackingStore?.Set("availableManagedPathsForSiteCreation", value); }
        }
#endif
        /// <summary>The deletedUserPersonalSiteRetentionPeriodInDays property</summary>
        public int? DeletedUserPersonalSiteRetentionPeriodInDays {
            get { return BackingStore?.Get<int?>("deletedUserPersonalSiteRetentionPeriodInDays"); }
            set { BackingStore?.Set("deletedUserPersonalSiteRetentionPeriodInDays", value); }
        }
        /// <summary>The excludedFileExtensionsForSyncApp property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? ExcludedFileExtensionsForSyncApp {
            get { return BackingStore?.Get<List<string>?>("excludedFileExtensionsForSyncApp"); }
            set { BackingStore?.Set("excludedFileExtensionsForSyncApp", value); }
        }
#nullable restore
#else
        public List<string> ExcludedFileExtensionsForSyncApp {
            get { return BackingStore?.Get<List<string>>("excludedFileExtensionsForSyncApp"); }
            set { BackingStore?.Set("excludedFileExtensionsForSyncApp", value); }
        }
#endif
        /// <summary>The idleSessionSignOut property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public Microsoft.Graph.Beta.Models.IdleSessionSignOut? IdleSessionSignOut {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdleSessionSignOut?>("idleSessionSignOut"); }
            set { BackingStore?.Set("idleSessionSignOut", value); }
        }
#nullable restore
#else
        public Microsoft.Graph.Beta.Models.IdleSessionSignOut IdleSessionSignOut {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IdleSessionSignOut>("idleSessionSignOut"); }
            set { BackingStore?.Set("idleSessionSignOut", value); }
        }
#endif
        /// <summary>The imageTaggingOption property</summary>
        public ImageTaggingChoice? ImageTaggingOption {
            get { return BackingStore?.Get<ImageTaggingChoice?>("imageTaggingOption"); }
            set { BackingStore?.Set("imageTaggingOption", value); }
        }
        /// <summary>The isCommentingOnSitePagesEnabled property</summary>
        public bool? IsCommentingOnSitePagesEnabled {
            get { return BackingStore?.Get<bool?>("isCommentingOnSitePagesEnabled"); }
            set { BackingStore?.Set("isCommentingOnSitePagesEnabled", value); }
        }
        /// <summary>The isFileActivityNotificationEnabled property</summary>
        public bool? IsFileActivityNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isFileActivityNotificationEnabled"); }
            set { BackingStore?.Set("isFileActivityNotificationEnabled", value); }
        }
        /// <summary>The isLegacyAuthProtocolsEnabled property</summary>
        public bool? IsLegacyAuthProtocolsEnabled {
            get { return BackingStore?.Get<bool?>("isLegacyAuthProtocolsEnabled"); }
            set { BackingStore?.Set("isLegacyAuthProtocolsEnabled", value); }
        }
        /// <summary>The isLoopEnabled property</summary>
        public bool? IsLoopEnabled {
            get { return BackingStore?.Get<bool?>("isLoopEnabled"); }
            set { BackingStore?.Set("isLoopEnabled", value); }
        }
        /// <summary>The isMacSyncAppEnabled property</summary>
        public bool? IsMacSyncAppEnabled {
            get { return BackingStore?.Get<bool?>("isMacSyncAppEnabled"); }
            set { BackingStore?.Set("isMacSyncAppEnabled", value); }
        }
        /// <summary>The isRequireAcceptingUserToMatchInvitedUserEnabled property</summary>
        public bool? IsRequireAcceptingUserToMatchInvitedUserEnabled {
            get { return BackingStore?.Get<bool?>("isRequireAcceptingUserToMatchInvitedUserEnabled"); }
            set { BackingStore?.Set("isRequireAcceptingUserToMatchInvitedUserEnabled", value); }
        }
        /// <summary>The isResharingByExternalUsersEnabled property</summary>
        public bool? IsResharingByExternalUsersEnabled {
            get { return BackingStore?.Get<bool?>("isResharingByExternalUsersEnabled"); }
            set { BackingStore?.Set("isResharingByExternalUsersEnabled", value); }
        }
        /// <summary>The isSharePointMobileNotificationEnabled property</summary>
        public bool? IsSharePointMobileNotificationEnabled {
            get { return BackingStore?.Get<bool?>("isSharePointMobileNotificationEnabled"); }
            set { BackingStore?.Set("isSharePointMobileNotificationEnabled", value); }
        }
        /// <summary>The isSharePointNewsfeedEnabled property</summary>
        public bool? IsSharePointNewsfeedEnabled {
            get { return BackingStore?.Get<bool?>("isSharePointNewsfeedEnabled"); }
            set { BackingStore?.Set("isSharePointNewsfeedEnabled", value); }
        }
        /// <summary>The isSiteCreationEnabled property</summary>
        public bool? IsSiteCreationEnabled {
            get { return BackingStore?.Get<bool?>("isSiteCreationEnabled"); }
            set { BackingStore?.Set("isSiteCreationEnabled", value); }
        }
        /// <summary>The isSiteCreationUIEnabled property</summary>
        public bool? IsSiteCreationUIEnabled {
            get { return BackingStore?.Get<bool?>("isSiteCreationUIEnabled"); }
            set { BackingStore?.Set("isSiteCreationUIEnabled", value); }
        }
        /// <summary>The isSitePagesCreationEnabled property</summary>
        public bool? IsSitePagesCreationEnabled {
            get { return BackingStore?.Get<bool?>("isSitePagesCreationEnabled"); }
            set { BackingStore?.Set("isSitePagesCreationEnabled", value); }
        }
        /// <summary>The isSitesStorageLimitAutomatic property</summary>
        public bool? IsSitesStorageLimitAutomatic {
            get { return BackingStore?.Get<bool?>("isSitesStorageLimitAutomatic"); }
            set { BackingStore?.Set("isSitesStorageLimitAutomatic", value); }
        }
        /// <summary>The isSyncButtonHiddenOnPersonalSite property</summary>
        public bool? IsSyncButtonHiddenOnPersonalSite {
            get { return BackingStore?.Get<bool?>("isSyncButtonHiddenOnPersonalSite"); }
            set { BackingStore?.Set("isSyncButtonHiddenOnPersonalSite", value); }
        }
        /// <summary>The isUnmanagedSyncAppForTenantRestricted property</summary>
        public bool? IsUnmanagedSyncAppForTenantRestricted {
            get { return BackingStore?.Get<bool?>("isUnmanagedSyncAppForTenantRestricted"); }
            set { BackingStore?.Set("isUnmanagedSyncAppForTenantRestricted", value); }
        }
        /// <summary>The personalSiteDefaultStorageLimitInMB property</summary>
        public long? PersonalSiteDefaultStorageLimitInMB {
            get { return BackingStore?.Get<long?>("personalSiteDefaultStorageLimitInMB"); }
            set { BackingStore?.Set("personalSiteDefaultStorageLimitInMB", value); }
        }
        /// <summary>The sharingAllowedDomainList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SharingAllowedDomainList {
            get { return BackingStore?.Get<List<string>?>("sharingAllowedDomainList"); }
            set { BackingStore?.Set("sharingAllowedDomainList", value); }
        }
#nullable restore
#else
        public List<string> SharingAllowedDomainList {
            get { return BackingStore?.Get<List<string>>("sharingAllowedDomainList"); }
            set { BackingStore?.Set("sharingAllowedDomainList", value); }
        }
#endif
        /// <summary>The sharingBlockedDomainList property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<string>? SharingBlockedDomainList {
            get { return BackingStore?.Get<List<string>?>("sharingBlockedDomainList"); }
            set { BackingStore?.Set("sharingBlockedDomainList", value); }
        }
#nullable restore
#else
        public List<string> SharingBlockedDomainList {
            get { return BackingStore?.Get<List<string>>("sharingBlockedDomainList"); }
            set { BackingStore?.Set("sharingBlockedDomainList", value); }
        }
#endif
        /// <summary>The sharingCapability property</summary>
        public SharingCapabilities? SharingCapability {
            get { return BackingStore?.Get<SharingCapabilities?>("sharingCapability"); }
            set { BackingStore?.Set("sharingCapability", value); }
        }
        /// <summary>The sharingDomainRestrictionMode property</summary>
        public Microsoft.Graph.Beta.Models.SharingDomainRestrictionMode? SharingDomainRestrictionMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SharingDomainRestrictionMode?>("sharingDomainRestrictionMode"); }
            set { BackingStore?.Set("sharingDomainRestrictionMode", value); }
        }
        /// <summary>The siteCreationDefaultManagedPath property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SiteCreationDefaultManagedPath {
            get { return BackingStore?.Get<string?>("siteCreationDefaultManagedPath"); }
            set { BackingStore?.Set("siteCreationDefaultManagedPath", value); }
        }
#nullable restore
#else
        public string SiteCreationDefaultManagedPath {
            get { return BackingStore?.Get<string>("siteCreationDefaultManagedPath"); }
            set { BackingStore?.Set("siteCreationDefaultManagedPath", value); }
        }
#endif
        /// <summary>The siteCreationDefaultStorageLimitInMB property</summary>
        public int? SiteCreationDefaultStorageLimitInMB {
            get { return BackingStore?.Get<int?>("siteCreationDefaultStorageLimitInMB"); }
            set { BackingStore?.Set("siteCreationDefaultStorageLimitInMB", value); }
        }
        /// <summary>The tenantDefaultTimezone property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? TenantDefaultTimezone {
            get { return BackingStore?.Get<string?>("tenantDefaultTimezone"); }
            set { BackingStore?.Set("tenantDefaultTimezone", value); }
        }
#nullable restore
#else
        public string TenantDefaultTimezone {
            get { return BackingStore?.Get<string>("tenantDefaultTimezone"); }
            set { BackingStore?.Set("tenantDefaultTimezone", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new SharepointSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharepointSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDomainGuidsForSyncApp", n => { AllowedDomainGuidsForSyncApp = n.GetCollectionOfPrimitiveValues<Guid?>()?.ToList(); } },
                {"availableManagedPathsForSiteCreation", n => { AvailableManagedPathsForSiteCreation = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"deletedUserPersonalSiteRetentionPeriodInDays", n => { DeletedUserPersonalSiteRetentionPeriodInDays = n.GetIntValue(); } },
                {"excludedFileExtensionsForSyncApp", n => { ExcludedFileExtensionsForSyncApp = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"idleSessionSignOut", n => { IdleSessionSignOut = n.GetObjectValue<Microsoft.Graph.Beta.Models.IdleSessionSignOut>(Microsoft.Graph.Beta.Models.IdleSessionSignOut.CreateFromDiscriminatorValue); } },
                {"imageTaggingOption", n => { ImageTaggingOption = n.GetEnumValue<ImageTaggingChoice>(); } },
                {"isCommentingOnSitePagesEnabled", n => { IsCommentingOnSitePagesEnabled = n.GetBoolValue(); } },
                {"isFileActivityNotificationEnabled", n => { IsFileActivityNotificationEnabled = n.GetBoolValue(); } },
                {"isLegacyAuthProtocolsEnabled", n => { IsLegacyAuthProtocolsEnabled = n.GetBoolValue(); } },
                {"isLoopEnabled", n => { IsLoopEnabled = n.GetBoolValue(); } },
                {"isMacSyncAppEnabled", n => { IsMacSyncAppEnabled = n.GetBoolValue(); } },
                {"isRequireAcceptingUserToMatchInvitedUserEnabled", n => { IsRequireAcceptingUserToMatchInvitedUserEnabled = n.GetBoolValue(); } },
                {"isResharingByExternalUsersEnabled", n => { IsResharingByExternalUsersEnabled = n.GetBoolValue(); } },
                {"isSharePointMobileNotificationEnabled", n => { IsSharePointMobileNotificationEnabled = n.GetBoolValue(); } },
                {"isSharePointNewsfeedEnabled", n => { IsSharePointNewsfeedEnabled = n.GetBoolValue(); } },
                {"isSiteCreationEnabled", n => { IsSiteCreationEnabled = n.GetBoolValue(); } },
                {"isSiteCreationUIEnabled", n => { IsSiteCreationUIEnabled = n.GetBoolValue(); } },
                {"isSitePagesCreationEnabled", n => { IsSitePagesCreationEnabled = n.GetBoolValue(); } },
                {"isSitesStorageLimitAutomatic", n => { IsSitesStorageLimitAutomatic = n.GetBoolValue(); } },
                {"isSyncButtonHiddenOnPersonalSite", n => { IsSyncButtonHiddenOnPersonalSite = n.GetBoolValue(); } },
                {"isUnmanagedSyncAppForTenantRestricted", n => { IsUnmanagedSyncAppForTenantRestricted = n.GetBoolValue(); } },
                {"personalSiteDefaultStorageLimitInMB", n => { PersonalSiteDefaultStorageLimitInMB = n.GetLongValue(); } },
                {"sharingAllowedDomainList", n => { SharingAllowedDomainList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sharingBlockedDomainList", n => { SharingBlockedDomainList = n.GetCollectionOfPrimitiveValues<string>()?.ToList(); } },
                {"sharingCapability", n => { SharingCapability = n.GetEnumValue<SharingCapabilities>(); } },
                {"sharingDomainRestrictionMode", n => { SharingDomainRestrictionMode = n.GetEnumValue<SharingDomainRestrictionMode>(); } },
                {"siteCreationDefaultManagedPath", n => { SiteCreationDefaultManagedPath = n.GetStringValue(); } },
                {"siteCreationDefaultStorageLimitInMB", n => { SiteCreationDefaultStorageLimitInMB = n.GetIntValue(); } },
                {"tenantDefaultTimezone", n => { TenantDefaultTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<Guid?>("allowedDomainGuidsForSyncApp", AllowedDomainGuidsForSyncApp);
            writer.WriteCollectionOfPrimitiveValues<string>("availableManagedPathsForSiteCreation", AvailableManagedPathsForSiteCreation);
            writer.WriteIntValue("deletedUserPersonalSiteRetentionPeriodInDays", DeletedUserPersonalSiteRetentionPeriodInDays);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedFileExtensionsForSyncApp", ExcludedFileExtensionsForSyncApp);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.IdleSessionSignOut>("idleSessionSignOut", IdleSessionSignOut);
            writer.WriteEnumValue<ImageTaggingChoice>("imageTaggingOption", ImageTaggingOption);
            writer.WriteBoolValue("isCommentingOnSitePagesEnabled", IsCommentingOnSitePagesEnabled);
            writer.WriteBoolValue("isFileActivityNotificationEnabled", IsFileActivityNotificationEnabled);
            writer.WriteBoolValue("isLegacyAuthProtocolsEnabled", IsLegacyAuthProtocolsEnabled);
            writer.WriteBoolValue("isLoopEnabled", IsLoopEnabled);
            writer.WriteBoolValue("isMacSyncAppEnabled", IsMacSyncAppEnabled);
            writer.WriteBoolValue("isRequireAcceptingUserToMatchInvitedUserEnabled", IsRequireAcceptingUserToMatchInvitedUserEnabled);
            writer.WriteBoolValue("isResharingByExternalUsersEnabled", IsResharingByExternalUsersEnabled);
            writer.WriteBoolValue("isSharePointMobileNotificationEnabled", IsSharePointMobileNotificationEnabled);
            writer.WriteBoolValue("isSharePointNewsfeedEnabled", IsSharePointNewsfeedEnabled);
            writer.WriteBoolValue("isSiteCreationEnabled", IsSiteCreationEnabled);
            writer.WriteBoolValue("isSiteCreationUIEnabled", IsSiteCreationUIEnabled);
            writer.WriteBoolValue("isSitePagesCreationEnabled", IsSitePagesCreationEnabled);
            writer.WriteBoolValue("isSitesStorageLimitAutomatic", IsSitesStorageLimitAutomatic);
            writer.WriteBoolValue("isSyncButtonHiddenOnPersonalSite", IsSyncButtonHiddenOnPersonalSite);
            writer.WriteBoolValue("isUnmanagedSyncAppForTenantRestricted", IsUnmanagedSyncAppForTenantRestricted);
            writer.WriteLongValue("personalSiteDefaultStorageLimitInMB", PersonalSiteDefaultStorageLimitInMB);
            writer.WriteCollectionOfPrimitiveValues<string>("sharingAllowedDomainList", SharingAllowedDomainList);
            writer.WriteCollectionOfPrimitiveValues<string>("sharingBlockedDomainList", SharingBlockedDomainList);
            writer.WriteEnumValue<SharingCapabilities>("sharingCapability", SharingCapability);
            writer.WriteEnumValue<SharingDomainRestrictionMode>("sharingDomainRestrictionMode", SharingDomainRestrictionMode);
            writer.WriteStringValue("siteCreationDefaultManagedPath", SiteCreationDefaultManagedPath);
            writer.WriteIntValue("siteCreationDefaultStorageLimitInMB", SiteCreationDefaultStorageLimitInMB);
            writer.WriteStringValue("tenantDefaultTimezone", TenantDefaultTimezone);
        }
    }
}
