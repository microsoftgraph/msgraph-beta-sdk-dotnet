using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to call the usersRegisteredByFeature method.</summary>
    public class UserRegistrationFeatureCount : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Number of users registered or capable for Multi-Factor Authentication, Self-Service Password Reset and Passwordless Authentication. Possible values are: ssprRegistered, ssprEnabled, ssprCapable, passwordlessCapable, mfaCapable.</summary>
        public AuthenticationMethodFeature? Feature { get; set; }
        /// <summary>Number of users.</summary>
        public int? UserCount { get; set; }
        /// <summary>
        /// Instantiates a new userRegistrationFeatureCount and sets the default values.
        /// </summary>
        public UserRegistrationFeatureCount() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static UserRegistrationFeatureCount CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new UserRegistrationFeatureCount();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"feature", (o,n) => { (o as UserRegistrationFeatureCount).Feature = n.GetEnumValue<AuthenticationMethodFeature>(); } },
                {"userCount", (o,n) => { (o as UserRegistrationFeatureCount).UserCount = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthenticationMethodFeature>("feature", Feature);
            writer.WriteIntValue("userCount", UserCount);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
