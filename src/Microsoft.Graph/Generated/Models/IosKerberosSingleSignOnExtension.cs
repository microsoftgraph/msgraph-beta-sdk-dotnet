using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class IosKerberosSingleSignOnExtension : IosSingleSignOnExtension, IParsable {
        /// <summary>Gets or sets the Active Directory site.</summary>
        public string ActiveDirectorySiteCode {
            get { return BackingStore?.Get<string>(nameof(ActiveDirectorySiteCode)); }
            set { BackingStore?.Set(nameof(ActiveDirectorySiteCode), value); }
        }
        /// <summary>Enables or disables whether the Kerberos extension can automatically determine its site name.</summary>
        public bool? BlockActiveDirectorySiteAutoDiscovery {
            get { return BackingStore?.Get<bool?>(nameof(BlockActiveDirectorySiteAutoDiscovery)); }
            set { BackingStore?.Set(nameof(BlockActiveDirectorySiteAutoDiscovery), value); }
        }
        /// <summary>Enables or disables Keychain usage.</summary>
        public bool? BlockAutomaticLogin {
            get { return BackingStore?.Get<bool?>(nameof(BlockAutomaticLogin)); }
            set { BackingStore?.Set(nameof(BlockAutomaticLogin), value); }
        }
        /// <summary>Gets or sets the Generic Security Services name of the Kerberos cache to use for this profile.</summary>
        public string CacheName {
            get { return BackingStore?.Get<string>(nameof(CacheName)); }
            set { BackingStore?.Set(nameof(CacheName), value); }
        }
        /// <summary>Gets or sets a list of app Bundle IDs allowed to access the Kerberos Ticket Granting Ticket.</summary>
        public List<string> CredentialBundleIdAccessControlList {
            get { return BackingStore?.Get<List<string>>(nameof(CredentialBundleIdAccessControlList)); }
            set { BackingStore?.Set(nameof(CredentialBundleIdAccessControlList), value); }
        }
        /// <summary>Gets or sets a list of realms for custom domain-realm mapping. Realms are case sensitive.</summary>
        public List<string> DomainRealms {
            get { return BackingStore?.Get<List<string>>(nameof(DomainRealms)); }
            set { BackingStore?.Set(nameof(DomainRealms), value); }
        }
        /// <summary>Gets or sets a list of hosts or domain names for which the app extension performs SSO.</summary>
        public List<string> Domains {
            get { return BackingStore?.Get<List<string>>(nameof(Domains)); }
            set { BackingStore?.Set(nameof(Domains), value); }
        }
        /// <summary>When true, this profile&apos;s realm will be selected as the default. Necessary if multiple Kerberos-type profiles are configured.</summary>
        public bool? IsDefaultRealm {
            get { return BackingStore?.Get<bool?>(nameof(IsDefaultRealm)); }
            set { BackingStore?.Set(nameof(IsDefaultRealm), value); }
        }
        /// <summary>When set to True, the Kerberos extension allows managed apps, and any apps entered with the app bundle ID to access the credential. When set to False, the Kerberos extension allows all apps to access the credential. Available for devices running iOS and iPadOS versions 14 and later.</summary>
        public bool? ManagedAppsInBundleIdACLIncluded {
            get { return BackingStore?.Get<bool?>(nameof(ManagedAppsInBundleIdACLIncluded)); }
            set { BackingStore?.Set(nameof(ManagedAppsInBundleIdACLIncluded), value); }
        }
        /// <summary>Enables or disables password changes.</summary>
        public bool? PasswordBlockModification {
            get { return BackingStore?.Get<bool?>(nameof(PasswordBlockModification)); }
            set { BackingStore?.Set(nameof(PasswordBlockModification), value); }
        }
        /// <summary>Gets or sets the URL that the user will be sent to when they initiate a password change.</summary>
        public string PasswordChangeUrl {
            get { return BackingStore?.Get<string>(nameof(PasswordChangeUrl)); }
            set { BackingStore?.Set(nameof(PasswordChangeUrl), value); }
        }
        /// <summary>Enables or disables password syncing. This won&apos;t affect users logged in with a mobile account on macOS.</summary>
        public bool? PasswordEnableLocalSync {
            get { return BackingStore?.Get<bool?>(nameof(PasswordEnableLocalSync)); }
            set { BackingStore?.Set(nameof(PasswordEnableLocalSync), value); }
        }
        /// <summary>Overrides the default password expiration in days. For most domains, this value is calculated automatically.</summary>
        public int? PasswordExpirationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationDays), value); }
        }
        /// <summary>Gets or sets the number of days until the user is notified that their password will expire (default is 15).</summary>
        public int? PasswordExpirationNotificationDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordExpirationNotificationDays)); }
            set { BackingStore?.Set(nameof(PasswordExpirationNotificationDays), value); }
        }
        /// <summary>Gets or sets the minimum number of days until a user can change their password again.</summary>
        public int? PasswordMinimumAgeDays {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumAgeDays)); }
            set { BackingStore?.Set(nameof(PasswordMinimumAgeDays), value); }
        }
        /// <summary>Gets or sets the minimum length of a password.</summary>
        public int? PasswordMinimumLength {
            get { return BackingStore?.Get<int?>(nameof(PasswordMinimumLength)); }
            set { BackingStore?.Set(nameof(PasswordMinimumLength), value); }
        }
        /// <summary>Gets or sets the number of previous passwords to block.</summary>
        public int? PasswordPreviousPasswordBlockCount {
            get { return BackingStore?.Get<int?>(nameof(PasswordPreviousPasswordBlockCount)); }
            set { BackingStore?.Set(nameof(PasswordPreviousPasswordBlockCount), value); }
        }
        /// <summary>Enables or disables whether passwords must meet Active Directory&apos;s complexity requirements.</summary>
        public bool? PasswordRequireActiveDirectoryComplexity {
            get { return BackingStore?.Get<bool?>(nameof(PasswordRequireActiveDirectoryComplexity)); }
            set { BackingStore?.Set(nameof(PasswordRequireActiveDirectoryComplexity), value); }
        }
        /// <summary>Gets or sets a description of the password complexity requirements.</summary>
        public string PasswordRequirementsDescription {
            get { return BackingStore?.Get<string>(nameof(PasswordRequirementsDescription)); }
            set { BackingStore?.Set(nameof(PasswordRequirementsDescription), value); }
        }
        /// <summary>Gets or sets the case-sensitive realm name for this profile.</summary>
        public string Realm {
            get { return BackingStore?.Get<string>(nameof(Realm)); }
            set { BackingStore?.Set(nameof(Realm), value); }
        }
        /// <summary>Gets or sets whether to require authentication via Touch ID, Face ID, or a passcode to access the keychain entry.</summary>
        public bool? RequireUserPresence {
            get { return BackingStore?.Get<bool?>(nameof(RequireUserPresence)); }
            set { BackingStore?.Set(nameof(RequireUserPresence), value); }
        }
        /// <summary>Text displayed to the user at the Kerberos sign in window. Available for devices running iOS and iPadOS versions 14 and later.</summary>
        public string SignInHelpText {
            get { return BackingStore?.Get<string>(nameof(SignInHelpText)); }
            set { BackingStore?.Set(nameof(SignInHelpText), value); }
        }
        /// <summary>Gets or sets the principle user name to use for this profile. The realm name does not need to be included.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new IosKerberosSingleSignOnExtension CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new IosKerberosSingleSignOnExtension();
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
                {"domainRealms", n => { DomainRealms = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"domains", n => { Domains = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"isDefaultRealm", n => { IsDefaultRealm = n.GetBoolValue(); } },
                {"managedAppsInBundleIdACLIncluded", n => { ManagedAppsInBundleIdACLIncluded = n.GetBoolValue(); } },
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
                {"realm", n => { Realm = n.GetStringValue(); } },
                {"requireUserPresence", n => { RequireUserPresence = n.GetBoolValue(); } },
                {"signInHelpText", n => { SignInHelpText = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
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
            writer.WriteCollectionOfPrimitiveValues<string>("domainRealms", DomainRealms);
            writer.WriteCollectionOfPrimitiveValues<string>("domains", Domains);
            writer.WriteBoolValue("isDefaultRealm", IsDefaultRealm);
            writer.WriteBoolValue("managedAppsInBundleIdACLIncluded", ManagedAppsInBundleIdACLIncluded);
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
            writer.WriteStringValue("realm", Realm);
            writer.WriteBoolValue("requireUserPresence", RequireUserPresence);
            writer.WriteStringValue("signInHelpText", SignInHelpText);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
