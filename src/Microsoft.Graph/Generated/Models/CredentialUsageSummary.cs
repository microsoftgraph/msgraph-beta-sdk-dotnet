using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to call the getCredentialUsageSummary method.</summary>
    public class CredentialUsageSummary : Entity, IParsable {
        /// <summary>Represents the authentication method that the user used. Possible values are:email, mobileSMS, mobileCall, officePhone, securityQuestion (only used for self-service password reset), appNotification, appCode, alternateMobileCall (supported only in registration), fido, appPassword, unknownFutureValue.</summary>
        public UsageAuthMethod? AuthMethod {
            get { return BackingStore?.Get<UsageAuthMethod?>(nameof(AuthMethod)); }
            set { BackingStore?.Set(nameof(AuthMethod), value); }
        }
        /// <summary>Provides the count of failed resets or registration data.</summary>
        public long? FailureActivityCount {
            get { return BackingStore?.Get<long?>(nameof(FailureActivityCount)); }
            set { BackingStore?.Set(nameof(FailureActivityCount), value); }
        }
        /// <summary>Defines the feature to report. Possible values are: registration, reset, unknownFutureValue.</summary>
        public FeatureType? Feature {
            get { return BackingStore?.Get<FeatureType?>(nameof(Feature)); }
            set { BackingStore?.Set(nameof(Feature), value); }
        }
        /// <summary>Provides the count of successful registrations or resets.</summary>
        public long? SuccessfulActivityCount {
            get { return BackingStore?.Get<long?>(nameof(SuccessfulActivityCount)); }
            set { BackingStore?.Set(nameof(SuccessfulActivityCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CredentialUsageSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUsageSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"authMethod", n => { AuthMethod = n.GetEnumValue<UsageAuthMethod>(); } },
                {"failureActivityCount", n => { FailureActivityCount = n.GetLongValue(); } },
                {"feature", n => { Feature = n.GetEnumValue<FeatureType>(); } },
                {"successfulActivityCount", n => { SuccessfulActivityCount = n.GetLongValue(); } },
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
