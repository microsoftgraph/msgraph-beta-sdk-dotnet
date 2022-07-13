using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class RelyingPartyDetailedSummary : Entity, IParsable {
        /// <summary>Number of failed sign in on Active Directory Federation Service in the period specified.</summary>
        public long? FailedSignInCount {
            get { return BackingStore?.Get<long?>("failedSignInCount"); }
            set { BackingStore?.Set("failedSignInCount", value); }
        }
        /// <summary>The migrationStatus property</summary>
        public Microsoft.Graph.Beta.Models.MigrationStatus? MigrationStatus {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.MigrationStatus?>("migrationStatus"); }
            set { BackingStore?.Set("migrationStatus", value); }
        }
        /// <summary>Specifies all the validations check done on applications configuration details to evaluate if the application is ready to be moved to Azure AD.</summary>
        public List<KeyValuePair> MigrationValidationDetails {
            get { return BackingStore?.Get<List<KeyValuePair>>("migrationValidationDetails"); }
            set { BackingStore?.Set("migrationValidationDetails", value); }
        }
        /// <summary>This identifier is used to identify the relying party to this Federation Service. It is used when issuing claims to the relying party.</summary>
        public string RelyingPartyId {
            get { return BackingStore?.Get<string>("relyingPartyId"); }
            set { BackingStore?.Set("relyingPartyId", value); }
        }
        /// <summary>Name of application or other entity on the internet that uses an identity provider to authenticate a user who wants to log in.</summary>
        public string RelyingPartyName {
            get { return BackingStore?.Get<string>("relyingPartyName"); }
            set { BackingStore?.Set("relyingPartyName", value); }
        }
        /// <summary>Specifies where the relying party expects to receive the token.</summary>
        public List<string> ReplyUrls {
            get { return BackingStore?.Get<List<string>>("replyUrls"); }
            set { BackingStore?.Set("replyUrls", value); }
        }
        /// <summary>Uniquely identifies the Active Directory forest.</summary>
        public string ServiceId {
            get { return BackingStore?.Get<string>("serviceId"); }
            set { BackingStore?.Set("serviceId", value); }
        }
        /// <summary>Number of successful / (number of successful + number of failed sign ins) on Active Directory Federation Service in the period specified.</summary>
        public double? SignInSuccessRate {
            get { return BackingStore?.Get<double?>("signInSuccessRate"); }
            set { BackingStore?.Set("signInSuccessRate", value); }
        }
        /// <summary>Number of successful sign ins on Active Directory Federation Service.</summary>
        public long? SuccessfulSignInCount {
            get { return BackingStore?.Get<long?>("successfulSignInCount"); }
            set { BackingStore?.Set("successfulSignInCount", value); }
        }
        /// <summary>Number of successful + failed sign ins failed sign ins on Active Directory Federation Service in the period specified.</summary>
        public long? TotalSignInCount {
            get { return BackingStore?.Get<long?>("totalSignInCount"); }
            set { BackingStore?.Set("totalSignInCount", value); }
        }
        /// <summary>Number of unique users that have signed into the application.</summary>
        public long? UniqueUserCount {
            get { return BackingStore?.Get<long?>("uniqueUserCount"); }
            set { BackingStore?.Set("uniqueUserCount", value); }
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
