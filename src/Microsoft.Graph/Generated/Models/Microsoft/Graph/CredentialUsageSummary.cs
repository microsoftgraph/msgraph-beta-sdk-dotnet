using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CredentialUsageSummary : Entity, IParsable {
        /// <summary>Represents the authentication method that the user used. Possible values are:email, mobileSMS, mobileCall, officePhone, securityQuestion (only used for self-service password reset), appNotification, appCode, alternateMobileCall (supported only in registration), fido, appPassword, unknownFutureValue.</summary>
        public UsageAuthMethod? AuthMethod { get; set; }
        /// <summary>Provides the count of failed resets or registration data.</summary>
        public long? FailureActivityCount { get; set; }
        /// <summary>Defines the feature to report. Possible values are: registration, reset, unknownFutureValue.</summary>
        public FeatureType? Feature { get; set; }
        /// <summary>Provides the count of successful registrations or resets.</summary>
        public long? SuccessfulActivityCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"authMethod", (o,n) => { (o as CredentialUsageSummary).AuthMethod = n.GetEnumValue<UsageAuthMethod>(); } },
                {"failureActivityCount", (o,n) => { (o as CredentialUsageSummary).FailureActivityCount = n.GetLongValue(); } },
                {"feature", (o,n) => { (o as CredentialUsageSummary).Feature = n.GetEnumValue<FeatureType>(); } },
                {"successfulActivityCount", (o,n) => { (o as CredentialUsageSummary).SuccessfulActivityCount = n.GetLongValue(); } },
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
            writer.WriteLongValue("failureActivityCount", FailureActivityCount);
            writer.WriteEnumValue<FeatureType>("feature", Feature);
            writer.WriteLongValue("successfulActivityCount", SuccessfulActivityCount);
        }
    }
}
