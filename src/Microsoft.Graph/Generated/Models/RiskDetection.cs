using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the identityProtectionRoot singleton.</summary>
    public class RiskDetection : Entity, IParsable {
        /// <summary>Indicates the activity type the detected risk is linked to. The possible values are signin, user, unknownFutureValue.</summary>
        public ActivityType? Activity {
            get { return BackingStore?.Get<ActivityType?>(nameof(Activity)); }
            set { BackingStore?.Set(nameof(Activity), value); }
        }
        /// <summary>Date and time that the risky activity occurred. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? ActivityDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(ActivityDateTime)); }
            set { BackingStore?.Set(nameof(ActivityDateTime), value); }
        }
        /// <summary>Additional information associated with the risk detection in JSON format.</summary>
        public string AdditionalInfo {
            get { return BackingStore?.Get<string>(nameof(AdditionalInfo)); }
            set { BackingStore?.Set(nameof(AdditionalInfo), value); }
        }
        /// <summary>Correlation ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.</summary>
        public string CorrelationId {
            get { return BackingStore?.Get<string>(nameof(CorrelationId)); }
            set { BackingStore?.Set(nameof(CorrelationId), value); }
        }
        /// <summary>Date and time that the risk was detected. The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public DateTimeOffset? DetectedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(DetectedDateTime)); }
            set { BackingStore?.Set(nameof(DetectedDateTime), value); }
        }
        /// <summary>Timing of the detected risk (real-time/offline). The possible values are notDefined, realtime, nearRealtime, offline, unknownFutureValue.</summary>
        public RiskDetectionTimingType? DetectionTimingType {
            get { return BackingStore?.Get<RiskDetectionTimingType?>(nameof(DetectionTimingType)); }
            set { BackingStore?.Set(nameof(DetectionTimingType), value); }
        }
        /// <summary>Provides the IP address of the client from where the risk occurred.</summary>
        public string IpAddress {
            get { return BackingStore?.Get<string>(nameof(IpAddress)); }
            set { BackingStore?.Set(nameof(IpAddress), value); }
        }
        /// <summary>Date and time that the risk detection was last updated.</summary>
        public DateTimeOffset? LastUpdatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(LastUpdatedDateTime)); }
            set { BackingStore?.Set(nameof(LastUpdatedDateTime), value); }
        }
        /// <summary>Location of the sign-in.</summary>
        public SignInLocation Location {
            get { return BackingStore?.Get<SignInLocation>(nameof(Location)); }
            set { BackingStore?.Set(nameof(Location), value); }
        }
        /// <summary>Request ID of the sign-in associated with the risk detection. This property is null if the risk detection is not associated with a sign-in.</summary>
        public string RequestId {
            get { return BackingStore?.Get<string>(nameof(RequestId)); }
            set { BackingStore?.Set(nameof(RequestId), value); }
        }
        /// <summary>Details of the detected risk. The possible values are none, adminGeneratedTemporaryPassword, userPerformedSecuredPasswordChange, userPerformedSecuredPasswordReset, adminConfirmedSigninSafe, aiConfirmedSigninSafe, userPassedMFADrivenByRiskBasedPolicy, adminDismissedAllRiskForUser, adminConfirmedSigninCompromised, hidden, adminConfirmedUserCompromised, unknownFutureValue. Note: Details for this property are only available for Azure AD Premium P2 customers. P1 customers will be returned hidden.</summary>
        public Microsoft.Graph.Beta.Models.RiskDetail? RiskDetail {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskDetail?>(nameof(RiskDetail)); }
            set { BackingStore?.Set(nameof(RiskDetail), value); }
        }
        /// <summary>The type of risk event detected. The possible values are unlikelyTravel, anonymizedIPAddress, maliciousIPAddress, unfamiliarFeatures, malwareInfectedIPAddress, suspiciousIPAddress, leakedCredentials, investigationsThreatIntelligence, generic,adminConfirmedUserCompromised, mcasImpossibleTravel, mcasSuspiciousInboxManipulationRules, investigationsThreatIntelligenceSigninLinked, maliciousIPAddressValidCredentialsBlockedIP, and unknownFutureValue.  For more information about each value, see riskEventType values.</summary>
        public string RiskEventType {
            get { return BackingStore?.Get<string>(nameof(RiskEventType)); }
            set { BackingStore?.Set(nameof(RiskEventType), value); }
        }
        /// <summary>Level of the detected risk. The possible values are low, medium, high, hidden, none, unknownFutureValue. Note: Details for this property are only available for Azure AD Premium P2 customers. P1 customers will be returned hidden.</summary>
        public Microsoft.Graph.Beta.Models.RiskLevel? RiskLevel {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskLevel?>(nameof(RiskLevel)); }
            set { BackingStore?.Set(nameof(RiskLevel), value); }
        }
        /// <summary>The state of a detected risky user or sign-in. The possible values are none, confirmedSafe, remediated, dismissed, atRisk, confirmedCompromised, and unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.RiskState? RiskState {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskState?>(nameof(RiskState)); }
            set { BackingStore?.Set(nameof(RiskState), value); }
        }
        /// <summary>The riskType property</summary>
        public Microsoft.Graph.Beta.Models.RiskEventType? RiskType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.RiskEventType?>(nameof(RiskType)); }
            set { BackingStore?.Set(nameof(RiskType), value); }
        }
        /// <summary>Source of the risk detection. For example, activeDirectory.</summary>
        public string Source {
            get { return BackingStore?.Get<string>(nameof(Source)); }
            set { BackingStore?.Set(nameof(Source), value); }
        }
        /// <summary>Indicates the type of token issuer for the detected sign-in risk. The possible values are AzureAD, ADFederationServices, and unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.TokenIssuerType? TokenIssuerType {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.TokenIssuerType?>(nameof(TokenIssuerType)); }
            set { BackingStore?.Set(nameof(TokenIssuerType), value); }
        }
        /// <summary>Name of the user.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>Unique ID of the user.  The DateTimeOffset type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>The user principal name (UPN) of the user.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RiskDetection CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RiskDetection();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"activity", n => { Activity = n.GetEnumValue<ActivityType>(); } },
                {"activityDateTime", n => { ActivityDateTime = n.GetDateTimeOffsetValue(); } },
                {"additionalInfo", n => { AdditionalInfo = n.GetStringValue(); } },
                {"correlationId", n => { CorrelationId = n.GetStringValue(); } },
                {"detectedDateTime", n => { DetectedDateTime = n.GetDateTimeOffsetValue(); } },
                {"detectionTimingType", n => { DetectionTimingType = n.GetEnumValue<RiskDetectionTimingType>(); } },
                {"ipAddress", n => { IpAddress = n.GetStringValue(); } },
                {"lastUpdatedDateTime", n => { LastUpdatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"location", n => { Location = n.GetObjectValue<SignInLocation>(SignInLocation.CreateFromDiscriminatorValue); } },
                {"requestId", n => { RequestId = n.GetStringValue(); } },
                {"riskDetail", n => { RiskDetail = n.GetEnumValue<RiskDetail>(); } },
                {"riskEventType", n => { RiskEventType = n.GetStringValue(); } },
                {"riskLevel", n => { RiskLevel = n.GetEnumValue<RiskLevel>(); } },
                {"riskState", n => { RiskState = n.GetEnumValue<RiskState>(); } },
                {"riskType", n => { RiskType = n.GetEnumValue<RiskEventType>(); } },
                {"source", n => { Source = n.GetStringValue(); } },
                {"tokenIssuerType", n => { TokenIssuerType = n.GetEnumValue<TokenIssuerType>(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
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
            writer.WriteEnumValue<ActivityType>("activity", Activity);
            writer.WriteDateTimeOffsetValue("activityDateTime", ActivityDateTime);
            writer.WriteStringValue("additionalInfo", AdditionalInfo);
            writer.WriteStringValue("correlationId", CorrelationId);
            writer.WriteDateTimeOffsetValue("detectedDateTime", DetectedDateTime);
            writer.WriteEnumValue<RiskDetectionTimingType>("detectionTimingType", DetectionTimingType);
            writer.WriteStringValue("ipAddress", IpAddress);
            writer.WriteDateTimeOffsetValue("lastUpdatedDateTime", LastUpdatedDateTime);
            writer.WriteObjectValue<SignInLocation>("location", Location);
            writer.WriteStringValue("requestId", RequestId);
            writer.WriteEnumValue<RiskDetail>("riskDetail", RiskDetail);
            writer.WriteStringValue("riskEventType", RiskEventType);
            writer.WriteEnumValue<RiskLevel>("riskLevel", RiskLevel);
            writer.WriteEnumValue<RiskState>("riskState", RiskState);
            writer.WriteEnumValue<RiskEventType>("riskType", RiskType);
            writer.WriteStringValue("source", Source);
            writer.WriteEnumValue<TokenIssuerType>("tokenIssuerType", TokenIssuerType);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userId", UserId);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
