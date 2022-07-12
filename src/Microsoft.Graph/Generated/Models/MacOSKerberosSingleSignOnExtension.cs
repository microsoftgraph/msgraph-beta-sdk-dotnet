using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class MacOSKerberosSingleSignOnExtension : MacOSSingleSignOnExtension, IParsable {
        /// <summary>Gets or sets the Active Directory site.</summary>
        public string ActiveDirectorySiteCode {
            get { return BackingStore?.Get<string>("activeDirectorySiteCode"); }
            set { BackingStore?.Set("activeDirectorySiteCode", value); }
        }
        /// <summary>Enables or disables whether the Kerberos extension can automatically determine its site name.</summary>
        public bool? BlockActiveDirectorySiteAutoDiscovery {
            get { return BackingStore?.Get<bool?>("blockActiveDirectorySiteAutoDiscovery"); }
            set { BackingStore?.Set("blockActiveDirectorySiteAutoDiscovery", value); }
        }
        /// <summary>Enables or disables Keychain usage.</summary>
        public bool? BlockAutomaticLogin {
            get { return BackingStore?.Get<bool?>("blockAutomaticLogin"); }
            set { BackingStore?.Set("blockAutomaticLogin", value); }
        }
        /// <summary>Gets or sets the Generic Security Services name of the Kerberos cache to use for this profile.</summary>
        public string CacheName {
            get { return BackingStore?.Get<string>("cacheName"); }
            set { BackingStore?.Set("cacheName", value); }
        }
        /// <summary>Gets or sets a list of app Bundle IDs allowed to access the Kerberos Ticket Granting Ticket.</summary>
        public List<string> CredentialBundleIdAccessControlList {
            get { return BackingStore?.Get<List<string>>("credentialBundleIdAccessControlList"); }
            set { BackingStore?.Set("credentialBundleIdAccessControlList", value); }
        }
        /// <summary>When set to True, the credential is requested on the next matching Kerberos challenge or network state change. When the credential is expired or missing, a new credential is created. Available for devices running macOS versions 12 and later.</summary>
        public bool? CredentialsCacheMonitored {
            get { return BackingStore?.Get<bool?>("credentialsCacheMonitored"); }
            set { BackingStore?.Set("credentialsCacheMonitored", value); }
        }
        /// <summary>Gets or sets a list of realms for custom domain-realm mapping. Realms are case sensitive.</summary>
        public List<string> DomainRealms {
            get { return BackingStore?.Get<List<string>>("domainRealms"); }
            set { BackingStore?.Set("domainRealms", value); }
        }
        /// <summary>Gets or sets a list of hosts or domain names for which the app extension performs SSO.</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>("domains"); }
            set { BackingStore?.Set("domains", value); }
        }
        /// <summary>When true, this profile&apos;s realm will be selected as the default. Necessary if multiple Kerberos-type profiles are configured.</summary>
        public bool? IsDefaultRealm {
            get { return BackingStore?.Get<bool?>("isDefaultRealm"); }
            set { BackingStore?.Set("isDefaultRealm", value); }
        }
        /// <summary>When set to True, the Kerberos extension allows any apps entered with the app bundle ID, managed apps, and standard Kerberos utilities, such as TicketViewer and klist, to access and use the credential. Available for devices running macOS versions 12 and later.</summary>
        public bool? KerberosAppsInBundleIdACLIncluded {
            get { return BackingStore?.Get<bool?>("kerberosAppsInBundleIdACLIncluded"); }
            set { BackingStore?.Set("kerberosAppsInBundleIdACLIncluded", value); }
        }
        /// <summary>When set to True, the Kerberos extension allows managed apps, and any apps entered with the app bundle ID to access the credential. When set to False, the Kerberos extension allows all apps to access the credential. Available for devices running iOS and iPadOS versions 14 and later.</summary>
        public bool? ManagedAppsInBundleIdACLIncluded {
            get { return BackingStore?.Get<bool?>("managedAppsInBundleIdACLIncluded"); }
            set { BackingStore?.Set("managedAppsInBundleIdACLIncluded", value); }
        }
        /// <summary>Select how other processes use the Kerberos Extension credential.</summary>
        public string ModeCredentialUsed {
            get { return BackingStore?.Get<string>("modeCredentialUsed"); }
            set { BackingStore?.Set("modeCredentialUsed", value); }
        }
        /// <summary>Enables or disables password changes.</summary>
        public bool? PasswordBlockModification {
            get { return BackingStore?.Get<bool?>("passwordBlockModification"); }
            set { BackingStore?.Set("passwordBlockModification", value); }
        }
        /// <summary>Gets or sets the URL that the user will be sent to when they initiate a password change.</summary>
        public string PasswordChangeUrl {
            get { return BackingStore?.Get<string>("passwordChangeUrl"); }
            set { BackingStore?.Set("passwordChangeUrl", value); }
        }
        /// <summary>Enables or disables password syncing. This won&apos;t affect users logged in with a mobile account on macOS.</summary>
        public bool? PasswordEnableLocalSync {
            get { return BackingStore?.Get<bool?>("passwordEnableLocalSync"); }
            set { BackingStore?.Set("passwordEnableLocalSync", value); }
        }
        /// <summary>Overrides the default password expiration in days. For most domains, this value is calculated automatically.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationDays"); }
            set { BackingStore?.Set("passwordExpirationDays", value); }
        }
        /// <summary>Gets or sets the number of days until the user is notified that their password will expire (default is 15).</summary>
        public int? PasswordExpirationNotificationDays {
            get { return BackingStore?.Get<int?>("passwordExpirationNotificationDays"); }
            set { BackingStore?.Set("passwordExpirationNotificationDays", value); }
        }
        /// <summary>Gets or sets the minimum number of days until a user can change their password again.</summary>
        public int? PasswordMinimumAgeDays {
            get { return BackingStore?.Get<int?>("passwordMinimumAgeDays"); }
            set { BackingStore?.Set("passwordMinimumAgeDays", value); }
        }
        /// <summary>Gets or sets the minimum length of a password.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>("passwordMinimumLength"); }
            set { BackingStore?.Set("passwordMinimumLength", value); }
        }
        /// <summary>Gets or sets the number of previous passwords to block.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>("passwordPreviousPasswordBlockCount"); }
            set { BackingStore?.Set("passwordPreviousPasswordBlockCount", value); }
        }
        /// <summary>Enables or disables whether passwords must meet Active Directory&apos;s complexity requirements.</summary>
        public bool? PasswordRequireActiveDirectoryComplexity {
            get { return BackingStore?.Get<bool?>("passwordRequireActiveDirectoryComplexity"); }
            set { BackingStore?.Set("passwordRequireActiveDirectoryComplexity", value); }
        }
        /// <summary>Gets or sets a description of the password complexity requirements.</summary>
        public string PasswordRequirementsDescription {
            get { return BackingStore?.Get<string>("passwordRequirementsDescription"); }
            set { BackingStore?.Set("passwordRequirementsDescription", value); }
        }
        /// <summary>Add creates an ordered list of preferred Key Distribution Centers (KDCs) to use for Kerberos traffic. This list is used when the servers are not discoverable using DNS. When the servers are discoverable, the list is used for both connectivity checks, and used first for Kerberos traffic. If the servers don’t respond, then the device uses DNS discovery. Delete removes an existing list, and devices use DNS discovery. Available for devices running macOS versions 12 and later.</summary>
        public List<string> PreferredKDCs {
            get { return BackingStore?.Get<List<string>>("preferredKDCs"); }
            set { BackingStore?.Set("preferredKDCs", value); }
        }
        /// <summary>Gets or sets the case-sensitive realm name for this profile.</summary>
        public string Realm {
            get { return BackingStore?.Get<string>("realm"); }
            set { BackingStore?.Set("realm", value); }
        }
        /// <summary>Gets or sets whether to require authentication via Touch ID, Face ID, or a passcode to access the keychain entry.</summary>
        public bool? RequireUserPresence {
            get { return BackingStore?.Get<bool?>("requireUserPresence"); }
            set { BackingStore?.Set("requireUserPresence", value); }
        }
        /// <summary>Text displayed to the user at the Kerberos sign in window. Available for devices running iOS and iPadOS versions 14 and later.</summary>
        public string SignInHelpText {
            get { return BackingStore?.Get<string>("signInHelpText"); }
            set { BackingStore?.Set("signInHelpText", value); }
        }
        /// <summary>When set to True, LDAP connections are required to use Transport Layer Security (TLS). Available for devices running macOS versions 11 and later.</summary>
        public bool? TlsForLDAPRequired {
            get { return BackingStore?.Get<bool?>("tlsForLDAPRequired"); }
            set { BackingStore?.Set("tlsForLDAPRequired", value); }
        }
        /// <summary>This label replaces the user name shown in the Kerberos extension. You can enter a name to match the name of your company or organization. Available for devices running macOS versions 11 and later.</summary>
        public string UsernameLabelCustom {
            get { return BackingStore?.Get<string>("usernameLabelCustom"); }
            set { BackingStore?.Set("usernameLabelCustom", value); }
        }
        /// <summary>Gets or sets the principle user name to use for this profile. The realm name does not need to be included.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>("userPrincipalName"); }
            set { BackingStore?.Set("userPrincipalName", value); }
        }
        /// <summary>When set to True, the user isn’t prompted to set up the Kerberos extension until the extension is enabled by the admin, or a Kerberos challenge is received. Available for devices running macOS versions 11 and later.</summary>
        public bool? UserSetupDelayed {
            get { return BackingStore?.Get<bool?>("userSetupDelayed"); }
            set { BackingStore?.Set("userSetupDelayed", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new MacOSKerberosSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MacOSKerberosSingleSignOnExtension();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activeDirectorySiteCode", n => { ActiveDirectorySiteCode = n.GetStringValue(); } },
                {"blockActiveDirectorySiteAutoDiscovery", n => { BlockActiveDirectorySiteAutoDiscovery = n.GetBoolValue(); } },
                {"blockAutomaticLogin", n => { BlockAutomaticLogin = n.GetBoolValue(); } },
                {"cacheName", n => { CacheName = n.GetStringValue(); } },
                {"credentialBundleIdAccessControlList", n => { CredentialBundleIdAccessControlList = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"credentialsCacheMonitored", n => { CredentialsCacheMonitored = n.GetBoolValue(); } },
                {"domainRealms", n => { DomainRealms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isDefaultRealm", n => { IsDefaultRealm = n.GetBoolValue(); } },
                {"kerberosAppsInBundleIdACLIncluded", n => { KerberosAppsInBundleIdACLIncluded = n.GetBoolValue(); } },
                {"managedAppsInBundleIdACLIncluded", n => { ManagedAppsInBundleIdACLIncluded = n.GetBoolValue(); } },
                {"modeCredentialUsed", n => { ModeCredentialUsed = n.GetStringValue(); } },
                {"passwordBlockModification", n => { PasswordBlockModification = n.GetBoolValue(); } },
                {"passwordChangeUrl", n => { PasswordChangeUrl = n.GetStringValue(); } },
                {"passwordEnableLocalSync", n => { PasswordEnableLocalSync = n.GetBoolValue(); } },
                {"passwordExpirationDays", n => { PasswordExpirationDays = n.GetIntValue(); } },
                {"passwordExpirationNotificationDays", n => { PasswordExpirationNotificationDays = n.GetIntValue(); } },
                {"passwordMinimumAgeDays", n => { PasswordMinimumAgeDays = n.GetIntValue(); } },
                {"passwordMinimumLength", n => { PasswordMinimumLength = n.GetIntValue(); } },
                {"passwordPreviousPasswordBlockCount", n => { PasswordPreviousPasswordBlockCount = n.GetIntValue(); } },
                {"passwordRequireActiveDirectoryComplexity", n => { PasswordRequireActiveDirectoryComplexity = n.GetBoolValue(); } },
                {"passwordRequirementsDescription", n => { PasswordRequirementsDescription = n.GetStringValue(); } },
                {"preferredKDCs", n => { PreferredKDCs = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"requireUserPresence", n => { RequireUserPresence = n.GetBoolValue(); } },
                {"signInHelpText", n => { SignInHelpText = n.GetStringValue(); } },
                {"tlsForLDAPRequired", n => { TlsForLDAPRequired = n.GetBoolValue(); } },
                {"usernameLabelCustom", n => { UsernameLabelCustom = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userSetupDelayed", n => { UserSetupDelayed = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("activeDirectorySiteCode", ActiveDirectorySiteCode);
            writer.WriteBoolValue("blockActiveDirectorySiteAutoDiscovery", BlockActiveDirectorySiteAutoDiscovery);
            writer.WriteBoolValue("blockAutomaticLogin", BlockAutomaticLogin);
            writer.WriteStringValue("cacheName", CacheName);
            writer.WriteCollectionOfPrimitiveValues<string>("credentialBundleIdAccessControlList", CredentialBundleIdAccessControlList);
            writer.WriteBoolValue("credentialsCacheMonitored", CredentialsCacheMonitored);
            writer.WriteCollectionOfPrimitiveValues<string>("domainRealms", DomainRealms);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteBoolValue("isDefaultRealm", IsDefaultRealm);
            writer.WriteBoolValue("kerberosAppsInBundleIdACLIncluded", KerberosAppsInBundleIdACLIncluded);
            writer.WriteBoolValue("managedAppsInBundleIdACLIncluded", ManagedAppsInBundleIdACLIncluded);
            writer.WriteStringValue("modeCredentialUsed", ModeCredentialUsed);
            writer.WriteBoolValue("passwordBlockModification", PasswordBlockModification);
            writer.WriteStringValue("passwordChangeUrl", PasswordChangeUrl);
            writer.WriteBoolValue("passwordEnableLocalSync", PasswordEnableLocalSync);
            writer.WriteIntValue("passwordExpirationDays", PasswordExpirationDays);
            writer.WriteIntValue("passwordExpirationNotificationDays", PasswordExpirationNotificationDays);
            writer.WriteIntValue("passwordMinimumAgeDays", PasswordMinimumAgeDays);
            writer.WriteIntValue("passwordMinimumLength", PasswordMinimumLength);
            writer.WriteIntValue("passwordPreviousPasswordBlockCount", PasswordPreviousPasswordBlockCount);
            writer.WriteBoolValue("passwordRequireActiveDirectoryComplexity", PasswordRequireActiveDirectoryComplexity);
            writer.WriteStringValue("passwordRequirementsDescription", PasswordRequirementsDescription);
            writer.WriteCollectionOfPrimitiveValues<string>("preferredKDCs", PreferredKDCs);
            writer.WriteStringValue("realm", Realm);
            writer.WriteBoolValue("requireUserPresence", RequireUserPresence);
            writer.WriteStringValue("signInHelpText", SignInHelpText);
            writer.WriteBoolValue("tlsForLDAPRequired", TlsForLDAPRequired);
            writer.WriteStringValue("usernameLabelCustom", UsernameLabelCustom);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteBoolValue("userSetupDelayed", UserSetupDelayed);
        }
    }
}
