using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class UserRegistrationMethodSummary : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Total number of users in the tenant.</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>Number of users registered for each authentication method.</summary>
        public List<UserRegistrationMethodCount> UserRegistrationMethodCounts { get; set; }
        /// <summary>User role type. Possible values are: all, privilegedAdmin, admin, user.</summary>
        public IncludedUserRoles? UserRoles { get; set; }
        /// <summary>User type. Possible values are: all, member, guest.</summary>
        public IncludedUserTypes? UserTypes { get; set; }
        /// <summary>
        /// Instantiates a new UserRegistrationMethodSummary and sets the default values.
        /// </summary>
        public UserRegistrationMethodSummary() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"totalUserCount", (o,n) => { (o as UserRegistrationMethodSummary).TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationMethodCounts", (o,n) => { (o as UserRegistrationMethodSummary).UserRegistrationMethodCounts = n.GetCollectionOfObjectValues<UserRegistrationMethodCount>().ToList(); } },
                {"userRoles", (o,n) => { (o as UserRegistrationMethodSummary).UserRoles = n.GetEnumValue<IncludedUserRoles>(); } },
                {"userTypes", (o,n) => { (o as UserRegistrationMethodSummary).UserTypes = n.GetEnumValue<IncludedUserTypes>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationMethodCount>("userRegistrationMethodCounts", UserRegistrationMethodCounts);
            writer.WriteEnumValue<IncludedUserRoles>("userRoles", UserRoles);
            writer.WriteEnumValue<IncludedUserTypes>("userTypes", UserTypes);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
