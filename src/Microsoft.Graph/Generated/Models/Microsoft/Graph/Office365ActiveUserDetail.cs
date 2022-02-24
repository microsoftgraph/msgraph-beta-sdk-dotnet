using Microsoft.Kiota.Abstractions;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class Office365ActiveUserDetail : Entity, IParsable {
        /// <summary>All the products assigned for the user.</summary>
        public List<string> AssignedProducts { get; set; }
        /// <summary>The date when the delete operation happened. Default value is 'null' when the user has not been deleted.</summary>
        public Date? DeletedDate { get; set; }
        /// <summary>The name displayed in the address book for the user. This is usually the combination of the user's first name, middle initial, and last name. This property is required when a user is created and it cannot be cleared during updates.</summary>
        public string DisplayName { get; set; }
        /// <summary>The date when user last read or sent email.</summary>
        public Date? ExchangeLastActivityDate { get; set; }
        /// <summary>The last date when the user was assigned an Exchange license.</summary>
        public Date? ExchangeLicenseAssignDate { get; set; }
        /// <summary>Whether the user has been assigned an Exchange license.</summary>
        public bool? HasExchangeLicense { get; set; }
        /// <summary>Whether the user has been assigned a OneDrive license.</summary>
        public bool? HasOneDriveLicense { get; set; }
        /// <summary>Whether the user has been assigned a SharePoint license.</summary>
        public bool? HasSharePointLicense { get; set; }
        /// <summary>Whether the user has been assigned a Skype For Business license.</summary>
        public bool? HasSkypeForBusinessLicense { get; set; }
        /// <summary>Whether the user has been assigned a Teams license.</summary>
        public bool? HasTeamsLicense { get; set; }
        /// <summary>Whether the user has been assigned a Yammer license.</summary>
        public bool? HasYammerLicense { get; set; }
        /// <summary>Whether this user has been deleted or soft deleted.</summary>
        public bool? IsDeleted { get; set; }
        /// <summary>The date when user last viewed or edited files, shared files internally or externally, or synced files.</summary>
        public Date? OneDriveLastActivityDate { get; set; }
        /// <summary>The last date when the user was assigned a OneDrive license.</summary>
        public Date? OneDriveLicenseAssignDate { get; set; }
        /// <summary>The latest date of the content.</summary>
        public Date? ReportRefreshDate { get; set; }
        /// <summary>The date when user last viewed or edited files, shared files internally or externally, synced files, or viewed SharePoint pages.</summary>
        public Date? SharePointLastActivityDate { get; set; }
        /// <summary>The last date when the user was assigned a SharePoint license.</summary>
        public Date? SharePointLicenseAssignDate { get; set; }
        /// <summary>The date when user last organized or participated in conferences, or joined peer-to-peer sessions.</summary>
        public Date? SkypeForBusinessLastActivityDate { get; set; }
        /// <summary>The last date when the user was assigned a Skype For Business license.</summary>
        public Date? SkypeForBusinessLicenseAssignDate { get; set; }
        /// <summary>The date when user last posted messages in team channels, sent messages in private chat sessions, or participated in meetings or calls.</summary>
        public Date? TeamsLastActivityDate { get; set; }
        /// <summary>The last date when the user was assigned a Teams license.</summary>
        public Date? TeamsLicenseAssignDate { get; set; }
        /// <summary>The user principal name (UPN) of the user. The UPN is an Internet-style login name for the user based on the Internet standard RFC 822. By convention, this should map to the user's email name. The general format is alias@domain, where domain must be present in the tenant’s collection of verified domains. This property is required when a user is created.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>The date when user last posted, read, or liked message.</summary>
        public Date? YammerLastActivityDate { get; set; }
        /// <summary>The last date when the user was assigned a Yammer license.</summary>
        public Date? YammerLicenseAssignDate { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignedProducts", (o,n) => { (o as Office365ActiveUserDetail).AssignedProducts = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"deletedDate", (o,n) => { (o as Office365ActiveUserDetail).DeletedDate = n.GetDateValue(); } },
                {"displayName", (o,n) => { (o as Office365ActiveUserDetail).DisplayName = n.GetStringValue(); } },
                {"exchangeLastActivityDate", (o,n) => { (o as Office365ActiveUserDetail).ExchangeLastActivityDate = n.GetDateValue(); } },
                {"exchangeLicenseAssignDate", (o,n) => { (o as Office365ActiveUserDetail).ExchangeLicenseAssignDate = n.GetDateValue(); } },
                {"hasExchangeLicense", (o,n) => { (o as Office365ActiveUserDetail).HasExchangeLicense = n.GetBoolValue(); } },
                {"hasOneDriveLicense", (o,n) => { (o as Office365ActiveUserDetail).HasOneDriveLicense = n.GetBoolValue(); } },
                {"hasSharePointLicense", (o,n) => { (o as Office365ActiveUserDetail).HasSharePointLicense = n.GetBoolValue(); } },
                {"hasSkypeForBusinessLicense", (o,n) => { (o as Office365ActiveUserDetail).HasSkypeForBusinessLicense = n.GetBoolValue(); } },
                {"hasTeamsLicense", (o,n) => { (o as Office365ActiveUserDetail).HasTeamsLicense = n.GetBoolValue(); } },
                {"hasYammerLicense", (o,n) => { (o as Office365ActiveUserDetail).HasYammerLicense = n.GetBoolValue(); } },
                {"isDeleted", (o,n) => { (o as Office365ActiveUserDetail).IsDeleted = n.GetBoolValue(); } },
                {"oneDriveLastActivityDate", (o,n) => { (o as Office365ActiveUserDetail).OneDriveLastActivityDate = n.GetDateValue(); } },
                {"oneDriveLicenseAssignDate", (o,n) => { (o as Office365ActiveUserDetail).OneDriveLicenseAssignDate = n.GetDateValue(); } },
                {"reportRefreshDate", (o,n) => { (o as Office365ActiveUserDetail).ReportRefreshDate = n.GetDateValue(); } },
                {"sharePointLastActivityDate", (o,n) => { (o as Office365ActiveUserDetail).SharePointLastActivityDate = n.GetDateValue(); } },
                {"sharePointLicenseAssignDate", (o,n) => { (o as Office365ActiveUserDetail).SharePointLicenseAssignDate = n.GetDateValue(); } },
                {"skypeForBusinessLastActivityDate", (o,n) => { (o as Office365ActiveUserDetail).SkypeForBusinessLastActivityDate = n.GetDateValue(); } },
                {"skypeForBusinessLicenseAssignDate", (o,n) => { (o as Office365ActiveUserDetail).SkypeForBusinessLicenseAssignDate = n.GetDateValue(); } },
                {"teamsLastActivityDate", (o,n) => { (o as Office365ActiveUserDetail).TeamsLastActivityDate = n.GetDateValue(); } },
                {"teamsLicenseAssignDate", (o,n) => { (o as Office365ActiveUserDetail).TeamsLicenseAssignDate = n.GetDateValue(); } },
                {"userPrincipalName", (o,n) => { (o as Office365ActiveUserDetail).UserPrincipalName = n.GetStringValue(); } },
                {"yammerLastActivityDate", (o,n) => { (o as Office365ActiveUserDetail).YammerLastActivityDate = n.GetDateValue(); } },
                {"yammerLicenseAssignDate", (o,n) => { (o as Office365ActiveUserDetail).YammerLicenseAssignDate = n.GetDateValue(); } },
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
