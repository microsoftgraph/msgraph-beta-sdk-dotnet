using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class SignIn : Entity, IParsable {
        /// <summary>The application name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).</summary>
        public string AppDisplayName {
            get { return BackingStore?.Get<string>(nameof(AppDisplayName)); }
            set { BackingStore?.Set(nameof(AppDisplayName), value); }
        }
        /// <summary>The application identifier in Azure Active Directory. Supports $filter (eq operator only).</summary>
        public string AppId {
            get { return BackingStore?.Get<string>(nameof(AppId)); }
            set { BackingStore?.Set(nameof(AppId), value); }
        }
        /// <summary>A list of conditional access policies that are triggered by the corresponding sign-in activity.</summary>
        public List<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies {
            get { return BackingStore?.Get<List<AppliedConditionalAccessPolicy>>(nameof(AppliedConditionalAccessPolicies)); }
            set { BackingStore?.Set(nameof(AppliedConditionalAccessPolicies), value); }
        }
        /// <summary>Contains a collection of values that represent the conditional access authentication contexts applied to the sign-in.</summary>
        public List<AuthenticationContext> AuthenticationContextClassReferences {
            get { return BackingStore?.Get<List<AuthenticationContext>>(nameof(AuthenticationContextClassReferences)); }
            set { BackingStore?.Set(nameof(AuthenticationContextClassReferences), value); }
        }
        /// <summary>The result of the authentication attempt and additional details on the authentication method.</summary>
        public List<AuthenticationDetail> AuthenticationDetails {
            get { return BackingStore?.Get<List<AuthenticationDetail>>(nameof(AuthenticationDetails)); }
            set { BackingStore?.Set(nameof(AuthenticationDetails), value); }
        }
        /// <summary>The authentication methods used. Possible values: SMS, Authenticator App, App Verification code, Password, FIDO, PTA, or PHS.</summary>
        public List<string> AuthenticationMethodsUsed {
            get { return BackingStore?.Get<List<string>>(nameof(AuthenticationMethodsUsed)); }
            set { BackingStore?.Set(nameof(AuthenticationMethodsUsed), value); }
        }
        /// <summary>Additional authentication processing details, such as the agent name in case of PTA/PHS or Server/farm name in case of federated authentication.</summary>
        public List<KeyValue> AuthenticationProcessingDetails {
            get { return BackingStore?.Get<List<KeyValue>>(nameof(AuthenticationProcessingDetails)); }
            set { BackingStore?.Set(nameof(AuthenticationProcessingDetails), value); }
        }
        /// <summary>Lists the protocol type or grant type used in the authentication. The possible values are: none, oAuth2, ropc, wsFederation, saml20, deviceCode, unknownFutureValue. For authentications that use protocols other than the possible values listed, the protocol type is listed as none.</summary>
        public ProtocolType? AuthenticationProtocol {
            get { return BackingStore?.Get<ProtocolType?>(nameof(AuthenticationProtocol)); }
            set { BackingStore?.Set(nameof(AuthenticationProtocol), value); }
        }
        /// <summary>This holds the highest level of authentication needed through all the sign-in steps, for sign-in to succeed. Supports $filter (eq and startsWith operators only).</summary>
        public string AuthenticationRequirement {
            get { return BackingStore?.Get<string>(nameof(AuthenticationRequirement)); }
            set { BackingStore?.Set(nameof(AuthenticationRequirement), value); }
        }
        /// <summary>Sources of authentication requirement, such as conditional access, per-user MFA, identity protection, and security defaults.</summary>
        public List<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies {
            get { return BackingStore?.Get<List<AuthenticationRequirementPolicy>>(nameof(AuthenticationRequirementPolicies)); }
            set { BackingStore?.Set(nameof(AuthenticationRequirementPolicies), value); }
        }
        /// <summary>The Autonomous System Number (ASN) of the network used by the actor.</summary>
        public int? AutonomousSystemNumber {
            get { return BackingStore?.Get<int?>(nameof(AutonomousSystemNumber)); }
            set { BackingStore?.Set(nameof(AutonomousSystemNumber), value); }
        }
        /// <summary>Contains a fully qualified Azure Resource Manager ID of an Azure resource accessed during the sign-in.</summary>
        public string AzureResourceId {
            get { return BackingStore?.Get<string>(nameof(AzureResourceId)); }
            set { BackingStore?.Set(nameof(AzureResourceId), value); }
        }
        /// <summary>The legacy client used for sign-in activity. For example: Browser, Exchange ActiveSync, Modern clients, IMAP, MAPI, SMTP, or POP. Supports $filter (eq operator only).</summary>
        public string ClientAppUsed {
            get { return BackingStore?.Get<string>(nameof(ClientAppUsed)); }
            set { BackingStore?.Set(nameof(ClientAppUsed), value); }
        }
        /// <summary>Describes the credential type that a user client or service principal provided to Azure AD to authenticate itself. You may wish to review clientCredentialType to track and eliminate less secure credential types or to watch for clients and service principals using anomalous credential types. The possible values are: none, clientSecret, clientAssertion, federatedIdentityCredential, managedIdentity, certificate, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.ClientCredentialType? ClientCredentialType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ClientCredentialType?>(nameof(ClientCredentialType)); }
            set { BackingStore?.Set(nameof(ClientCredentialType), value); }
        }
        /// <summary>The status of the conditional access policy triggered. Possible values: success, failure, notApplied, or unknownFutureValue. Supports $filter (eq operator only).</summary>
        public Microsoft.Graph.Beta.Models.ConditionalAccessStatus? ConditionalAccessStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.ConditionalAccessStatus?>(nameof(ConditionalAccessStatus)); }
            set { BackingStore?.Set(nameof(ConditionalAccessStatus), value); }
        }
        /// <summary>The identifier that&apos;s sent from the client when sign-in is initiated. This is used for troubleshooting the corresponding sign-in activity when calling for support. Supports $filter (eq operator only).</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>(nameof(CorrelationId)); }
            set { BackingStore?.Set(nameof(CorrelationId), value); }
        }
        /// <summary>The date and time the sign-in was initiated. The Timestamp type is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).</summary>
        public DateTimeOffset? CreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(CreatedDateTime)); }
            set { BackingStore?.Set(nameof(CreatedDateTime), value); }
        }
        /// <summary>Describes the type of cross-tenant access used by the actor to access the resource. Possible values are: none, b2bCollaboration, b2bDirectConnect, microsoftSupport, serviceProvider, unknownFutureValue. If the sign in did not cross tenant boundaries, the value is none.</summary>
        public SignInAccessType? CrossTenantAccessType {
            get { return BackingStore?.Get<SignInAccessType?>(nameof(CrossTenantAccessType)); }
            set { BackingStore?.Set(nameof(CrossTenantAccessType), value); }
        }
        /// <summary>The device information from where the sign-in occurred. Includes information such as deviceId, OS, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSystem properties.</summary>
        public Microsoft.Graph.Beta.Models.DeviceDetail DeviceDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceDetail>(nameof(DeviceDetail)); }
            set { BackingStore?.Set(nameof(DeviceDetail), value); }
        }
        /// <summary>Contains the identifier of an application&apos;s federated identity credential, if a federated identity credential was used to sign in.</summary>
        public string FederatedCredentialId {
            get { return BackingStore?.Get<string>(nameof(FederatedCredentialId)); }
            set { BackingStore?.Set(nameof(FederatedCredentialId), value); }
        }
        /// <summary>During a failed sign in, a user may click a button in the Azure portal to mark the failed event for tenant admins. If a user clicked the button to flag the failed sign in, this value is true.</summary>
        public bool? FlaggedForReview {
            get { return BackingStore?.Get<bool?>(nameof(FlaggedForReview)); }
            set { BackingStore?.Set(nameof(FlaggedForReview), value); }
        }
        /// <summary>The tenant identifier of the user initiating the sign in. Not applicable in Managed Identity or service principal sign ins.</summary>
        public string HomeTenantId {
            get { return BackingStore?.Get<string>(nameof(HomeTenantId)); }
            set { BackingStore?.Set(nameof(HomeTenantId), value); }
        }
        /// <summary>For user sign ins, the identifier of the tenant that the user is a member of. Only populated in cases where the home tenant has provided affirmative consent to Azure AD to show the tenant content.</summary>
        public string HomeTenantName {
            get { return BackingStore?.Get<string>(nameof(HomeTenantName)); }
            set { BackingStore?.Set(nameof(HomeTenantName), value); }
        }
        /// <summary>Indicates the token types that were presented to Azure AD to authenticate the actor in the sign in. The possible values are: none, primaryRefreshToken, saml11, saml20, unknownFutureValue, remoteDesktopToken.  NOTE Azure AD may have also used token types not listed in this Enum type to authenticate the actor. Do not infer the lack of a token if it is not one of the types listed. Also, please note that you must use the Prefer: include-unknown-enum-members request header to get the following value(s) in this evolvable enum: remoteDesktopToken.</summary>
        public Microsoft.Graph.Beta.Models.IncomingTokenType? IncomingTokenType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.IncomingTokenType?>(nameof(IncomingTokenType)); }
            set { BackingStore?.Set(nameof(IncomingTokenType), value); }
        }
        /// <summary>The IP address of the client from where the sign-in occurred. Supports $filter (eq and startsWith operators only).</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>(nameof(IpAddress)); }
            set { BackingStore?.Set(nameof(IpAddress), value); }
        }
        /// <summary>The IP address a user used to reach a resource provider, used to determine Conditional Access compliance for some policies. For example, when a user interacts with Exchange Online, the IP address Exchange receives from the user may be recorded here. This value is often null.</summary>
        public string IpAddressFromResourceProvider {
            get { return BackingStore?.Get<string>(nameof(IpAddressFromResourceProvider)); }
            set { BackingStore?.Set(nameof(IpAddressFromResourceProvider), value); }
        }
        /// <summary>Indicates whether a user sign in is interactive. In interactive sign in, the user provides an authentication factor to Azure AD. These factors include passwords, responses to MFA challenges, biometric factors, or QR codes that a user provides to Azure AD or an associated app. In non-interactive sign in, the user doesn&apos;t provide an authentication factor. Instead, the client app uses a token or code to authenticate or access a resource on behalf of a user. Non-interactive sign ins are commonly used for a client to sign in on a user&apos;s behalf in a process transparent to the user.</summary>
        public bool? IsInteractive {
            get { return BackingStore?.Get<bool?>(nameof(IsInteractive)); }
            set { BackingStore?.Set(nameof(IsInteractive), value); }
        }
        /// <summary>Shows whether the sign in event was subject to an Azure AD tenant restriction policy.</summary>
        public bool? IsTenantRestricted {
            get { return BackingStore?.Get<bool?>(nameof(IsTenantRestricted)); }
            set { BackingStore?.Set(nameof(IsTenantRestricted), value); }
        }
        /// <summary>The city, state, and 2 letter country code from where the sign-in occurred. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.</summary>
        public SignInLocation Location {
            get { return BackingStore?.Get<SignInLocation>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>The mfaDetail property</summary>
        public Microsoft.Graph.Beta.Models.MfaDetail MfaDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MfaDetail>(nameof(MfaDetail)); }
            set { BackingStore?.Set(nameof(MfaDetail), value); }
        }
        /// <summary>The network location details including the type of network used and its names.</summary>
        public List<NetworkLocationDetail> NetworkLocationDetails {
            get { return BackingStore?.Get<List<NetworkLocationDetail>>(nameof(NetworkLocationDetails)); }
            set { BackingStore?.Set(nameof(NetworkLocationDetails), value); }
        }
        /// <summary>The request identifier of the first request in the authentication sequence. Supports $filter (eq operator only).</summary>
        public string OriginalRequestId {
            get { return BackingStore?.Get<string>(nameof(OriginalRequestId)); }
            set { BackingStore?.Set(nameof(OriginalRequestId), value); }
        }
        /// <summary>Contains information about the Azure AD Private Link policy that is associated with the sign in event.</summary>
        public Microsoft.Graph.Beta.Models.PrivateLinkDetails PrivateLinkDetails {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.PrivateLinkDetails>(nameof(PrivateLinkDetails)); }
            set { BackingStore?.Set(nameof(PrivateLinkDetails), value); }
        }
        /// <summary>The request processing time in milliseconds in AD STS.</summary>
        public int? ProcessingTimeInMilliseconds {
            get { return BackingStore?.Get<int?>(nameof(ProcessingTimeInMilliseconds)); }
            set { BackingStore?.Set(nameof(ProcessingTimeInMilliseconds), value); }
        }
        /// <summary>The name of the resource that the user signed in to. Supports $filter (eq operator only).</summary>
        public string ResourceDisplayName {
            get { return BackingStore?.Get<string>(nameof(ResourceDisplayName)); }
            set { BackingStore?.Set(nameof(ResourceDisplayName), value); }
        }
        /// <summary>The identifier of the resource that the user signed in to. Supports $filter (eq operator only).</summary>
        public string ResourceId {
            get { return BackingStore?.Get<string>(nameof(ResourceId)); }
            set { BackingStore?.Set(nameof(ResourceId), value); }
        }
        /// <summary>The identifier of the service principal representing the target resource in the sign-in event.</summary>
        public string ResourceServicePrincipalId {
            get { return BackingStore?.Get<string>(nameof(ResourceServicePrincipalId)); }
            set { BackingStore?.Set(nameof(ResourceServicePrincipalId), value); }
        }
        /// <summary>The tenant identifier of the resource referenced in the sign in.</summary>
        public string ResourceTenantId {
            get { return BackingStore?.Get<string>(nameof(ResourceTenantId)); }
            set { BackingStore?.Set(nameof(ResourceTenantId), value); }
        }
        /// <summary>The reason behind a specific state of a risky user, sign-in, or a risk event. Possible values: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, or unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public Microsoft.Graph.Beta.Models.RiskDetail? RiskDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskDetail?>(nameof(RiskDetail)); }
            set { BackingStore?.Set(nameof(RiskDetail), value); }
        }
        /// <summary>The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).</summary>
        public List<string> RiskEventTypes_v2 {
            get { return BackingStore?.Get<List<string>>(nameof(RiskEventTypes_v2)); }
            set { BackingStore?.Set(nameof(RiskEventTypes_v2), value); }
        }
        /// <summary>The aggregated risk level. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelAggregated {
            get { return BackingStore?.Get<RiskLevel?>(nameof(RiskLevelAggregated)); }
            set { BackingStore?.Set(nameof(RiskLevelAggregated), value); }
        }
        /// <summary>The risk level during sign-in. Possible values: none, low, medium, high, hidden, or unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers are returned hidden.</summary>
        public RiskLevel? RiskLevelDuringSignIn {
            get { return BackingStore?.Get<RiskLevel?>(nameof(RiskLevelDuringSignIn)); }
            set { BackingStore?.Set(nameof(RiskLevelDuringSignIn), value); }
        }
        /// <summary>The risk state of a risky user, sign-in, or a risk event. Possible values: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, or unknownFutureValue. Supports $filter (eq operator only).</summary>
        public Microsoft.Graph.Beta.Models.RiskState? RiskState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskState?>(nameof(RiskState)); }
            set { BackingStore?.Set(nameof(RiskState), value); }
        }
        /// <summary>The unique identifier of the key credential used by the service principal to authenticate.</summary>
        public string ServicePrincipalCredentialKeyId {
            get { return BackingStore?.Get<string>(nameof(ServicePrincipalCredentialKeyId)); }
            set { BackingStore?.Set(nameof(ServicePrincipalCredentialKeyId), value); }
        }
        /// <summary>The certificate thumbprint of the certificate used by the service principal to authenticate.</summary>
        public string ServicePrincipalCredentialThumbprint {
            get { return BackingStore?.Get<string>(nameof(ServicePrincipalCredentialThumbprint)); }
            set { BackingStore?.Set(nameof(ServicePrincipalCredentialThumbprint), value); }
        }
        /// <summary>The application identifier used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).</summary>
        public string ServicePrincipalId {
            get { return BackingStore?.Get<string>(nameof(ServicePrincipalId)); }
            set { BackingStore?.Set(nameof(ServicePrincipalId), value); }
        }
        /// <summary>The application name used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).</summary>
        public string ServicePrincipalName {
            get { return BackingStore?.Get<string>(nameof(ServicePrincipalName)); }
            set { BackingStore?.Set(nameof(ServicePrincipalName), value); }
        }
        /// <summary>Any conditional access session management policies that were applied during the sign-in event.</summary>
        public List<SessionLifetimePolicy> SessionLifetimePolicies {
            get { return BackingStore?.Get<List<SessionLifetimePolicy>>(nameof(SessionLifetimePolicies)); }
            set { BackingStore?.Set(nameof(SessionLifetimePolicies), value); }
        }
        /// <summary>Indicates the category of sign in that the event represents. For user sign ins, the category can be interactiveUser or nonInteractiveUser and corresponds to the value for the isInteractive property on the signin resource. For managed identity sign ins, the category is managedIdentity. For service principal sign ins, the category is servicePrincipal. Possible values are: interactiveUser, nonInteractiveUser, servicePrincipal, managedIdentity, unknownFutureValue. Supports $filter (eq, ne).</summary>
        public List<string> SignInEventTypes {
            get { return BackingStore?.Get<List<string>>(nameof(SignInEventTypes)); }
            set { BackingStore?.Set(nameof(SignInEventTypes), value); }
        }
        /// <summary>The identification that the user provided to sign in. It may be the userPrincipalName but it&apos;s also populated when a user signs in using other identifiers.</summary>
        public string SignInIdentifier {
            get { return BackingStore?.Get<string>(nameof(SignInIdentifier)); }
            set { BackingStore?.Set(nameof(SignInIdentifier), value); }
        }
        /// <summary>The type of sign in identifier. Possible values are: userPrincipalName, phoneNumber, proxyAddress, qrCode, onPremisesUserPrincipalName, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.SignInIdentifierType? SignInIdentifierType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.SignInIdentifierType?>(nameof(SignInIdentifierType)); }
            set { BackingStore?.Set(nameof(SignInIdentifierType), value); }
        }
        /// <summary>The sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.</summary>
        public SignInStatus Status {
            get { return BackingStore?.Get<SignInStatus>(nameof(Status)); }
            set { BackingStore?.Set(nameof(Status), value); }
        }
        /// <summary>The name of the identity provider. For example, sts.microsoft.com. Supports $filter (eq operator only).</summary>
        public string TokenIssuerName {
            get { return BackingStore?.Get<string>(nameof(TokenIssuerName)); }
            set { BackingStore?.Set(nameof(TokenIssuerName), value); }
        }
        /// <summary>The type of identity provider. The possible values are: AzureAD, ADFederationServices, UnknownFutureValue, AzureADBackupAuth, ADFederationServicesMFAAdapter, NPSExtension. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: AzureADBackupAuth , ADFederationServicesMFAAdapter , NPSExtension.</summary>
        public Microsoft.Graph.Beta.Models.TokenIssuerType? TokenIssuerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TokenIssuerType?>(nameof(TokenIssuerType)); }
            set { BackingStore?.Set(nameof(TokenIssuerType), value); }
        }
        /// <summary>A unique base64 encoded request identifier used to track tokens issued by Azure AD as they are redeemed at resource providers.</summary>
        public string UniqueTokenIdentifier {
            get { return BackingStore?.Get<string>(nameof(UniqueTokenIdentifier)); }
            set { BackingStore?.Set(nameof(UniqueTokenIdentifier), value); }
        }
        /// <summary>The user agent information related to sign-in. Supports $filter (eq and startsWith operators only).</summary>
        public string UserAgent {
            get { return BackingStore?.Get<string>(nameof(UserAgent)); }
            set { BackingStore?.Set(nameof(UserAgent), value); }
        }
        /// <summary>The display name of the user. Supports $filter (eq and startsWith operators only).</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>The identifier of the user. Supports $filter (eq operator only).</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>The UPN of the user. Supports $filter (eq and startsWith operators only).</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>Identifies whether the user is a member or guest in the tenant. Possible values are: member, guest, unknownFutureValue.</summary>
        public SignInUserType? UserType {
            get { return BackingStore?.Get<SignInUserType?>(nameof(UserType)); }
            set { BackingStore?.Set(nameof(UserType), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SignIn CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.restrictedSignIn" => new RestrictedSignIn(),
                _ => new SignIn(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"appDisplayName", n => { AppDisplayName = n.GetStringValue(); } },
                {"appId", n => { AppId = n.GetStringValue(); } },
                {"appliedConditionalAccessPolicies", n => { AppliedConditionalAccessPolicies = n.GetCollectionOfObjectValues<AppliedConditionalAccessPolicy>(AppliedConditionalAccessPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationContextClassReferences", n => { AuthenticationContextClassReferences = n.GetCollectionOfObjectValues<AuthenticationContext>(AuthenticationContext.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationDetails", n => { AuthenticationDetails = n.GetCollectionOfObjectValues<AuthenticationDetail>(AuthenticationDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationMethodsUsed", n => { AuthenticationMethodsUsed = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"authenticationProcessingDetails", n => { AuthenticationProcessingDetails = n.GetCollectionOfObjectValues<KeyValue>(KeyValue.CreateFromDiscriminatorValue).ToList(); } },
                {"authenticationProtocol", n => { AuthenticationProtocol = n.GetEnumValue<ProtocolType>(); } },
                {"authenticationRequirement", n => { AuthenticationRequirement = n.GetStringValue(); } },
                {"authenticationRequirementPolicies", n => { AuthenticationRequirementPolicies = n.GetCollectionOfObjectValues<AuthenticationRequirementPolicy>(AuthenticationRequirementPolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"autonomousSystemNumber", n => { AutonomousSystemNumber = n.GetIntValue(); } },
                {"azureResourceId", n => { AzureResourceId = n.GetStringValue(); } },
                {"clientAppUsed", n => { ClientAppUsed = n.GetStringValue(); } },
                {"clientCredentialType", n => { ClientCredentialType = n.GetEnumValue<ClientCredentialType>(); } },
                {"conditionalAccessStatus", n => { ConditionalAccessStatus = n.GetEnumValue<ConditionalAccessStatus>(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"createdDateTime", n => { CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"crossTenantAccessType", n => { CrossTenantAccessType = n.GetEnumValue<SignInAccessType>(); } },
                {"deviceDetail", n => { DeviceDetail = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceDetail>(Microsoft.Graph.Beta.Models.DeviceDetail.CreateFromDiscriminatorValue); } },
                {"federatedCredentialId", n => { FederatedCredentialId = n.GetStringValue(); } },
                {"flaggedForReview", n => { FlaggedForReview = n.GetBoolValue(); } },
                {"homeTenantId", n => { HomeTenantId = n.GetStringValue(); } },
                {"homeTenantName", n => { HomeTenantName = n.GetStringValue(); } },
                {"incomingTokenType", n => { IncomingTokenType = n.GetEnumValue<IncomingTokenType>(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"ipAddressFromResourceProvider", n => { IpAddressFromResourceProvider = n.GetStringValue(); } },
                {"isInteractive", n => { IsInteractive = n.GetBoolValue(); } },
                {"isTenantRestricted", n => { IsTenantRestricted = n.GetBoolValue(); } },
                {"location", n => { Location = n.GetObjectValue<SignInLocation>(SignInLocation.CreateFromDiscriminatorValue); } },
                {"mfaDetail", n => { MfaDetail = n.GetObjectValue<Microsoft.Graph.Beta.Models.MfaDetail>(Microsoft.Graph.Beta.Models.MfaDetail.CreateFromDiscriminatorValue); } },
                {"networkLocationDetails", n => { NetworkLocationDetails = n.GetCollectionOfObjectValues<NetworkLocationDetail>(NetworkLocationDetail.CreateFromDiscriminatorValue).ToList(); } },
                {"originalRequestId", n => { OriginalRequestId = n.GetStringValue(); } },
                {"privateLinkDetails", n => { PrivateLinkDetails = n.GetObjectValue<Microsoft.Graph.Beta.Models.PrivateLinkDetails>(Microsoft.Graph.Beta.Models.PrivateLinkDetails.CreateFromDiscriminatorValue); } },
                {"processingTimeInMilliseconds", n => { ProcessingTimeInMilliseconds = n.GetIntValue(); } },
                {"resourceDisplayName", n => { ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", n => { ResourceId = n.GetStringValue(); } },
                {"resourceServicePrincipalId", n => { ResourceServicePrincipalId = n.GetStringValue(); } },
                {"resourceTenantId", n => { ResourceTenantId = n.GetStringValue(); } },
                {"riskDetail", n => { RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventTypes_v2", n => { RiskEventTypes_v2 = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskLevelAggregated", n => { RiskLevelAggregated = n.GetEnumValue<RiskLevel>(); } },
                {"riskLevelDuringSignIn", n => { RiskLevelDuringSignIn = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", n => { RiskState = n.GetEnumValue<RiskState>(); } },
                {"servicePrincipalCredentialKeyId", n => { ServicePrincipalCredentialKeyId = n.GetStringValue(); } },
                {"servicePrincipalCredentialThumbprint", n => { ServicePrincipalCredentialThumbprint = n.GetStringValue(); } },
                {"servicePrincipalId", n => { ServicePrincipalId = n.GetStringValue(); } },
                {"servicePrincipalName", n => { ServicePrincipalName = n.GetStringValue(); } },
                {"sessionLifetimePolicies", n => { SessionLifetimePolicies = n.GetCollectionOfObjectValues<SessionLifetimePolicy>(SessionLifetimePolicy.CreateFromDiscriminatorValue).ToList(); } },
                {"signInEventTypes", n => { SignInEventTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"signInIdentifier", n => { SignInIdentifier = n.GetStringValue(); } },
                {"signInIdentifierType", n => { SignInIdentifierType = n.GetEnumValue<SignInIdentifierType>(); } },
                {"status", n => { Status = n.GetObjectValue<SignInStatus>(SignInStatus.CreateFromDiscriminatorValue); } },
                {"tokenIssuerName", n => { TokenIssuerName = n.GetStringValue(); } },
                {"tokenIssuerType", n => { TokenIssuerType = n.GetEnumValue<TokenIssuerType>(); } },
                {"uniqueTokenIdentifier", n => { UniqueTokenIdentifier = n.GetStringValue(); } },
                {"userAgent", n => { UserAgent = n.GetStringValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
                {"userPrincipalName", n => { UserPrincipalName = n.GetStringValue(); } },
                {"userType", n => { UserType = n.GetEnumValue<SignInUserType>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("appDisplayName", AppDisplayName);
            writer.WriteStringValue("appId", AppId);
            writer.WriteCollectionOfObjectValues<AppliedConditionalAccessPolicy>("appliedConditionalAccessPolicies", AppliedConditionalAccessPolicies);
            writer.WriteCollectionOfObjectValues<AuthenticationContext>("authenticationContextClassReferences", AuthenticationContextClassReferences);
            writer.WriteCollectionOfObjectValues<AuthenticationDetail>("authenticationDetails", AuthenticationDetails);
            writer.WriteCollectionOfPrimitiveValues<string>("authenticationMethodsUsed", AuthenticationMethodsUsed);
            writer.WriteCollectionOfObjectValues<KeyValue>("authenticationProcessingDetails", AuthenticationProcessingDetails);
            writer.WriteEnumValue<ProtocolType>("authenticationProtocol", AuthenticationProtocol);
            writer.WriteStringValue("authenticationRequirement", AuthenticationRequirement);
            writer.WriteCollectionOfObjectValues<AuthenticationRequirementPolicy>("authenticationRequirementPolicies", AuthenticationRequirementPolicies);
            writer.WriteIntValue("autonomousSystemNumber", AutonomousSystemNumber);
            writer.WriteStringValue("azureResourceId", AzureResourceId);
            writer.WriteStringValue("clientAppUsed", ClientAppUsed);
            writer.WriteEnumValue<ClientCredentialType>("clientCredentialType", ClientCredentialType);
            writer.WriteEnumValue<ConditionalAccessStatus>("conditionalAccessStatus", ConditionalAccessStatus);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<SignInAccessType>("crossTenantAccessType", CrossTenantAccessType);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceDetail>("deviceDetail", DeviceDetail);
            writer.WriteStringValue("federatedCredentialId", FederatedCredentialId);
            writer.WriteBoolValue("flaggedForReview", FlaggedForReview);
            writer.WriteStringValue("homeTenantId", HomeTenantId);
            writer.WriteStringValue("homeTenantName", HomeTenantName);
            writer.WriteEnumValue<IncomingTokenType>("incomingTokenType", IncomingTokenType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteStringValue("ipAddressFromResourceProvider", IpAddressFromResourceProvider);
            writer.WriteBoolValue("isInteractive", IsInteractive);
            writer.WriteBoolValue("isTenantRestricted", IsTenantRestricted);
            writer.WriteObjectValue<SignInLocation>("location", Location);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.MfaDetail>("mfaDetail", MfaDetail);
            writer.WriteCollectionOfObjectValues<NetworkLocationDetail>("networkLocationDetails", NetworkLocationDetails);
            writer.WriteStringValue("originalRequestId", OriginalRequestId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.PrivateLinkDetails>("privateLinkDetails", PrivateLinkDetails);
            writer.WriteIntValue("processingTimeInMilliseconds", ProcessingTimeInMilliseconds);
            writer.WriteStringValue("resourceDisplayName", ResourceDisplayName);
            writer.WriteStringValue("resourceId", ResourceId);
            writer.WriteStringValue("resourceServicePrincipalId", ResourceServicePrincipalId);
            writer.WriteStringValue("resourceTenantId", ResourceTenantId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteCollectionOfPrimitiveValues<string>("riskEventTypes_v2", RiskEventTypes_v2);
            writer.WriteEnumValue<RiskLevel>("riskLevelAggregated", RiskLevelAggregated);
            writer.WriteEnumValue<RiskLevel>("riskLevelDuringSignIn", RiskLevelDuringSignIn);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteStringValue("servicePrincipalCredentialKeyId", ServicePrincipalCredentialKeyId);
            writer.WriteStringValue("servicePrincipalCredentialThumbprint", ServicePrincipalCredentialThumbprint);
            writer.WriteStringValue("servicePrincipalId", ServicePrincipalId);
            writer.WriteStringValue("servicePrincipalName", ServicePrincipalName);
            writer.WriteCollectionOfObjectValues<SessionLifetimePolicy>("sessionLifetimePolicies", SessionLifetimePolicies);
            writer.WriteCollectionOfPrimitiveValues<string>("signInEventTypes", SignInEventTypes);
            writer.WriteStringValue("signInIdentifier", SignInIdentifier);
            writer.WriteEnumValue<SignInIdentifierType>("signInIdentifierType", SignInIdentifierType);
            writer.WriteObjectValue<SignInStatus>("status", Status);
            writer.WriteStringValue("tokenIssuerName", TokenIssuerName);
            writer.WriteEnumValue<TokenIssuerType>("tokenIssuerType", TokenIssuerType);
            writer.WriteStringValue("uniqueTokenIdentifier", UniqueTokenIdentifier);
            writer.WriteStringValue("userAgent", UserAgent);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
            writer.WriteEnumValue<SignInUserType>("userType", UserType);
        }
    }
}
