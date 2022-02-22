using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AuthenticationStrength : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Identifier of the authentication strength.</summary>
        public string AuthenticationStrengthId { get; set; }
        /// <summary>The name of the authentication strength.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Instantiates a new authenticationStrength and sets the default values.
        /// </summary>
        public AuthenticationStrength() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"authenticationStrengthId", (o,n) => { (o as AuthenticationStrength).AuthenticationStrengthId = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AuthenticationStrength).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticationStrengthId", AuthenticationStrengthId);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
