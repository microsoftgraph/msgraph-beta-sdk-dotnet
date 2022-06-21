using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class Application : DirectoryObject, IParsable {
        /// <summary>Specifies settings for an application that implements a web API.</summary>
        public ApiApplication Api {
            get { return BackingStore?.Get<ApiApplication>(nameof(Api)); }
            set { BackingStore?.Set(nameof(Api), value); }
        }
        /// <summary>The unique identifier for the application that is assigned by Azure AD. Not nullable. Read-only.</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>The appManagementPolicy applied to this application.</summary>
        public List<AppManagementPolicy> AppManagementPolicies {
            get { return BackingStore?.Get<List<AppManagementPolicy>>(nameof(AppManagementPolicies)); }
            set { BackingStore?.Set(nameof(AppManagementPolicies), value); }
        }
        /// <summary>The collection of roles assigned to the application. With app role assignments, these roles can be assigned to users, groups, or service principals associated with other applications. Not nullable.</summary>
        public List<AppRole> AppRoles {
            get { return BackingStore?.Get<List<AppRole>>(nameof(AppRoles)); }
            set { BackingStore?.Set(nameof(AppRoles), value); }
        }
        /// <summary>Specifies the certification status of the application.</summary>
        public Microsoft.Graph.Beta.Models.Certification Certification {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Certification>(nameof(Certification)); }
            set { BackingStore?.Set(nameof(Certification), value); }
        }
        /// <summary>The connectorGroup the application is using with Azure AD Application Proxy. Nullable.</summary>
        public Microsoft.Graph.Beta.Models.ConnectorGroup ConnectorGroup {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConnectorGroup>(nameof(ConnectorGroup)); }
            set { BackingStore?.Set(nameof(ConnectorGroup), value); }
        }
        /// <summary>The date and time the application was registered. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Read-only.  Supports $filter (eq, ne, not, ge, le, in, and eq on null values) and $orderBy.</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>The createdOnBehalfOf property</summary>
        public DirectoryObject CreatedOnBehalfOf {
            get { return BackingStore?.Get<DirectoryObject>(nameof(CreatedOnBehalfOf)); }
            set { BackingStore?.Set(nameof(CreatedOnBehalfOf), value); }
        }
        /// <summary>The default redirect URI. If specified and there is no explicit redirect URI in the sign-in request for SAML and OIDC flows, Azure AD sends the token to this redirect URI. Azure AD also sends the token to this default URI in SAML IdP-initiated single sign-on. The value must match one of the configured redirect URIs for the application.</summary>
        public string DefaultRedirectUri {
            get { return BackingStore?.Get<string>(nameof(DefaultRedirectUri)); }
            set { BackingStore?.Set(nameof(DefaultRedirectUri), value); }
        }
        /// <summary>Free text field to provide a description of the application object to end users. The maximum allowed size is 1024 characters. Returned by default. Supports $filter (eq, ne, not, ge, le, startsWith) and $search.</summary>
        public string Description {
            get { return BackingStore?.Get<string>(nameof(Description)); }
            set { BackingStore?.Set(nameof(Description), value); }
        }
        /// <summary>Specifies whether Microsoft has disabled the registered application. Possible values are: null (default value), NotDisabled, and DisabledDueToViolationOfServicesAgreement (reasons may include suspicious, abusive, or malicious activity, or a violation of the Microsoft Services Agreement).  Supports $filter (eq, ne, not).</summary>
        public string DisabledByMicrosoftStatus {
            get { return BackingStore?.Get<string>(nameof(DisabledByMicrosoftStatus)); }
            set { BackingStore?.Set(nameof(DisabledByMicrosoftStatus), value); }
        }
        /// <summary>The display name for the application. Supports $filter (eq, ne, not, ge, le, in, startsWith, and eq on null values), $search, and $orderBy.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>(nameof(DisplayName)); }
            set { BackingStore?.Set(nameof(DisplayName), value); }
        }
        /// <summary>Read-only. Nullable. Supports $expand and $filter (eq when counting empty collections).</summary>
        public List<ExtensionProperty> ExtensionProperties {
            get { return BackingStore?.Get<List<ExtensionProperty>>(nameof(ExtensionProperties)); }
            set { BackingStore?.Set(nameof(ExtensionProperties), value); }
        }
        /// <summary>Federated identities for applications. Supports $expand and $filter (eq when counting empty collections).</summary>
        public List<FederatedIdentityCredential> FederatedIdentityCredentials {
            get { return BackingStore?.Get<List<FederatedIdentityCredential>>(nameof(FederatedIdentityCredentials)); }
            set { BackingStore?.Set(nameof(FederatedIdentityCredentials), value); }
        }
        /// <summary>Configures the groups claim issued in a user or OAuth 2.0 access token that the application expects. To set this attribute, use one of the following string values: None, SecurityGroup (for security groups and Azure AD roles), All (this gets all security groups, distribution groups, and Azure AD directory roles that the signed-in user is a member of).</summary>
        public string GroupMembershipClaims {
            get { return BackingStore?.Get<string>(nameof(GroupMembershipClaims)); }
            set { BackingStore?.Set(nameof(GroupMembershipClaims), value); }
        }
        /// <summary>The homeRealmDiscoveryPolicies property</summary>
        public List<HomeRealmDiscoveryPolicy> HomeRealmDiscoveryPolicies {
            get { return BackingStore?.Get<List<HomeRealmDiscoveryPolicy>>(nameof(HomeRealmDiscoveryPolicies)); }
            set { BackingStore?.Set(nameof(HomeRealmDiscoveryPolicies), value); }
        }
        /// <summary>Also known as App ID URI, this value is set when an application is used as a resource app. The identifierUris acts as the prefix for the scopes you&apos;ll reference in your API&apos;s code, and it must be globally unique. You can use the default value provided, which is in the form api://&lt;application-client-id&gt;, or specify a more readable URI like https://contoso.com/api. For more information on valid identifierUris patterns and best practices, see Azure AD application registration security best practices. Not nullable. Supports $filter (eq, ne, ge, le, startsWith).</summary>
        public List<string> IdentifierUris {
            get { return BackingStore?.Get<List<string>>(nameof(IdentifierUris)); }
            set { BackingStore?.Set(nameof(IdentifierUris), value); }
        }
        /// <summary>Basic profile information of the application, such as it&apos;s marketing, support, terms of service, and privacy statement URLs. The terms of service and privacy statement are surfaced to users through the user consent experience. For more information, see How to: Add Terms of service and privacy statement for registered Azure AD apps. Supports $filter (eq, ne, not, ge, le, and eq on null values).</summary>
        public InformationalUrl Info {
            get { return BackingStore?.Get<InformationalUrl>(nameof(Info)); }
            set { BackingStore?.Set(nameof(Info), value); }
        }
        /// <summary>Specifies whether this application supports device authentication without a user. The default is false.</summary>
        public bool? IsDeviceOnlyAuthSupported {
            get { return BackingStore?.Get<bool?>(nameof(IsDeviceOnlyAuthSupported)); }
            set { BackingStore?.Set(nameof(IsDeviceOnlyAuthSupported), value); }
        }
        /// <summary>Specifies the fallback application type as public client, such as an installed application running on a mobile device. The default value is false which means the fallback application type is confidential client such as a web app. There are certain scenarios where Azure AD cannot determine the client application type. For example, the ROPC flow where the application is configured without specifying a redirect URI. In those cases Azure AD interprets the application type based on the value of this property.</summary>
        public bool? IsFallbackPublicClient {
            get { return BackingStore?.Get<bool?>(nameof(IsFallbackPublicClient)); }
            set { BackingStore?.Set(nameof(IsFallbackPublicClient), value); }
        }
        /// <summary>The collection of key credentials associated with the application. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<KeyCredential> KeyCredentials {
            get { return BackingStore?.Get<List<KeyCredential>>(nameof(KeyCredentials)); }
            set { BackingStore?.Set(nameof(KeyCredentials), value); }
        }
        /// <summary>The main logo for the application. Not nullable.</summary>
        public byte[] Logo {
            get { return BackingStore?.Get<byte[]>(nameof(Logo)); }
            set { BackingStore?.Set(nameof(Logo), value); }
        }
        /// <summary>Notes relevant for the management of the application.</summary>
        public string Notes {
            get { return BackingStore?.Get<string>(nameof(Notes)); }
            set { BackingStore?.Set(nameof(Notes), value); }
        }
        /// <summary>Represents the set of properties required for configuring Application Proxy for this application. Configuring these properties allows you to publish your on-premises application for secure remote access.</summary>
        public Microsoft.Graph.Beta.Models.OnPremisesPublishing OnPremisesPublishing {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OnPremisesPublishing>(nameof(OnPremisesPublishing)); }
            set { BackingStore?.Set(nameof(OnPremisesPublishing), value); }
        }
        /// <summary>Application developers can configure optional claims in their Azure AD applications to specify the claims that are sent to their application by the Microsoft security token service. For more information, see How to: Provide optional claims to your app.</summary>
        public Microsoft.Graph.Beta.Models.OptionalClaims OptionalClaims {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.OptionalClaims>(nameof(OptionalClaims)); }
            set { BackingStore?.Set(nameof(OptionalClaims), value); }
        }
        /// <summary>Directory objects that are owners of the application. Read-only. Nullable. Supports $expand.</summary>
        public List<DirectoryObject> Owners {
            get { return BackingStore?.Get<List<DirectoryObject>>(nameof(Owners)); }
            set { BackingStore?.Set(nameof(Owners), value); }
        }
        /// <summary>Specifies parental control settings for an application.</summary>
        public Microsoft.Graph.Beta.Models.ParentalControlSettings ParentalControlSettings {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ParentalControlSettings>(nameof(ParentalControlSettings)); }
            set { BackingStore?.Set(nameof(ParentalControlSettings), value); }
        }
        /// <summary>The collection of password credentials associated with the application. Not nullable.</summary>
        public List<PasswordCredential> PasswordCredentials {
            get { return BackingStore?.Get<List<PasswordCredential>>(nameof(PasswordCredentials)); }
            set { BackingStore?.Set(nameof(PasswordCredentials), value); }
        }
        /// <summary>Specifies settings for installed clients such as desktop or mobile devices.</summary>
        public PublicClientApplication PublicClient {
            get { return BackingStore?.Get<PublicClientApplication>(nameof(PublicClient)); }
            set { BackingStore?.Set(nameof(PublicClient), value); }
        }
        /// <summary>The verified publisher domain for the application. Read-only. Supports $filter (eq, ne, ge, le, startsWith).</summary>
        public string PublisherDomain {
            get { return BackingStore?.Get<string>(nameof(PublisherDomain)); }
            set { BackingStore?.Set(nameof(PublisherDomain), value); }
        }
        /// <summary>Specifies the resources that the application needs to access. This property also specifies the set of delegated permissions and application roles that it needs for each of those resources. This configuration of access to the required resources drives the consent experience. No more than 50 resource services (APIs) can be configured. Beginning mid-October 2021, the total number of required permissions must not exceed 400. Not nullable. Supports $filter (eq, not, ge, le).</summary>
        public List<Microsoft.Graph.Beta.Models.RequiredResourceAccess> RequiredResourceAccess {
            get { return BackingStore?.Get<List<Microsoft.Graph.Beta.Models.RequiredResourceAccess>>(nameof(RequiredResourceAccess)); }
            set { BackingStore?.Set(nameof(RequiredResourceAccess), value); }
        }
        /// <summary>The URL where the service exposes SAML metadata for federation. This property is valid only for single-tenant applications. Nullable.</summary>
        public string SamlMetadataUrl {
            get { return BackingStore?.Get<string>(nameof(SamlMetadataUrl)); }
            set { BackingStore?.Set(nameof(SamlMetadataUrl), value); }
        }
        /// <summary>References application or service contact information from a Service or Asset Management database. Nullable.</summary>
        public string ServiceManagementReference {
            get { return BackingStore?.Get<string>(nameof(ServiceManagementReference)); }
            set { BackingStore?.Set(nameof(ServiceManagementReference), value); }
        }
        /// <summary>Specifies the Microsoft accounts that are supported for the current application. The possible values are: AzureADMyOrg, AzureADMultipleOrgs, AzureADandPersonalMicrosoftAccount (default), and PersonalMicrosoftAccount. See more in the table below. Supports $filter (eq, ne, not).</summary>
        public string SignInAudience {
            get { return BackingStore?.Get<string>(nameof(SignInAudience)); }
            set { BackingStore?.Set(nameof(SignInAudience), value); }
        }
        /// <summary>Specifies settings for a single-page application, including sign out URLs and redirect URIs for authorization codes and access tokens.</summary>
        public SpaApplication Spa {
            get { return BackingStore?.Get<SpaApplication>(nameof(Spa)); }
            set { BackingStore?.Set(nameof(Spa), value); }
        }
        /// <summary>The synchronization property</summary>
        public Microsoft.Graph.Beta.Models.Synchronization Synchronization {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Synchronization>(nameof(Synchronization)); }
            set { BackingStore?.Set(nameof(Synchronization), value); }
        }
        /// <summary>Custom strings that can be used to categorize and identify the application. Not nullable.Supports $filter (eq, not, ge, le, startsWith).</summary>
        public List<string> Tags {
            get { return BackingStore?.Get<List<string>>(nameof(Tags)); }
            set { BackingStore?.Set(nameof(Tags), value); }
        }
        /// <summary>Specifies the keyId of a public key from the keyCredentials collection. When configured, Azure AD encrypts all the tokens it emits by using the key this property points to. The application code that receives the encrypted token must use the matching private key to decrypt the token before it can be used for the signed-in user.</summary>
        public string TokenEncryptionKeyId {
            get { return BackingStore?.Get<string>(nameof(TokenEncryptionKeyId)); }
            set { BackingStore?.Set(nameof(TokenEncryptionKeyId), value); }
        }
        /// <summary>The tokenIssuancePolicies property</summary>
        public List<TokenIssuancePolicy> TokenIssuancePolicies {
            get { return BackingStore?.Get<List<TokenIssuancePolicy>>(nameof(TokenIssuancePolicies)); }
            set { BackingStore?.Set(nameof(TokenIssuancePolicies), value); }
        }
        /// <summary>The tokenLifetimePolicies assigned to this application. Supports $expand.</summary>
        public List<TokenLifetimePolicy> TokenLifetimePolicies {
            get { return BackingStore?.Get<List<TokenLifetimePolicy>>(nameof(TokenLifetimePolicies)); }
            set { BackingStore?.Set(nameof(TokenLifetimePolicies), value); }
        }
        /// <summary>The unique identifier that can be assigned to an application as an alternative identifier. Immutable. Read-only.</summary>
        public string UniqueName {
            get { return BackingStore?.Get<string>(nameof(UniqueName)); }
            set { BackingStore?.Set(nameof(UniqueName), value); }
        }
        /// <summary>Specifies the verified publisher of the application. For more information about how publisher verification helps support application security, trustworthiness, and compliance, see Publisher verification.</summary>
        public Microsoft.Graph.Beta.Models.VerifiedPublisher VerifiedPublisher {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.VerifiedPublisher>(nameof(VerifiedPublisher)); }
            set { BackingStore?.Set(nameof(VerifiedPublisher), value); }
        }
        /// <summary>Specifies settings for a web application.</summary>
        public WebApplication Web {
            get { return BackingStore?.Get<WebApplication>(nameof(Web)); }
            set { BackingStore?.Set(nameof(Web), value); }
        }
        /// <summary>Specifies settings for apps running Microsoft Windows and published in the Microsoft Store or Xbox games store.</summary>
        public WindowsApplication Windows {
            get { return BackingStore?.Get<WindowsApplication>(nameof(Windows)); }
            set { BackingStore?.Set(nameof(Windows), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new Application CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Application();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"api", n => { Api = n.GetObjectValue<ApiApplication>(ApiApplication.CreateFromDiscriminatorValue); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appManagementPolicies", n => { AppManagementPolicies = n.GetCollectionOfObjectValues<AppManagementPolicy>(AppManagementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"appRoles", n => { AppRoles = n.GetCollectionOfObjectValues<AppRole>(AppRole.CreateFromDiscriminatorValue).ToList(); } },
                {"certification", n => { Certification = n.GetObjectValue<Microsoft.Graph.Beta.Models.Certification>(Microsoft.Graph.Beta.Models.Certification.CreateFromDiscriminatorValue); } },
                {"connectorGroup", n => { ConnectorGroup = n.GetObjectValue<Microsoft.Graph.Beta.Models.ConnectorGroup>(Microsoft.Graph.Beta.Models.ConnectorGroup.CreateFromDiscriminatorValue); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"createdOnBehalfOf", n => { CreatedOnBehalfOf = n.GetObjectValue<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue); } },
                {"defaultRedirectUri", n => { DefaultRedirectUri = n.GetStringValue(); } },
                {"description", n => { Description = n.GetStringValue(); } },
                {"disabledByMicrosoftStatus", n => { DisabledByMicrosoftStatus = n.GetStringValue(); } },
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"extensionProperties", n => { ExtensionProperties = n.GetCollectionOfObjectValues<ExtensionProperty>(ExtensionProperty.CreateFromDiscriminatorValue).ToList(); } },
                {"federatedIdentityCredentials", n => { FederatedIdentityCredentials = n.GetCollectionOfObjectValues<FederatedIdentityCredential>(FederatedIdentityCredential.CreateFromDiscriminatorValue).ToList(); } },
                {"groupMembershipClaims", n => { GroupMembershipClaims = n.GetStringValue(); } },
                {"homeRealmDiscoveryPolicies", n => { HomeRealmDiscoveryPolicies = n.GetCollectionOfObjectValues<HomeRealmDiscoveryPolicy>(HomeRealmDiscoveryPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"identifierUris", n => { IdentifierUris = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"info", n => { Info = n.GetObjectValue<InformationalUrl>(InformationalUrl.CreateFromDiscriminatorValue); } },
                {"isDeviceOnlyAuthSupported", n => { IsDeviceOnlyAuthSupported = n.GetBoolValue(); } },
                {"isFallbackPublicClient", n => { IsFallbackPublicClient = n.GetBoolValue(); } },
                {"keyCredentials", n => { KeyCredentials = n.GetCollectionOfObjectValues<KeyCredential>(KeyCredential.CreateFromDiscriminatorValue).ToList(); } },
                {"logo", n => { Logo = n.GetByteArrayValue(); } },
                {"notes", n => { Notes = n.GetStringValue(); } },
                {"onPremisesPublishing", n => { OnPremisesPublishing = n.GetObjectValue<Microsoft.Graph.Beta.Models.OnPremisesPublishing>(Microsoft.Graph.Beta.Models.OnPremisesPublishing.CreateFromDiscriminatorValue); } },
                {"optionalClaims", n => { OptionalClaims = n.GetObjectValue<Microsoft.Graph.Beta.Models.OptionalClaims>(Microsoft.Graph.Beta.Models.OptionalClaims.CreateFromDiscriminatorValue); } },
                {"owners", n => { Owners = n.GetCollectionOfObjectValues<DirectoryObject>(DirectoryObject.CreateFromDiscriminatorValue).ToList(); } },
                {"parentalControlSettings", n => { ParentalControlSettings = n.GetObjectValue<Microsoft.Graph.Beta.Models.ParentalControlSettings>(Microsoft.Graph.Beta.Models.ParentalControlSettings.CreateFromDiscriminatorValue); } },
                {"passwordCredentials", n => { PasswordCredentials = n.GetCollectionOfObjectValues<PasswordCredential>(PasswordCredential.CreateFromDiscriminatorValue).ToList(); } },
                {"publicClient", n => { PublicClient = n.GetObjectValue<PublicClientApplication>(PublicClientApplication.CreateFromDiscriminatorValue); } },
                {"publisherDomain", n => { PublisherDomain = n.GetStringValue(); } },
                {"requiredResourceAccess", n => { RequiredResourceAccess = n.GetCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RequiredResourceAccess>(Microsoft.Graph.Beta.Models.RequiredResourceAccess.CreateFromDiscriminatorValue).ToList(); } },
                {"samlMetadataUrl", n => { SamlMetadataUrl = n.GetStringValue(); } },
                {"serviceManagementReference", n => { ServiceManagementReference = n.GetStringValue(); } },
                {"signInAudience", n => { SignInAudience = n.GetStringValue(); } },
                {"spa", n => { Spa = n.GetObjectValue<SpaApplication>(SpaApplication.CreateFromDiscriminatorValue); } },
                {"synchronization", n => { Synchronization = n.GetObjectValue<Microsoft.Graph.Beta.Models.Synchronization>(Microsoft.Graph.Beta.Models.Synchronization.CreateFromDiscriminatorValue); } },
                {"tags", n => { Tags = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"tokenEncryptionKeyId", n => { TokenEncryptionKeyId = n.GetStringValue(); } },
                {"tokenIssuancePolicies", n => { TokenIssuancePolicies = n.GetCollectionOfObjectValues<TokenIssuancePolicy>(TokenIssuancePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"tokenLifetimePolicies", n => { TokenLifetimePolicies = n.GetCollectionOfObjectValues<TokenLifetimePolicy>(TokenLifetimePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"uniqueName", n => { UniqueName = n.GetStringValue(); } },
                {"verifiedPublisher", n => { VerifiedPublisher = n.GetObjectValue<Microsoft.Graph.Beta.Models.VerifiedPublisher>(Microsoft.Graph.Beta.Models.VerifiedPublisher.CreateFromDiscriminatorValue); } },
                {"web", n => { Web = n.GetObjectValue<WebApplication>(WebApplication.CreateFromDiscriminatorValue); } },
                {"windows", n => { Windows = n.GetObjectValue<WindowsApplication>(WindowsApplication.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<ApiApplication>("api", Api);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<AppManagementPolicy>("appManagementPolicies", AppManagementPolicies);
            writer.WriteCollectionOfObjectValues<AppRole>("appRoles", AppRoles);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Certification>("certification", Certification);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ConnectorGroup>("connectorGroup", ConnectorGroup);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteObjectValue<DirectoryObject>("createdOnBehalfOf", CreatedOnBehalfOf);
            writer.WriteStringValue("defaultRedirectUri", DefaultRedirectUri);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("disabledByMicrosoftStatus", DisabledByMicrosoftStatus);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteCollectionOfObjectValues<ExtensionProperty>("extensionProperties", ExtensionProperties);
            writer.WriteCollectionOfObjectValues<FederatedIdentityCredential>("federatedIdentityCredentials", FederatedIdentityCredentials);
            writer.WriteStringValue("groupMembershipClaims", GroupMembershipClaims);
            writer.WriteCollectionOfObjectValues<HomeRealmDiscoveryPolicy>("homeRealmDiscoveryPolicies", HomeRealmDiscoveryPolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("identifierUris", IdentifierUris);
            writer.WriteObjectValue<InformationalUrl>("info", Info);
            writer.WriteBoolValue("isDeviceOnlyAuthSupported", IsDeviceOnlyAuthSupported);
            writer.WriteBoolValue("isFallbackPublicClient", IsFallbackPublicClient);
            writer.WriteCollectionOfObjectValues<KeyCredential>("keyCredentials", KeyCredentials);
            writer.WriteByteArrayValue("logo", Logo);
            writer.WriteStringValue("notes", Notes);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OnPremisesPublishing>("onPremisesPublishing", OnPremisesPublishing);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.OptionalClaims>("optionalClaims", OptionalClaims);
            writer.WriteCollectionOfObjectValues<DirectoryObject>("owners", Owners);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.ParentalControlSettings>("parentalControlSettings", ParentalControlSettings);
            writer.WriteCollectionOfObjectValues<PasswordCredential>("passwordCredentials", PasswordCredentials);
            writer.WriteObjectValue<PublicClientApplication>("publicClient", PublicClient);
            writer.WriteStringValue("publisherDomain", PublisherDomain);
            writer.WriteCollectionOfObjectValues<Microsoft.Graph.Beta.Models.RequiredResourceAccess>("requiredResourceAccess", RequiredResourceAccess);
            writer.WriteStringValue("samlMetadataUrl", SamlMetadataUrl);
            writer.WriteStringValue("serviceManagementReference", ServiceManagementReference);
            writer.WriteStringValue("signInAudience", SignInAudience);
            writer.WriteObjectValue<SpaApplication>("spa", Spa);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Synchronization>("synchronization", Synchronization);
            writer.WriteCollectionOfPrimitiveValues<string>("tags", Tags);
            writer.WriteStringValue("tokenEncryptionKeyId", TokenEncryptionKeyId);
            writer.WriteCollectionOfObjectValues<TokenIssuancePolicy>("tokenIssuancePolicies", TokenIssuancePolicies);
            writer.WriteCollectionOfObjectValues<TokenLifetimePolicy>("tokenLifetimePolicies", TokenLifetimePolicies);
            writer.WriteStringValue("uniqueName", UniqueName);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.VerifiedPublisher>("verifiedPublisher", VerifiedPublisher);
            writer.WriteObjectValue<WebApplication>("web", Web);
            writer.WriteObjectValue<WindowsApplication>("windows", Windows);
        }
    }
}
