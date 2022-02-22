using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AuthenticationMethodsRoot : Entity, IParsable {
        /// <summary>Represents the state of a user's authentication methods, including which methods are registered and which features the user is registered and capable of (such as multi-factor authentication, self-service password reset, and passwordless authentication).</summary>
        public List<MicrosoftGraph.Models.Microsoft.Graph.UserRegistrationDetails> UserRegistrationDetails { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"userRegistrationDetails", (o,n) => { (o as AuthenticationMethodsRoot).UserRegistrationDetails = n.GetCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.UserRegistrationDetails>().ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<MicrosoftGraph.Models.Microsoft.Graph.UserRegistrationDetails>("userRegistrationDetails", UserRegistrationDetails);
        }
    }
}
