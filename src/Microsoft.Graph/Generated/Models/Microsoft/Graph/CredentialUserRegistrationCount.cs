using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class CredentialUserRegistrationCount : Entity, IParsable {
        /// <summary>Provides the total user count in the tenant.</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>A collection of registration count and status information for users in your tenant.</summary>
        public List<UserRegistrationCount> UserRegistrationCounts { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"totalUserCount", (o,n) => { (o as CredentialUserRegistrationCount).TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationCounts", (o,n) => { (o as CredentialUserRegistrationCount).UserRegistrationCounts = n.GetCollectionOfObjectValues<UserRegistrationCount>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteLongValue("totalUserCount", TotalUserCount);
            writer.WriteCollectionOfObjectValues<UserRegistrationCount>("userRegistrationCounts", UserRegistrationCounts);
        }
    }
}
