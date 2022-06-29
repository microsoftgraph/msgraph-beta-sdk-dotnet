using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RelyingPartyDetailedSummary : Entity, IParsable {
        /// <summary>Number of failed sign in on Active Directory Federation Service in the period specified.</summary>
        public long? FailedSignInCount {
            get { return BackingStore?.Get<long?>(nameof(FailedSignInCount)); }
            set { BackingStore?.Set(nameof(FailedSignInCount), value); }
        }
        /// <summary>Indication of whether the application can be moved to Azure AD or require more investigation. Possible values are: ready, needsReview, additionalStepsRequired, unknownFutureValue.</summary>
        public Microsoft.Graph.Beta.Models.MigrationStatus? MigrationStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MigrationStatus?>(nameof(MigrationStatus)); }
            set { BackingStore?.Set(nameof(MigrationStatus), value); }
        }
        /// <summary>Specifies all the validations check done on applications configuration details to evaluate if the application is ready to be moved to Azure AD.</summary>
        public List<KeyValuePair> MigrationValidationDetails {
            get { return BackingStore?.Get<List<KeyValuePair>>(nameof(MigrationValidationDetails)); }
            set { BackingStore?.Set(nameof(MigrationValidationDetails), value); }
        }
        /// <summary>This identifier is used to identify the relying party to this Federation Service. It is used when issuing claims to the relying party.</summary>
        public string RelyingPartyId {
            get { return BackingStore?.Get<string>(nameof(RelyingPartyId)); }
            set { BackingStore?.Set(nameof(RelyingPartyId), value); }
        }
        /// <summary>Name of application or other entity on the internet that uses an identity provider to authenticate a user who wants to log in.</summary>
        public string RelyingPartyName {
            get { return BackingStore?.Get<string>(nameof(RelyingPartyName)); }
            set { BackingStore?.Set(nameof(RelyingPartyName), value); }
        }
        /// <summary>Specifies where the relying party expects to receive the token.</summary>
        public List<string> ReplyUrls {
            get { return BackingStore?.Get<List<string>>(nameof(ReplyUrls)); }
            set { BackingStore?.Set(nameof(ReplyUrls), value); }
        }
        /// <summary>Uniquely identifies the Active Directory forest.</summary>
        public string ServiceId {
            get { return BackingStore?.Get<string>(nameof(ServiceId)); }
            set { BackingStore?.Set(nameof(ServiceId), value); }
        }
        /// <summary>Number of successful / (number of successful + number of failed sign ins) on Active Directory Federation Service in the period specified.</summary>
        public double? SignInSuccessRate {
            get { return BackingStore?.Get<double?>(nameof(SignInSuccessRate)); }
            set { BackingStore?.Set(nameof(SignInSuccessRate), value); }
        }
        /// <summary>Number of successful sign ins on Active Directory Federation Service.</summary>
        public long? SuccessfulSignInCount {
            get { return BackingStore?.Get<long?>(nameof(SuccessfulSignInCount)); }
            set { BackingStore?.Set(nameof(SuccessfulSignInCount), value); }
        }
        /// <summary>Number of successful + failed sign ins failed sign ins on Active Directory Federation Service in the period specified.</summary>
        public long? TotalSignInCount {
            get { return BackingStore?.Get<long?>(nameof(TotalSignInCount)); }
            set { BackingStore?.Set(nameof(TotalSignInCount), value); }
        }
        /// <summary>Number of unique users that have signed into the application.</summary>
        public long? UniqueUserCount {
            get { return BackingStore?.Get<long?>(nameof(UniqueUserCount)); }
            set { BackingStore?.Set(nameof(UniqueUserCount), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RelyingPartyDetailedSummary CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RelyingPartyDetailedSummary();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"failedSignInCount", n => { FailedSignInCount = n.GetLongValue(); } },
                {"migrationStatus", n => { MigrationStatus = n.GetEnumValue<MigrationStatus>(); } },
                {"migrationValidationDetails", n => { MigrationValidationDetails = n.GetCollectionOfObjectValues<KeyValuePair>(KeyValuePair.CreateFromDiscriminatorValue).ToList(); } },
                {"relyingPartyId", n => { RelyingPartyId = n.GetStringValue(); } },
                {"relyingPartyName", n => { RelyingPartyName = n.GetStringValue(); } },
                {"replyUrls", n => { ReplyUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"serviceId", n => { ServiceId = n.GetStringValue(); } },
                {"signInSuccessRate", n => { SignInSuccessRate = n.GetDoubleValue(); } },
                {"successfulSignInCount", n => { SuccessfulSignInCount = n.GetLongValue(); } },
                {"totalSignInCount", n => { TotalSignInCount = n.GetLongValue(); } },
                {"uniqueUserCount", n => { UniqueUserCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("failedSignInCount", FailedSignInCount);
            writer.WriteEnumValue<MigrationStatus>("migrationStatus", MigrationStatus);
            writer.WriteCollectionOfObjectValues<KeyValuePair>("migrationValidationDetails", MigrationValidationDetails);
            writer.WriteStringValue("relyingPartyId", RelyingPartyId);
            writer.WriteStringValue("relyingPartyName", RelyingPartyName);
            writer.WriteCollectionOfPrimitiveValues<string>("replyUrls", ReplyUrls);
            writer.WriteStringValue("serviceId", ServiceId);
            writer.WriteDoubleValue("signInSuccessRate", SignInSuccessRate);
            writer.WriteLongValue("successfulSignInCount", SuccessfulSignInCount);
            writer.WriteLongValue("totalSignInCount", TotalSignInCount);
            writer.WriteLongValue("uniqueUserCount", UniqueUserCount);
        }
    }
}
