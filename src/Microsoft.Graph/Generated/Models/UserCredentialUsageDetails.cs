using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the reportRoot singleton.</summary>
    public class UserCredentialUsageDetails : Entity, IParsable {
        /// <summary>Represents the authentication method that the user used. Possible values are:email, mobileSMS, mobileCall, officePhone, securityQuestion (only used for self-service password reset), appNotification, appCode, alternateMobileCall (supported only in registration), fido, appPassword,unknownFutureValue</summary>
        public UsageAuthMethod? AuthMethod {
            get { return BackingStore?.Get<UsageAuthMethod?>(nameof(AuthMethod)); }
            set { BackingStore?.Set(nameof(AuthMethod), value); }
        }
        /// <summary>The Timestamp type represents date and time information using ISO 8601 format and is always in UTC time. For example, midnight UTC on Jan 1, 2014 is 2014-01-01T00:00:00Z.</summary>
        public DateTimeOffset? EventDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>(nameof(EventDateTime)); }
            set { BackingStore?.Set(nameof(EventDateTime), value); }
        }
        /// <summary>Provides the failure reason for the corresponding reset or registration workflow.</summary>
        public string FailureReason {
            get { return BackingStore?.Get<string>(nameof(FailureReason)); }
            set { BackingStore?.Set(nameof(FailureReason), value); }
        }
        /// <summary>Possible values are: registration, reset, unknownFutureValue.</summary>
        public FeatureType? Feature {
            get { return BackingStore?.Get<FeatureType?>(nameof(Feature)); }
            set { BackingStore?.Set(nameof(Feature), value); }
        }
        /// <summary>Indicates success or failure of the workflow.</summary>
        public bool? IsSuccess {
            get { return BackingStore?.Get<bool?>(nameof(IsSuccess)); }
            set { BackingStore?.Set(nameof(IsSuccess), value); }
        }
        /// <summary>User name of the user performing the reset or registration workflow.</summary>
        public string UserDisplayName {
            get { return BackingStore?.Get<string>(nameof(UserDisplayName)); }
            set { BackingStore?.Set(nameof(UserDisplayName), value); }
        }
        /// <summary>User principal name of the user performing the reset or registration workflow.</summary>
        public string UserPrincipalName {
            get { return BackingStore?.Get<string>(nameof(UserPrincipalName)); }
            set { BackingStore?.Set(nameof(UserPrincipalName), value); }
        }
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
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authMethod", n => { AuthMethod = n.GetEnumValue<UsageAuthMethod>(); } },
                {"eventDateTime", n => { EventDateTime = n.GetDateTimeOffsetValue(); } },
                {"failureReason", n => { FailureReason = n.GetStringValue(); } },
                {"feature", n => { Feature = n.GetEnumValue<FeatureType>(); } },
                {"isSuccess", n => { IsSuccess = n.GetBoolValue(); } },
                {"userDisplayName", n => { UserDisplayName = n.GetStringValue(); } },
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
