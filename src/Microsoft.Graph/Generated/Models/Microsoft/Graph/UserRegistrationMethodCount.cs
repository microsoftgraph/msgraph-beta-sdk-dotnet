using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class UserRegistrationMethodCount : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Name of authentication method.</summary>
        public string AuthenticationMethod { get; set; }
        /// <summary>Number of users registered.</summary>
        public long? UserCount { get; set; }
        /// <summary>
        /// Instantiates a new userRegistrationMethodCount and sets the default values.
        /// </summary>
        public UserRegistrationMethodCount() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"authenticationMethod", (o,n) => { (o as UserRegistrationMethodCount).AuthenticationMethod = n.GetStringValue(); } },
                {"userCount", (o,n) => { (o as UserRegistrationMethodCount).UserCount = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("authenticationMethod", AuthenticationMethod);
            writer.WriteLongValue("userCount", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
