using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class UserRegistrationMethodCount : IAdditionalDataHolder, IParsable {
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
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserRegistrationMethodCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationMethodCount();
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
