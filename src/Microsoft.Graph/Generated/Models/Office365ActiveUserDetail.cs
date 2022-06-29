using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Office365ActiveUserDetail : Entity, IParsable {
        /// <summary>All the products assigned for the user.</summary>
        public List<string> AssignedProducts {
            get { return BackingStore?.Get<List<string>>(nameof(AssignedProducts)); }
            set { BackingStore?.Set(nameof(AssignedProducts), value); }
        }
        /// <summary>The date when the delete operation happened. Default value is &apos;null&apos; when the user has not been deleted.</summary>
        public Date? DeletedDate {
            get { return BackingStore?.Get<Date?>(nameof(DeletedDate)); }
            set { BackingStore?.Set(nameof(DeletedDate), value); }
        }
        /// <summary>The name displayed in the address book for the user. This is usually the combination of the user&apos;s first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>The date when user last read or sent email.</summary>
        public Date? ExchangeLastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(ExchangeLastActivityDate)); }
            set { BackingStore?.Set(nameof(ExchangeLastActivityDate), value); }
        }
        /// <summary>The last date when the user was assigned an Exchange license.</summary>
        public Date? ExchangeLicenseAssignDate {
            get { return BackingStore?.Get<Date?>(nameof(ExchangeLicenseAssignDate)); }
            set { BackingStore?.Set(nameof(ExchangeLicenseAssignDate), value); }
        }
        /// <summary>Whether the user has been assigned an Exchange license.</summary>
        public bool? HasExchangeLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasExchangeLicense)); }
            set { BackingStore?.Set(nameof(HasExchangeLicense), value); }
        }
        /// <summary>Whether the user has been assigned a OneDrive license.</summary>
        public bool? HasOneDriveLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasOneDriveLicense)); }
            set { BackingStore?.Set(nameof(HasOneDriveLicense), value); }
        }
        /// <summary>Whether the user has been assigned a SharePoint license.</summary>
        public bool? HasSharePointLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasSharePointLicense)); }
            set { BackingStore?.Set(nameof(HasSharePointLicense), value); }
        }
        /// <summary>Whether the user has been assigned a Skype For Business license.</summary>
        public bool? HasSkypeForBusinessLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasSkypeForBusinessLicense)); }
            set { BackingStore?.Set(nameof(HasSkypeForBusinessLicense), value); }
        }
        /// <summary>Whether the user has been assigned a Teams license.</summary>
        public bool? HasTeamsLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasTeamsLicense)); }
            set { BackingStore?.Set(nameof(HasTeamsLicense), value); }
        }
        /// <summary>Whether the user has been assigned a Yammer license.</summary>
        public bool? HasYammerLicense {
            get { return BackingStore?.Get<bool?>(nameof(HasYammerLicense)); }
            set { BackingStore?.Set(nameof(HasYammerLicense), value); }
        }
        /// <summary>Whether this user has been deleted or soft deleted.</summary>
        public bool? IsDeleted {
            get { return BackingStore?.Get<bool?>(nameof(IsDeleted)); }
            set { BackingStore?.Set(nameof(IsDeleted), value); }
        }
        /// <summary>The date when user last viewed or edited files, shared files internally or externally, or synced files.</summary>
        public Date? OneDriveLastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(OneDriveLastActivityDate)); }
            set { BackingStore?.Set(nameof(OneDriveLastActivityDate), value); }
        }
        /// <summary>The last date when the user was assigned a OneDrive license.</summary>
        public Date? OneDriveLicenseAssignDate {
            get { return BackingStore?.Get<Date?>(nameof(OneDriveLicenseAssignDate)); }
            set { BackingStore?.Set(nameof(OneDriveLicenseAssignDate), value); }
        }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate {
            get { return BackingStore?.Get<Date?>(nameof(ReportRefreshDate)); }
            set { BackingStore?.Set(nameof(ReportRefreshDate), value); }
        }
        /// <summary>The date when user last viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages.</summary>
        public Date? SharePointLastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(SharePointLastActivityDate)); }
            set { BackingStore?.Set(nameof(SharePointLastActivityDate), value); }
        }
        /// <summary>The last date when the user was assigned a SharePoint license.</summary>
        public Date? SharePointLicenseAssignDate {
            get { return BackingStore?.Get<Date?>(nameof(SharePointLicenseAssignDate)); }
            set { BackingStore?.Set(nameof(SharePointLicenseAssignDate), value); }
        }
        /// <summary>The date when user last organized or participated in conferences, or joined peer-to-peer sessions.</summary>
        public Date? SkypeForBusinessLastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(SkypeForBusinessLastActivityDate)); }
            set { BackingStore?.Set(nameof(SkypeForBusinessLastActivityDate), value); }
        }
        /// <summary>The last date when the user was assigned a Skype For Business license.</summary>
        public Date? SkypeForBusinessLicenseAssignDate {
            get { return BackingStore?.Get<Date?>(nameof(SkypeForBusinessLicenseAssignDate)); }
            set { BackingStore?.Set(nameof(SkypeForBusinessLicenseAssignDate), value); }
        }
        /// <summary>The date when user last posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls.</summary>
        public Date? TeamsLastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(TeamsLastActivityDate)); }
            set { BackingStore?.Set(nameof(TeamsLastActivityDate), value); }
        }
        /// <summary>The last date when the user was assigned a Teams license.</summary>
        public Date? TeamsLicenseAssignDate {
            get { return BackingStore?.Get<Date?>(nameof(TeamsLicenseAssignDate)); }
            set { BackingStore?.Set(nameof(TeamsLicenseAssignDate), value); }
        }
        /// <summary>The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user&apos;s email name. The general format is alias@domain, where domain must be present in the tenant’s collection of verified domains. This property is required when a user is created.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>The date when user last posted, read, or liked message.</summary>
        public Date? YammerLastActivityDate {
            get { return BackingStore?.Get<Date?>(nameof(YammerLastActivityDate)); }
            set { BackingStore?.Set(nameof(YammerLastActivityDate), value); }
        }
        /// <summary>The last date when the user was assigned a Yammer license.</summary>
        public Date? YammerLicenseAssignDate {
            get { return BackingStore?.Get<Date?>(nameof(YammerLicenseAssignDate)); }
            set { BackingStore?.Set(nameof(YammerLicenseAssignDate), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Office365ActiveUserDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Office365ActiveUserDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"assignedProducts", n => { AssignedProducts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deletedDate", n => { DeletedDate = n.GetDateValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"exchangeLastActivityDate", n => { ExchangeLastActivityDate = n.GetDateValue(); } },
                {"exchangeLicenseAssignDate", n => { ExchangeLicenseAssignDate = n.GetDateValue(); } },
                {"hasExchangeLicense", n => { HasExchangeLicense = n.GetBoolValue(); } },
                {"hasOneDriveLicense", n => { HasOneDriveLicense = n.GetBoolValue(); } },
                {"hasSharePointLicense", n => { HasSharePointLicense = n.GetBoolValue(); } },
                {"hasSkypeForBusinessLicense", n => { HasSkypeForBusinessLicense = n.GetBoolValue(); } },
                {"hasTeamsLicense", n => { HasTeamsLicense = n.GetBoolValue(); } },
                {"hasYammerLicense", n => { HasYammerLicense = n.GetBoolValue(); } },
                {"isDeleted", n => { IsDeleted = n.GetBoolValue(); } },
                {"oneDriveLastActivityDate", n => { OneDriveLastActivityDate = n.GetDateValue(); } },
                {"oneDriveLicenseAssignDate", n => { OneDriveLicenseAssignDate = n.GetDateValue(); } },
                {"reportRefreshDate", n => { ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointLastActivityDate", n => { SharePointLastActivityDate = n.GetDateValue(); } },
                {"sharePointLicenseAssignDate", n => { SharePointLicenseAssignDate = n.GetDateValue(); } },
                {"skypeForBusinessLastActivityDate", n => { SkypeForBusinessLastActivityDate = n.GetDateValue(); } },
                {"skypeForBusinessLicenseAssignDate", n => { SkypeForBusinessLicenseAssignDate = n.GetDateValue(); } },
                {"teamsLastActivityDate", n => { TeamsLastActivityDate = n.GetDateValue(); } },
                {"teamsLicenseAssignDate", n => { TeamsLicenseAssignDate = n.GetDateValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"yammerLastActivityDate", n => { YammerLastActivityDate = n.GetDateValue(); } },
                {"yammerLicenseAssignDate", n => { YammerLicenseAssignDate = n.GetDateValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfPrimitiveValues<string>("assignedProducts", AssignedProducts);
            writer.WriteDateValue("deletedDate", DeletedDate);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteDateValue("exchangeLastActivityDate", ExchangeLastActivityDate);
            writer.WriteDateValue("exchangeLicenseAssignDate", ExchangeLicenseAssignDate);
            writer.WriteBoolValue("hasExchangeLicense", HasExchangeLicense);
            writer.WriteBoolValue("hasOneDriveLicense", HasOneDriveLicense);
            writer.WriteBoolValue("hasSharePointLicense", HasSharePointLicense);
            writer.WriteBoolValue("hasSkypeForBusinessLicense", HasSkypeForBusinessLicense);
            writer.WriteBoolValue("hasTeamsLicense", HasTeamsLicense);
            writer.WriteBoolValue("hasYammerLicense", HasYammerLicense);
            writer.WriteBoolValue("isDeleted", IsDeleted);
            writer.WriteDateValue("oneDriveLastActivityDate", OneDriveLastActivityDate);
            writer.WriteDateValue("oneDriveLicenseAssignDate", OneDriveLicenseAssignDate);
            writer.WriteDateValue("reportRefreshDate", ReportRefreshDate);
            writer.WriteDateValue("sharePointLastActivityDate", SharePointLastActivityDate);
            writer.WriteDateValue("sharePointLicenseAssignDate", SharePointLicenseAssignDate);
            writer.WriteDateValue("skypeForBusinessLastActivityDate", SkypeForBusinessLastActivityDate);
            writer.WriteDateValue("skypeForBusinessLicenseAssignDate", SkypeForBusinessLicenseAssignDate);
            writer.WriteDateValue("teamsLastActivityDate", TeamsLastActivityDate);
            writer.WriteDateValue("teamsLicenseAssignDate", TeamsLicenseAssignDate);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteDateValue("yammerLastActivityDate", YammerLastActivityDate);
            writer.WriteDateValue("yammerLicenseAssignDate", YammerLicenseAssignDate);
        }
    }
}
