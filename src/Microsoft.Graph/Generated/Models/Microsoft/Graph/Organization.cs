using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the collection of organization entities.</summary>
    public class Organization : DirectoryObject, IParsable {
        /// <summary>The collection of service plans associated with the tenant. Not nullable.</summary>
        public List<AssignedPlan> AssignedPlans { get; set; }
        public OrganizationalBranding Branding { get; set; }
        /// <summary>Telephone number for the organization. Although this is a string collection, only one number can be set for this property.</summary>
        public List<string> BusinessPhones { get; set; }
        /// <summary>Navigation property to manage certificate-based authentication configuration. Only a single instance of certificateBasedAuthConfiguration can be created in the collection.</summary>
        public List<MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateBasedAuthConfiguration> CertificateBasedAuthConfiguration { get; set; }
        /// <summary>Certificate connector setting.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateConnectorSetting CertificateConnectorSetting { get; set; }
        /// <summary>City name of the address for the organization.</summary>
        public string City { get; set; }
        /// <summary>Country/region name of the address for the organization.</summary>
        public string Country { get; set; }
        /// <summary>Country or region abbreviation for the organization in ISO 3166-2 format.</summary>
        public string CountryLetterCode { get; set; }
        /// <summary>Timestamp of when the organization was created. The value cannot be modified and is automatically populated when the organization is created. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The directory size quota information of an organization.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.DirectorySizeQuota DirectorySizeQuota { get; set; }
        /// <summary>The display name for the tenant.</summary>
        public string DisplayName { get; set; }
        /// <summary>The collection of open extensions defined for the organization. Read-only. Nullable.</summary>
        public List<Extension> Extensions { get; set; }
        /// <summary>true if organization is Multi-Geo enabled; false if organization is not Multi-Geo enabled; null (default). Read-only. For more information, see OneDrive Online Multi-Geo.</summary>
        public bool? IsMultipleDataLocationsForServicesEnabled { get; set; }
        /// <summary>Not nullable.</summary>
        public List<string> MarketingNotificationEmails { get; set; }
        /// <summary>Mobile device management authority. Possible values are: unknown, intune, sccm, office365.</summary>
        public MdmAuthority? MobileDeviceManagementAuthority { get; set; }
        /// <summary>The time and date at which the tenant was last synced with the on-premises directory. The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.</summary>
        public DateTimeOffset? OnPremisesLastSyncDateTime { get; set; }
        /// <summary>true if this object is synced from an on-premises directory; false if this object was originally synced from an on-premises directory but is no longer synced. Nullable. null if this object has never been synced from an on-premises directory (default).</summary>
        public bool? OnPremisesSyncEnabled { get; set; }
        /// <summary>Postal code of the address for the organization.</summary>
        public string PostalCode { get; set; }
        /// <summary>The preferred language for the organization. Should follow ISO 639-1 Code; for example, en.</summary>
        public string PreferredLanguage { get; set; }
        /// <summary>The privacy profile of an organization.</summary>
        public MicrosoftGraphSdk.Models.Microsoft.Graph.PrivacyProfile PrivacyProfile { get; set; }
        /// <summary>Not nullable.</summary>
        public List<ProvisionedPlan> ProvisionedPlans { get; set; }
        public List<string> SecurityComplianceNotificationMails { get; set; }
        public List<string> SecurityComplianceNotificationPhones { get; set; }
        /// <summary>Retrieve the properties and relationships of organizationSettings object. Nullable.</summary>
        public OrganizationSettings Settings { get; set; }
        /// <summary>State name of the address for the organization.</summary>
        public string State { get; set; }
        /// <summary>Street name of the address for organization.</summary>
        public string Street { get; set; }
        /// <summary>Not nullable.</summary>
        public List<string> TechnicalNotificationMails { get; set; }
        /// <summary>The collection of domains associated with this tenant. Not nullable.</summary>
        public List<VerifiedDomain> VerifiedDomains { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Organization CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Organization();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"assignedPlans", (o,n) => { (o as Organization).AssignedPlans = n.GetCollectionOfObjectValues<AssignedPlan>(AssignedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"branding", (o,n) => { (o as Organization).Branding = n.GetObjectValue<OrganizationalBranding>(OrganizationalBranding.CreateFromDiscriminatorValue); } },
                {"businessPhones", (o,n) => { (o as Organization).BusinessPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"certificateBasedAuthConfiguration", (o,n) => { (o as Organization).CertificateBasedAuthConfiguration = n.GetCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateBasedAuthConfiguration>(MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateBasedAuthConfiguration.CreateFromDiscriminatorValue).ToList(); } },
                {"certificateConnectorSetting", (o,n) => { (o as Organization).CertificateConnectorSetting = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateConnectorSetting>(MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateConnectorSetting.CreateFromDiscriminatorValue); } },
                {"city", (o,n) => { (o as Organization).City = n.GetStringValue(); } },
                {"country", (o,n) => { (o as Organization).Country = n.GetStringValue(); } },
                {"countryLetterCode", (o,n) => { (o as Organization).CountryLetterCode = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as Organization).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"directorySizeQuota", (o,n) => { (o as Organization).DirectorySizeQuota = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DirectorySizeQuota>(MicrosoftGraphSdk.Models.Microsoft.Graph.DirectorySizeQuota.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as Organization).DisplayName = n.GetStringValue(); } },
                {"extensions", (o,n) => { (o as Organization).Extensions = n.GetCollectionOfObjectValues<Extension>(Extension.CreateFromDiscriminatorValue).ToList(); } },
                {"isMultipleDataLocationsForServicesEnabled", (o,n) => { (o as Organization).IsMultipleDataLocationsForServicesEnabled = n.GetBoolValue(); } },
                {"marketingNotificationEmails", (o,n) => { (o as Organization).MarketingNotificationEmails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"mobileDeviceManagementAuthority", (o,n) => { (o as Organization).MobileDeviceManagementAuthority = n.GetEnumValue<MdmAuthority>(); } },
                {"onPremisesLastSyncDateTime", (o,n) => { (o as Organization).OnPremisesLastSyncDateTime = n.GetDateTimeOffsetValue(); } },
                {"onPremisesSyncEnabled", (o,n) => { (o as Organization).OnPremisesSyncEnabled = n.GetBoolValue(); } },
                {"postalCode", (o,n) => { (o as Organization).PostalCode = n.GetStringValue(); } },
                {"preferredLanguage", (o,n) => { (o as Organization).PreferredLanguage = n.GetStringValue(); } },
                {"privacyProfile", (o,n) => { (o as Organization).PrivacyProfile = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PrivacyProfile>(MicrosoftGraphSdk.Models.Microsoft.Graph.PrivacyProfile.CreateFromDiscriminatorValue); } },
                {"provisionedPlans", (o,n) => { (o as Organization).ProvisionedPlans = n.GetCollectionOfObjectValues<ProvisionedPlan>(ProvisionedPlan.CreateFromDiscriminatorValue).ToList(); } },
                {"securityComplianceNotificationMails", (o,n) => { (o as Organization).SecurityComplianceNotificationMails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"securityComplianceNotificationPhones", (o,n) => { (o as Organization).SecurityComplianceNotificationPhones = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"settings", (o,n) => { (o as Organization).Settings = n.GetObjectValue<OrganizationSettings>(OrganizationSettings.CreateFromDiscriminatorValue); } },
                {"state", (o,n) => { (o as Organization).State = n.GetStringValue(); } },
                {"street", (o,n) => { (o as Organization).Street = n.GetStringValue(); } },
                {"technicalNotificationMails", (o,n) => { (o as Organization).TechnicalNotificationMails = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"verifiedDomains", (o,n) => { (o as Organization).VerifiedDomains = n.GetCollectionOfObjectValues<VerifiedDomain>(VerifiedDomain.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AssignedPlan>("assignedPlans", AssignedPlans);
            writer.WriteObjectValue<OrganizationalBranding>("branding", Branding);
            writer.WriteCollectionOfPrimitiveValues<string>("businessPhones", BusinessPhones);
            writer.WriteCollectionOfObjectValues<MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateBasedAuthConfiguration>("certificateBasedAuthConfiguration", CertificateBasedAuthConfiguration);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.CertificateConnectorSetting>("certificateConnectorSetting", CertificateConnectorSetting);
            writer.WriteStringValue("city", City);
            writer.WriteStringValue("country", Country);
            writer.WriteStringValue("countryLetterCode", CountryLetterCode);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.DirectorySizeQuota>("directorySizeQuota", DirectorySizeQuota);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<Extension>("extensions", Extensions);
            writer.WriteBoolValue("isMultipleDataLocationsForServicesEnabled", IsMultipleDataLocationsForServicesEnabled);
            writer.WriteCollectionOfPrimitiveValues<string>("marketingNotificationEmails", MarketingNotificationEmails);
            writer.WriteEnumValue<MdmAuthority>("mobileDeviceManagementAuthority", MobileDeviceManagementAuthority);
            writer.WriteDateTimeOffsetValue("onPremisesLastSyncDateTime", OnPremisesLastSyncDateTime);
            writer.WriteBoolValue("onPremisesSyncEnabled", OnPremisesSyncEnabled);
            writer.WriteStringValue("postalCode", PostalCode);
            writer.WriteStringValue("preferredLanguage", PreferredLanguage);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.PrivacyProfile>("privacyProfile", PrivacyProfile);
            writer.WriteCollectionOfObjectValues<ProvisionedPlan>("provisionedPlans", ProvisionedPlans);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationMails", SecurityComplianceNotificationMails);
            writer.WriteCollectionOfPrimitiveValues<string>("securityComplianceNotificationPhones", SecurityComplianceNotificationPhones);
            writer.WriteObjectValue<OrganizationSettings>("settings", Settings);
            writer.WriteStringValue("state", State);
            writer.WriteStringValue("street", Street);
            writer.WriteCollectionOfPrimitiveValues<string>("technicalNotificationMails", TechnicalNotificationMails);
            writer.WriteCollectionOfObjectValues<VerifiedDomain>("verifiedDomains", VerifiedDomains);
        }
    }
}
