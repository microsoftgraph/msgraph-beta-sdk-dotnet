using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class SignIn : Entity, IParsable {
        /// <summary>App name displayed in the Azure Portal. Supports $filter (eq and startsWith operators only).</summary>
        public string AppDisplayName { get; set; }
        /// <summary>Unique GUID representing the app ID in the Azure Active Directory. Supports $filter (eq operator only).</summary>
        public string AppId { get; set; }
        /// <summary>A list of conditional access policies that are triggered by the corresponding sign-in activity.</summary>
        public List<AppliedConditionalAccessPolicy> AppliedConditionalAccessPolicies { get; set; }
        /// <summary>Contains a collection of values that represent the conditional access authentication contexts applied to the sign-in.</summary>
        public List<AuthenticationContext> AuthenticationContextClassReferences { get; set; }
        /// <summary>The result of the authentication attempt and additional details on the authentication method.</summary>
        public List<AuthenticationDetail> AuthenticationDetails { get; set; }
        /// <summary>The authentication methods used. Possible values: SMS, Authenticator App, App Verification code, Password, FIDO, PTA, or PHS.</summary>
        public List<string> AuthenticationMethodsUsed { get; set; }
        /// <summary>Additional authentication processing details, such as the agent name in case of PTA/PHS or Server/farm name in case of federated authentication.</summary>
        public List<KeyValue> AuthenticationProcessingDetails { get; set; }
        /// <summary>Lists the protocol type or grant type used in the authentication. The possible values are: none, oAuth2, ropc, wsFederation, saml20, deviceCode, unknownFutureValue. For authentications that use protocols other than the possible values listed, the protocol type is listed as none.</summary>
        public ProtocolType? AuthenticationProtocol { get; set; }
        /// <summary>This holds the highest level of authentication needed through all the sign-in steps, for sign-in to succeed. Supports $filter (eq and startsWith operators only).</summary>
        public string AuthenticationRequirement { get; set; }
        /// <summary>Sources of authentication requirement, such as conditional access, per-user MFA, identity protection, and security defaults.</summary>
        public List<AuthenticationRequirementPolicy> AuthenticationRequirementPolicies { get; set; }
        /// <summary>The Autonomous System Number (ASN) of the network used by the actor.</summary>
        public int? AutonomousSystemNumber { get; set; }
        /// <summary>Contains a fully qualified Azure Resource Manager ID of an Azure resource accessed during the sign-in.</summary>
        public string AzureResourceId { get; set; }
        /// <summary>Identifies the client used for the sign-in activity. Modern authentication clients include Browser and modern clients. Legacy authentication clients include Exchange ActiveSync, IMAP, MAPI, SMTP, POP, and other clients. Supports $filter (eq operator only).</summary>
        public string ClientAppUsed { get; set; }
        /// <summary>Reports status of an activated conditional access policy. Possible values are: success, failure, notApplied, and unknownFutureValue. Supports $filter (eq operator only).</summary>
        public ConditionalAccessStatus? ConditionalAccessStatus { get; set; }
        /// <summary>The request ID sent from the client when the sign-in is initiated; used to troubleshoot sign-in activity. Supports $filter (eq operator only).</summary>
        public string CorrelationId { get; set; }
        /// <summary>Date and time (UTC) the sign-in was initiated. Example: midnight on Jan 1, 2014 is reported as 2014-01-01T00:00:00Z. Supports $orderby and $filter (eq, le, and ge operators only).</summary>
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>Describes the type of cross-tenant access used by the actor to access the resource. Possible values are: none, b2bCollaboration, b2bDirectConnect, microsoftSupport, serviceProvider, unknownFutureValue. If the sign in did not cross tenant boundaries, the value is none.</summary>
        public SignInAccessType? CrossTenantAccessType { get; set; }
        /// <summary>Device information from where the sign-in occurred; includes device ID, operating system, and browser. Supports $filter (eq and startsWith operators only) on browser and operatingSytem properties.</summary>
        public DeviceDetail DeviceDetail { get; set; }
        /// <summary>Contains the identifier of an application's federated identity credential, if a federated identity credential was used to sign in.</summary>
        public string FederatedCredentialId { get; set; }
        /// <summary>During a failed sign in, a user may click a button in the Azure portal to mark the failed event for tenant admins. If a user clicked the button to flag the failed sign in, this value is true.</summary>
        public bool? FlaggedForReview { get; set; }
        /// <summary>The tenant identifier of the user initiating the sign in. Not applicable in Managed Identity or service principal sign ins.</summary>
        public string HomeTenantId { get; set; }
        /// <summary>For user sign ins, the identifier of the tenant that the user is a member of. Only populated in cases where the home tenant has provided affirmative consent to Azure AD to show the tenant content.</summary>
        public string HomeTenantName { get; set; }
        /// <summary>Indicates the token types that were presented to Azure AD to authenticate the actor in the sign in. The possible values are: none, primaryRefreshToken, saml11, saml20, unknownFutureValue.  NOTE Azure AD may have also used token types not listed in this Enum type to authenticate the actor. Do not infer the lack of a token if it is not one of the types listed.</summary>
        public IncomingTokenType? IncomingTokenType { get; set; }
        /// <summary>IP address of the client used to sign in. Supports $filter (eq and startsWith operators only).</summary>
        public string IpAddress { get; set; }
        /// <summary>The IP address a user used to reach a resource provider, used to determine Conditional Access compliance for some policies. For example, when a user interacts with Exchange Online, the IP address Exchange receives from the user may be recorded here. This value is often null.</summary>
        public string IpAddressFromResourceProvider { get; set; }
        /// <summary>Indicates if a sign-in is interactive or not.</summary>
        public bool? IsInteractive { get; set; }
        /// <summary>Shows whether the sign in event was subject to an Azure AD tenant restriction policy.</summary>
        public bool? IsTenantRestricted { get; set; }
        /// <summary>Provides the city, state, and country code where the sign-in originated. Supports $filter (eq and startsWith operators only) on city, state, and countryOrRegion properties.</summary>
        public SignInLocation Location { get; set; }
        public MfaDetail MfaDetail { get; set; }
        /// <summary>The network location details including the type of network used and its names.</summary>
        public List<NetworkLocationDetail> NetworkLocationDetails { get; set; }
        /// <summary>The request identifier of the first request in the authentication sequence. Supports $filter (eq operator only).</summary>
        public string OriginalRequestId { get; set; }
        /// <summary>Contains information about the Azure AD Private Link policy that is associated with the sign in event.</summary>
        public PrivateLinkDetails PrivateLinkDetails { get; set; }
        /// <summary>The request processing time in milliseconds in AD STS.</summary>
        public int? ProcessingTimeInMilliseconds { get; set; }
        /// <summary>Name of the resource the user signed into. Supports $filter (eq operator only).</summary>
        public string ResourceDisplayName { get; set; }
        /// <summary>ID of the resource that the user signed into. Supports $filter (eq operator only).</summary>
        public string ResourceId { get; set; }
        /// <summary>The identifier of the service principal representing the target resource in the sign-in event.</summary>
        public string ResourceServicePrincipalId { get; set; }
        /// <summary>The tenant identifier of the resource referenced in the sign in.</summary>
        public string ResourceTenantId { get; set; }
        /// <summary>Provides the 'reason' behind a specific state of a risky user, sign-in or a risk event. The possible values are: none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, unknownFutureValue. The value none means that no action has been performed on the user or sign-in so far.  Supports $filter (eq operator only).Note: Details for this property require an Azure AD Premium P2 license. Other licenses return the value hidden.</summary>
        public RiskDetail? RiskDetail { get; set; }
        /// <summary>The list of risk event types associated with the sign-in. Possible values: unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence,  generic, or unknownFutureValue. Supports $filter (eq and startsWith operators only).</summary>
        public List<string> RiskEventTypes_v2 { get; set; }
        /// <summary>Aggregated risk level. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection. Supports $filter (eq operator only).  Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.</summary>
        public RiskLevel? RiskLevelAggregated { get; set; }
        /// <summary>Risk level during sign-in. The possible values are: none, low, medium, high, hidden, and unknownFutureValue. The value hidden means the user or sign-in was not enabled for Azure AD Identity Protection.  Supports $filter (eq operator only). Note: Details for this property are only available for Azure AD Premium P2 customers. All other customers will be returned hidden.</summary>
        public RiskLevel? RiskLevelDuringSignIn { get; set; }
        /// <summary>Reports status of the risky user, sign-in, or a risk event. The possible values are: none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, unknownFutureValue. Supports $filter (eq operator only).</summary>
        public RiskState? RiskState { get; set; }
        /// <summary>The unique identifier of the key credential used by the service principal to authenticate.</summary>
        public string ServicePrincipalCredentialKeyId { get; set; }
        /// <summary>The certificate thumbprint of the certificate used by the service principal to authenticate.</summary>
        public string ServicePrincipalCredentialThumbprint { get; set; }
        /// <summary>The application identifier used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).</summary>
        public string ServicePrincipalId { get; set; }
        /// <summary>The application name used for sign-in. This field is populated when you are signing in using an application. Supports $filter (eq and startsWith operators only).</summary>
        public string ServicePrincipalName { get; set; }
        /// <summary>Any conditional access session management policies that were applied during the sign-in event.</summary>
        public List<SessionLifetimePolicy> SessionLifetimePolicies { get; set; }
        /// <summary>Indicates the category of sign in that the event represents. For user sign ins, the category can be interactiveUser or nonInteractiveUser and corresponds to the value for the isInteractive property on the signin resource. For managed identity sign ins, the category is managedIdentity. For service principal sign ins, the category is servicePrincipal. Possible values are: interactiveUser, nonInteractiveUser, servicePrincipal, managedIdentity, unknownFutureValue. Supports $filter (eq operator only).</summary>
        public List<string> SignInEventTypes { get; set; }
        /// <summary>The identification that the user provided to sign in. It may be the userPrincipalName but it's also populated when a user signs in using other identifiers.</summary>
        public string SignInIdentifier { get; set; }
        /// <summary>The type of sign in identifier. Possible values are: userPrincipalName, phoneNumber, proxyAddress, qrCode, onPremisesUserPrincipalName, unknownFutureValue.</summary>
        public SignInIdentifierType? SignInIdentifierType { get; set; }
        /// <summary>Sign-in status. Includes the error code and description of the error (in case of a sign-in failure). Supports $filter (eq operator only) on errorCode property.</summary>
        public SignInStatus Status { get; set; }
        /// <summary>The name of the identity provider. For example, sts.microsoft.com. Supports $filter (eq operator only).</summary>
        public string TokenIssuerName { get; set; }
        /// <summary>The type of identity provider. The possible values are: AzureAD, ADFederationServices, UnknownFutureValue, AzureADBackupAuth, ADFederationServicesMFAAdapter, NPSExtension. Note that you must use the Prefer: include-unknown-enum-members request header to get the following values in this evolvable enum: AzureADBackupAuth , ADFederationServicesMFAAdapter , NPSExtension.</summary>
        public TokenIssuerType? TokenIssuerType { get; set; }
        /// <summary>A unique base64 encoded request identifier used to track tokens issued by Azure AD as they are redeemed at resource providers.</summary>
        public string UniqueTokenIdentifier { get; set; }
        /// <summary>The user agent information related to sign-in. Supports $filter (eq and startsWith operators only).</summary>
        public string UserAgent { get; set; }
        /// <summary>Display name of the user that initiated the sign-in. Supports $filter (eq and startsWith operators only).</summary>
        public string UserDisplayName { get; set; }
        /// <summary>ID of the user that initiated the sign-in. Supports $filter (eq operator only).</summary>
        public string UserId { get; set; }
        /// <summary>User principal name of the user that initiated the sign-in. Supports $filter (eq and startsWith operators only).</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>Identifies whether the user is a member or guest in the tenant. Possible values are: member, guest, unknownFutureValue.</summary>
        public SignInUserType? UserType { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"appDisplayName", (o,n) => { (o as SignIn).AppDisplayName = n.GetStringValue(); } },
                {"appId", (o,n) => { (o as SignIn).AppId = n.GetStringValue(); } },
                {"appliedConditionalAccessPolicies", (o,n) => { (o as SignIn).AppliedConditionalAccessPolicies = n.GetCollectionOfObjectValues<AppliedConditionalAccessPolicy>().ToList(); } },
                {"authenticationContextClassReferences", (o,n) => { (o as SignIn).AuthenticationContextClassReferences = n.GetCollectionOfObjectValues<AuthenticationContext>().ToList(); } },
                {"authenticationDetails", (o,n) => { (o as SignIn).AuthenticationDetails = n.GetCollectionOfObjectValues<AuthenticationDetail>().ToList(); } },
                {"authenticationMethodsUsed", (o,n) => { (o as SignIn).AuthenticationMethodsUsed = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"authenticationProcessingDetails", (o,n) => { (o as SignIn).AuthenticationProcessingDetails = n.GetCollectionOfObjectValues<KeyValue>().ToList(); } },
                {"authenticationProtocol", (o,n) => { (o as SignIn).AuthenticationProtocol = n.GetEnumValue<ProtocolType>(); } },
                {"authenticationRequirement", (o,n) => { (o as SignIn).AuthenticationRequirement = n.GetStringValue(); } },
                {"authenticationRequirementPolicies", (o,n) => { (o as SignIn).AuthenticationRequirementPolicies = n.GetCollectionOfObjectValues<AuthenticationRequirementPolicy>().ToList(); } },
                {"autonomousSystemNumber", (o,n) => { (o as SignIn).AutonomousSystemNumber = n.GetIntValue(); } },
                {"azureResourceId", (o,n) => { (o as SignIn).AzureResourceId = n.GetStringValue(); } },
                {"clientAppUsed", (o,n) => { (o as SignIn).ClientAppUsed = n.GetStringValue(); } },
                {"conditionalAccessStatus", (o,n) => { (o as SignIn).ConditionalAccessStatus = n.GetEnumValue<ConditionalAccessStatus>(); } },
                {"correlationId", (o,n) => { (o as SignIn).CorrelationId = n.GetStringValue(); } },
                {"createdDateTime", (o,n) => { (o as SignIn).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"crossTenantAccessType", (o,n) => { (o as SignIn).CrossTenantAccessType = n.GetEnumValue<SignInAccessType>(); } },
                {"deviceDetail", (o,n) => { (o as SignIn).DeviceDetail = n.GetObjectValue<DeviceDetail>(); } },
                {"federatedCredentialId", (o,n) => { (o as SignIn).FederatedCredentialId = n.GetStringValue(); } },
                {"flaggedForReview", (o,n) => { (o as SignIn).FlaggedForReview = n.GetBoolValue(); } },
                {"homeTenantId", (o,n) => { (o as SignIn).HomeTenantId = n.GetStringValue(); } },
                {"homeTenantName", (o,n) => { (o as SignIn).HomeTenantName = n.GetStringValue(); } },
                {"incomingTokenType", (o,n) => { (o as SignIn).IncomingTokenType = n.GetEnumValue<IncomingTokenType>(); } },
                {"ipAddress", (o,n) => { (o as SignIn).IpAddress = n.GetStringValue(); } },
                {"ipAddressFromResourceProvider", (o,n) => { (o as SignIn).IpAddressFromResourceProvider = n.GetStringValue(); } },
                {"isInteractive", (o,n) => { (o as SignIn).IsInteractive = n.GetBoolValue(); } },
                {"isTenantRestricted", (o,n) => { (o as SignIn).IsTenantRestricted = n.GetBoolValue(); } },
                {"location", (o,n) => { (o as SignIn).Location = n.GetObjectValue<SignInLocation>(); } },
                {"mfaDetail", (o,n) => { (o as SignIn).MfaDetail = n.GetObjectValue<MfaDetail>(); } },
                {"networkLocationDetails", (o,n) => { (o as SignIn).NetworkLocationDetails = n.GetCollectionOfObjectValues<NetworkLocationDetail>().ToList(); } },
                {"originalRequestId", (o,n) => { (o as SignIn).OriginalRequestId = n.GetStringValue(); } },
                {"privateLinkDetails", (o,n) => { (o as SignIn).PrivateLinkDetails = n.GetObjectValue<PrivateLinkDetails>(); } },
                {"processingTimeInMilliseconds", (o,n) => { (o as SignIn).ProcessingTimeInMilliseconds = n.GetIntValue(); } },
                {"resourceDisplayName", (o,n) => { (o as SignIn).ResourceDisplayName = n.GetStringValue(); } },
                {"resourceId", (o,n) => { (o as SignIn).ResourceId = n.GetStringValue(); } },
                {"resourceServicePrincipalId", (o,n) => { (o as SignIn).ResourceServicePrincipalId = n.GetStringValue(); } },
                {"resourceTenantId", (o,n) => { (o as SignIn).ResourceTenantId = n.GetStringValue(); } },
                {"riskDetail", (o,n) => { (o as SignIn).RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventTypes_v2", (o,n) => { (o as SignIn).RiskEventTypes_v2 = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"riskLevelAggregated", (o,n) => { (o as SignIn).RiskLevelAggregated = n.GetEnumValue<RiskLevel>(); } },
                {"riskLevelDuringSignIn", (o,n) => { (o as SignIn).RiskLevelDuringSignIn = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", (o,n) => { (o as SignIn).RiskState = n.GetEnumValue<RiskState>(); } },
                {"servicePrincipalCredentialKeyId", (o,n) => { (o as SignIn).ServicePrincipalCredentialKeyId = n.GetStringValue(); } },
                {"servicePrincipalCredentialThumbprint", (o,n) => { (o as SignIn).ServicePrincipalCredentialThumbprint = n.GetStringValue(); } },
                {"servicePrincipalId", (o,n) => { (o as SignIn).ServicePrincipalId = n.GetStringValue(); } },
                {"servicePrincipalName", (o,n) => { (o as SignIn).ServicePrincipalName = n.GetStringValue(); } },
                {"sessionLifetimePolicies", (o,n) => { (o as SignIn).SessionLifetimePolicies = n.GetCollectionOfObjectValues<SessionLifetimePolicy>().ToList(); } },
                {"signInEventTypes", (o,n) => { (o as SignIn).SignInEventTypes = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"signInIdentifier", (o,n) => { (o as SignIn).SignInIdentifier = n.GetStringValue(); } },
                {"signInIdentifierType", (o,n) => { (o as SignIn).SignInIdentifierType = n.GetEnumValue<SignInIdentifierType>(); } },
                {"status", (o,n) => { (o as SignIn).Status = n.GetObjectValue<SignInStatus>(); } },
                {"tokenIssuerName", (o,n) => { (o as SignIn).TokenIssuerName = n.GetStringValue(); } },
                {"tokenIssuerType", (o,n) => { (o as SignIn).TokenIssuerType = n.GetEnumValue<TokenIssuerType>(); } },
                {"uniqueTokenIdentifier", (o,n) => { (o as SignIn).UniqueTokenIdentifier = n.GetStringValue(); } },
                {"userAgent", (o,n) => { (o as SignIn).UserAgent = n.GetStringValue(); } },
                {"userDisplayName", (o,n) => { (o as SignIn).UserDisplayName = n.GetStringValue(); } },
                {"userId", (o,n) => { (o as SignIn).UserId = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as SignIn).UserPrincipalName = n.GetStringValue(); } },
                {"userType", (o,n) => { (o as SignIn).UserType = n.GetEnumValue<SignInUserType>(); } },
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
            writer.WriteEnumValue<ConditionalAccessStatus>("conditionalAccessStatus", ConditionalAccessStatus);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteEnumValue<SignInAccessType>("crossTenantAccessType", CrossTenantAccessType);
            writer.WriteObjectValue<DeviceDetail>("deviceDetail", DeviceDetail);
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
            writer.WriteObjectValue<MfaDetail>("mfaDetail", MfaDetail);
            writer.WriteCollectionOfObjectValues<NetworkLocationDetail>("networkLocationDetails", NetworkLocationDetails);
            writer.WriteStringValue("originalRequestId", OriginalRequestId);
            writer.WriteObjectValue<PrivateLinkDetails>("privateLinkDetails", PrivateLinkDetails);
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
