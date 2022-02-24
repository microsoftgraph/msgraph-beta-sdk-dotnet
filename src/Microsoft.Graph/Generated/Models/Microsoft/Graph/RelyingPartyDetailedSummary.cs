using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class RelyingPartyDetailedSummary : Entity, IParsable {
        /// <summary>Number of failed sign in on Active Directory Federation Service in the period specified.</summary>
        public long? FailedSignInCount { get; set; }
        /// <summary>Indication of whether the application can be moved to Azure AD or require more investigation. Possible values are: ready, needsReview, additionalStepsRequired, unknownFutureValue.</summary>
        public MigrationStatus? MigrationStatus { get; set; }
        /// <summary>Specifies all the validations check done on applications configuration details to evaluate if the application is ready to be moved to Azure AD.</summary>
        public List<KeyValuePair> MigrationValidationDetails { get; set; }
        /// <summary>This identifier is used to identify the relying party to this Federation Service. It is used when issuing claims to the relying party.</summary>
        public string RelyingPartyId { get; set; }
        /// <summary>Name of application or other entity on the internet that uses an identity provider to authenticate a user who wants to log in.</summary>
        public string RelyingPartyName { get; set; }
        /// <summary>Specifies where the relying party expects to receive the token.</summary>
        public List<string> ReplyUrls { get; set; }
        /// <summary>Uniquely identifies the Active Directory forest.</summary>
        public string ServiceId { get; set; }
        /// <summary>Number of successful / (number of successful + number of failed sign ins) on Active Directory Federation Service in the period specified.</summary>
        public double? SignInSuccessRate { get; set; }
        /// <summary>Number of successful sign ins on Active Directory Federation Service.</summary>
        public long? SuccessfulSignInCount { get; set; }
        /// <summary>Number of successful + failed sign ins failed sign ins on Active Directory Federation Service in the period specified.</summary>
        public long? TotalSignInCount { get; set; }
        /// <summary>Number of unique users that have signed into the application.</summary>
        public long? UniqueUserCount { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"failedSignInCount", (o,n) => { (o as RelyingPartyDetailedSummary).FailedSignInCount = n.GetLongValue(); } },
                {"migrationStatus", (o,n) => { (o as RelyingPartyDetailedSummary).MigrationStatus = n.GetEnumValue<MigrationStatus>(); } },
                {"migrationValidationDetails", (o,n) => { (o as RelyingPartyDetailedSummary).MigrationValidationDetails = n.GetCollectionOfObjectValues<KeyValuePair>().ToList(); } },
                {"relyingPartyId", (o,n) => { (o as RelyingPartyDetailedSummary).RelyingPartyId = n.GetStringValue(); } },
                {"relyingPartyName", (o,n) => { (o as RelyingPartyDetailedSummary).RelyingPartyName = n.GetStringValue(); } },
                {"replyUrls", (o,n) => { (o as RelyingPartyDetailedSummary).ReplyUrls = n.GetCollectionOfPrimitiveValues<string>().ToList(); } },
                {"serviceId", (o,n) => { (o as RelyingPartyDetailedSummary).ServiceId = n.GetStringValue(); } },
                {"signInSuccessRate", (o,n) => { (o as RelyingPartyDetailedSummary).SignInSuccessRate = n.GetDoubleValue(); } },
                {"successfulSignInCount", (o,n) => { (o as RelyingPartyDetailedSummary).SuccessfulSignInCount = n.GetLongValue(); } },
                {"totalSignInCount", (o,n) => { (o as RelyingPartyDetailedSummary).TotalSignInCount = n.GetLongValue(); } },
                {"uniqueUserCount", (o,n) => { (o as RelyingPartyDetailedSummary).UniqueUserCount = n.GetLongValue(); } },
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
