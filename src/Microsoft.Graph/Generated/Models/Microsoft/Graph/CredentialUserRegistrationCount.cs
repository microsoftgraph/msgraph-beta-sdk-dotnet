using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class CredentialUserRegistrationCount : Entity, IParsable {
        /// <summary>Provides the total user count in the tenant.</summary>
        public long? TotalUserCount { get; set; }
        /// <summary>A collection of registration count and status information for users in your tenant.</summary>
        public List<UserRegistrationCount> UserRegistrationCounts { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new CredentialUserRegistrationCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new CredentialUserRegistrationCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"totalUserCount", (o,n) => { (o as CredentialUserRegistrationCount).TotalUserCount = n.GetLongValue(); } },
                {"userRegistrationCounts", (o,n) => { (o as CredentialUserRegistrationCount).UserRegistrationCounts = n.GetCollectionOfObjectValues<UserRegistrationCount>(UserRegistrationCount.CreateFromDiscriminatorValue).ToList(); } },
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
