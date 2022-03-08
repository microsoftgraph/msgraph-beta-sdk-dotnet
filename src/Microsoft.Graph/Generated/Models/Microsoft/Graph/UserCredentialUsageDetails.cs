using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the print singleton.</summary>
    public class UserCredentialUsageDetails : Entity, IParsable {
        /// <summary>Represents the authentication method that the user used. Possible values are:email, mobileSMS, mobileCall, officePhone, securityQuestion (only used for self-service password reset), appNotification, appCode, alternateMobileCall (supported only in registration), fido, appPassword,unknownFutureValue</summary>
        public UsageAuthMethod? AuthMethod { get; set; }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EventDateTime { get; set; }
        /// <summary>Provides the failure reason for the corresponding reset or registration workflow.</summary>
        public string FailureReason { get; set; }
        /// <summary>Possible values are: registration, reset, unknownFutureValue.</summary>
        public FeatureType? Feature { get; set; }
        /// <summary>Indicates success or failure of the workflow.</summary>
        public bool? IsSuccess { get; set; }
        /// <summary>User name of the user performing the reset or registration workflow.</summary>
        public string UserDisplayName { get; set; }
        /// <summary>User principal name of the user performing the reset or registration workflow.</summary>
        public string UserPrincipalName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new UserCredentialUsageDetails CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserCredentialUsageDetails();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authMethod", (o,n) => { (o as UserCredentialUsageDetails).AuthMethod = n.GetEnumValue<UsageAuthMethod>(); } },
                {"eventDateTime", (o,n) => { (o as UserCredentialUsageDetails).EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureReason", (o,n) => { (o as UserCredentialUsageDetails).FailureReason = n.GetStringValue(); } },
                {"feature", (o,n) => { (o as UserCredentialUsageDetails).Feature = n.GetEnumValue<FeatureType>(); } },
                {"isSuccess", (o,n) => { (o as UserCredentialUsageDetails).IsSuccess = n.GetBoolValue(); } },
                {"userDisplayName", (o,n) => { (o as UserCredentialUsageDetails).UserDisplayName = n.GetStringValue(); } },
                {"userPrincipalName", (o,n) => { (o as UserCredentialUsageDetails).UserPrincipalName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<UsageAuthMethod>("authMethod", AuthMethod);
            writer.WriteDateTimeOffsetValue("eventDateTime", EventDateTime);
            writer.WriteStringValue("failureReason", FailureReason);
            writer.WriteEnumValue<FeatureType>("feature", Feature);
            writer.WriteBoolValue("isSuccess", IsSuccess);
            writer.WriteStringValue("userDisplayName", UserDisplayName);
            writer.WriteStringValue("userPrincipalName", UserPrincipalName);
        }
    }
}
