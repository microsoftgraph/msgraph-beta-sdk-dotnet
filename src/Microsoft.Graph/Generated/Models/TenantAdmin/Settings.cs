using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.TenantAdmin {
    /// <summary>Provides operations to manage the admin singleton.</summary>
    public class Settings : Entity, IParsable {
        /// <summary>Collection of trusted domain GUIDs for the OneDrive sync app.</summary>
        public List<string> AllowedDomainGuidsForSyncApp {
            get { return BackingStore?.Get<List<string>>(nameof(AllowedDomainGuidsForSyncApp)); }
            set { BackingStore?.Set(nameof(AllowedDomainGuidsForSyncApp), value); }
        }
        /// <summary>Collection of managed paths available for site creation. Read-only.</summary>
        public List<string> AvailableManagedPathsForSiteCreation {
            get { return BackingStore?.Get<List<string>>(nameof(AvailableManagedPathsForSiteCreation)); }
            set { BackingStore?.Set(nameof(AvailableManagedPathsForSiteCreation), value); }
        }
        /// <summary>The number of days for preserving a deleted user&apos;s OneDrive.</summary>
        public int? DeletedUserPersonalSiteRetentionPeriodInDays {
            get { return BackingStore?.Get<int?>(nameof(DeletedUserPersonalSiteRetentionPeriodInDays)); }
            set { BackingStore?.Set(nameof(DeletedUserPersonalSiteRetentionPeriodInDays), value); }
        }
        /// <summary>Collection of file extensions not uploaded by the OneDrive sync app.</summary>
        public List<string> ExcludedFileExtensionsForSyncApp {
            get { return BackingStore?.Get<List<string>>(nameof(ExcludedFileExtensionsForSyncApp)); }
            set { BackingStore?.Set(nameof(ExcludedFileExtensionsForSyncApp), value); }
        }
        /// <summary>Specifies the image tagging option for the tenant. Possible values are: disabled, basic, enhanced.</summary>
        public ImageTaggingChoice? ImageTaggingOption {
            get { return BackingStore?.Get<ImageTaggingChoice?>(nameof(ImageTaggingOption)); }
            set { BackingStore?.Set(nameof(ImageTaggingOption), value); }
        }
        /// <summary>Indicates whether comments are allowed on modern site pages in SharePoint.</summary>
        public bool? IsCommentingOnSitePagesEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsCommentingOnSitePagesEnabled)); }
            set { BackingStore?.Set(nameof(IsCommentingOnSitePagesEnabled), value); }
        }
        /// <summary>Indicates whether push notifications are enabled for OneDrive events.</summary>
        public bool? IsFileActivityNotificationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsFileActivityNotificationEnabled)); }
            set { BackingStore?.Set(nameof(IsFileActivityNotificationEnabled), value); }
        }
        /// <summary>Indicates whetherif Fluid Framework is allowed on SharePoint sites.</summary>
        public bool? IsLoopEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsLoopEnabled)); }
            set { BackingStore?.Set(nameof(IsLoopEnabled), value); }
        }
        /// <summary>Indicates whether files can be synced using the OneDrive sync app for Mac.</summary>
        public bool? IsMacSyncAppEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsMacSyncAppEnabled)); }
            set { BackingStore?.Set(nameof(IsMacSyncAppEnabled), value); }
        }
        /// <summary>Indicates whether guests are allowed to reshare files, folders, and sites they don&apos;t own.</summary>
        public bool? IsResharingByExternalUsersEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsResharingByExternalUsersEnabled)); }
            set { BackingStore?.Set(nameof(IsResharingByExternalUsersEnabled), value); }
        }
        /// <summary>Indicates whether mobile push notifications are enabled for SharePoint.</summary>
        public bool? IsSharePointMobileNotificationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsSharePointMobileNotificationEnabled)); }
            set { BackingStore?.Set(nameof(IsSharePointMobileNotificationEnabled), value); }
        }
        /// <summary>Indicates whether the newsfeed is allowed on the modern site pages in SharePoint.</summary>
        public bool? IsSharePointNewsfeedEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsSharePointNewsfeedEnabled)); }
            set { BackingStore?.Set(nameof(IsSharePointNewsfeedEnabled), value); }
        }
        /// <summary>Indicates whether users are allowed to create sites.</summary>
        public bool? IsSiteCreationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsSiteCreationEnabled)); }
            set { BackingStore?.Set(nameof(IsSiteCreationEnabled), value); }
        }
        /// <summary>Indicates whether the UI commands for creating sites are shown.</summary>
        public bool? IsSiteCreationUIEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsSiteCreationUIEnabled)); }
            set { BackingStore?.Set(nameof(IsSiteCreationUIEnabled), value); }
        }
        /// <summary>Indicates whether creating new modern pages is allowed on SharePoint sites.</summary>
        public bool? IsSitePagesCreationEnabled {
            get { return BackingStore?.Get<bool?>(nameof(IsSitePagesCreationEnabled)); }
            set { BackingStore?.Set(nameof(IsSitePagesCreationEnabled), value); }
        }
        /// <summary>Indicates whether site storage space is automatically managed or if specific storage limits are set per site.</summary>
        public bool? IsSitesStorageLimitAutomatic {
            get { return BackingStore?.Get<bool?>(nameof(IsSitesStorageLimitAutomatic)); }
            set { BackingStore?.Set(nameof(IsSitesStorageLimitAutomatic), value); }
        }
        /// <summary>Indicates whether the sync button in OneDrive is hidden.</summary>
        public bool? IsSyncButtonHiddenOnPersonalSite {
            get { return BackingStore?.Get<bool?>(nameof(IsSyncButtonHiddenOnPersonalSite)); }
            set { BackingStore?.Set(nameof(IsSyncButtonHiddenOnPersonalSite), value); }
        }
        /// <summary>Indicates whether users are allowed to sync files only on PCs joined to specific domains.</summary>
        public bool? IsUnmanagedSyncAppForTenantRestricted {
            get { return BackingStore?.Get<bool?>(nameof(IsUnmanagedSyncAppForTenantRestricted)); }
            set { BackingStore?.Set(nameof(IsUnmanagedSyncAppForTenantRestricted), value); }
        }
        /// <summary>The default OneDrive storage limit for all new and existing users who are assigned a qualifying license. Measured in megabytes (MB).</summary>
        public long? PersonalSiteDefaultStorageLimitInMB {
            get { return BackingStore?.Get<long?>(nameof(PersonalSiteDefaultStorageLimitInMB)); }
            set { BackingStore?.Set(nameof(PersonalSiteDefaultStorageLimitInMB), value); }
        }
        /// <summary>Collection of email domains that are allowed for sharing outside the organization.</summary>
        public List<string> SharingAllowedDomainList {
            get { return BackingStore?.Get<List<string>>(nameof(SharingAllowedDomainList)); }
            set { BackingStore?.Set(nameof(SharingAllowedDomainList), value); }
        }
        /// <summary>Collection of email domains that are blocked for sharing outside the organization.</summary>
        public List<string> SharingBlockedDomainList {
            get { return BackingStore?.Get<List<string>>(nameof(SharingBlockedDomainList)); }
            set { BackingStore?.Set(nameof(SharingBlockedDomainList), value); }
        }
        /// <summary>Sharing capability for the tenant. Possible values are: disabled, externalUserSharingOnly, externalUserAndGuestSharing, existingExternalUserSharingOnly.</summary>
        public SharingCapabilities? SharingCapability {
            get { return BackingStore?.Get<SharingCapabilities?>(nameof(SharingCapability)); }
            set { BackingStore?.Set(nameof(SharingCapability), value); }
        }
        /// <summary>Specifies the external sharing mode for domains. Possible values are: none, allowList, blockList.</summary>
        public Microsoft.Graph.Beta.Models.TenantAdmin.SharingDomainRestrictionMode? SharingDomainRestrictionMode {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TenantAdmin.SharingDomainRestrictionMode?>(nameof(SharingDomainRestrictionMode)); }
            set { BackingStore?.Set(nameof(SharingDomainRestrictionMode), value); }
        }
        /// <summary>The value of the team site managed path. This is the path under which new team sites will be created.</summary>
        public string SiteCreationDefaultManagedPath {
            get { return BackingStore?.Get<string>(nameof(SiteCreationDefaultManagedPath)); }
            set { BackingStore?.Set(nameof(SiteCreationDefaultManagedPath), value); }
        }
        /// <summary>The default storage quota for a new site upon creation. Measured in megabytes (MB).</summary>
        public int? SiteCreationDefaultStorageLimitInMB {
            get { return BackingStore?.Get<int?>(nameof(SiteCreationDefaultStorageLimitInMB)); }
            set { BackingStore?.Set(nameof(SiteCreationDefaultStorageLimitInMB), value); }
        }
        /// <summary>The default timezone of a tenant for newly created sites.</summary>
        public string TenantDefaultTimezone {
            get { return BackingStore?.Get<string>(nameof(TenantDefaultTimezone)); }
            set { BackingStore?.Set(nameof(TenantDefaultTimezone), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Settings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Settings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"allowedDomainGuidsForSyncApp", n => { AllowedDomainGuidsForSyncApp = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"availableManagedPathsForSiteCreation", n => { AvailableManagedPathsForSiteCreation = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deletedUserPersonalSiteRetentionPeriodInDays", n => { DeletedUserPersonalSiteRetentionPeriodInDays = n.GetIntValue(); } },
                {"excludedFileExtensionsForSyncApp", n => { ExcludedFileExtensionsForSyncApp = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"imageTaggingOption", n => { ImageTaggingOption = n.GetEnumValue<ImageTaggingChoice>(); } },
                {"isCommentingOnSitePagesEnabled", n => { IsCommentingOnSitePagesEnabled = n.GetBoolValue(); } },
                {"isFileActivityNotificationEnabled", n => { IsFileActivityNotificationEnabled = n.GetBoolValue(); } },
                {"isLoopEnabled", n => { IsLoopEnabled = n.GetBoolValue(); } },
                {"isMacSyncAppEnabled", n => { IsMacSyncAppEnabled = n.GetBoolValue(); } },
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
                {"sharingAllowedDomainList", n => { SharingAllowedDomainList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sharingBlockedDomainList", n => { SharingBlockedDomainList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"sharingCapability", n => { SharingCapability = n.GetEnumValue<SharingCapabilities>(); } },
                {"sharingDomainRestrictionMode", n => { SharingDomainRestrictionMode = n.GetEnumValue<SharingDomainRestrictionMode>(); } },
                {"siteCreationDefaultManagedPath", n => { SiteCreationDefaultManagedPath = n.GetStringValue(); } },
                {"siteCreationDefaultStorageLimitInMB", n => { SiteCreationDefaultStorageLimitInMB = n.GetIntValue(); } },
                {"tenantDefaultTimezone", n => { TenantDefaultTimezone = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("allowedDomainGuidsForSyncApp", AllowedDomainGuidsForSyncApp);
            writer.WriteCollectionOfPrimitiveValues<string>("availableManagedPathsForSiteCreation", AvailableManagedPathsForSiteCreation);
            writer.WriteIntValue("deletedUserPersonalSiteRetentionPeriodInDays", DeletedUserPersonalSiteRetentionPeriodInDays);
            writer.WriteCollectionOfPrimitiveValues<string>("excludedFileExtensionsForSyncApp", ExcludedFileExtensionsForSyncApp);
            writer.WriteEnumValue<ImageTaggingChoice>("imageTaggingOption", ImageTaggingOption);
            writer.WriteBoolValue("isCommentingOnSitePagesEnabled", IsCommentingOnSitePagesEnabled);
            writer.WriteBoolValue("isFileActivityNotificationEnabled", IsFileActivityNotificationEnabled);
            writer.WriteBoolValue("isLoopEnabled", IsLoopEnabled);
            writer.WriteBoolValue("isMacSyncAppEnabled", IsMacSyncAppEnabled);
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
