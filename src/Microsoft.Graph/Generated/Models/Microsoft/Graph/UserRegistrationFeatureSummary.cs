using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserRegistrationFeatureSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total number of users accounts, excluding those that are blocked</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>Number of users registered or capable for Multi-Factor Authentication, Self-Service Password Reset and Passwordless Authentication.</summary>
        public List<UserRegistrationFeatureCount> UserRegistrationFeatureCounts { get; set; }
        /// <summary>User role type. Possible values are: all, privilegedAdmin, admin, user.</summary>
        public IncludedUserRoles? UserRoles { get; set; }
        /// <summary>User type. Possible values are: all, member, guest.</summary>
        public IncludedUserTypes? UserTypes { get; set; }
        /// <summary>
        /// Instantiates a new UserRegistrationFeatureSummary and sets the default values.
        /// </summary>
        public UserRegistrationFeatureSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"totalUserCount", (o,n) => { (o as UserRegistrationFeatureSummary).TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationFeatureCounts", (o,n) => { (o as UserRegistrationFeatureSummary).UserRegistrationFeatureCounts = n.GetCollectionOfObjectValues<UserRegistrationFeatureCount>().ToList(); } },
                {"userRoles", (o,n) => { (o as UserRegistrationFeatureSummary).UserRoles = n.GetEnumValue<IncludedUserRoles>(); } },
                {"userTypes", (o,n) => { (o as UserRegistrationFeatureSummary).UserTypes = n.GetEnumValue<IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationFeatureCount>("userRegistrationFeatureCounts", UserRegistrationFeatureCounts);
            writer.WriteEnumValue<IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
