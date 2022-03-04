using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class B2cAuthenticationMethodsPolicy : Entity, IParsable {
        /// <summary>The tenant admin can configure local accounts using email if the email and password authentication method is enabled.</summary>
        public bool? IsEmailPasswordAuthenticationEnabled { get; set; }
        /// <summary>The tenant admin can configure local accounts using phone number if the phone number and one-time password authentication method is enabled.</summary>
        public bool? IsPhoneOneTimePasswordAuthenticationEnabled { get; set; }
        /// <summary>The tenant admin can configure local accounts using username if the username and password authentication method is enabled.</summary>
        public bool? IsUserNameAuthenticationEnabled { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new B2cAuthenticationMethodsPolicy CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new B2cAuthenticationMethodsPolicy();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"isEmailPasswordAuthenticationEnabled", (o,n) => { (o as B2cAuthenticationMethodsPolicy).IsEmailPasswordAuthenticationEnabled = n.GetBoolValue(); } },
                {"isPhoneOneTimePasswordAuthenticationEnabled", (o,n) => { (o as B2cAuthenticationMethodsPolicy).IsPhoneOneTimePasswordAuthenticationEnabled = n.GetBoolValue(); } },
                {"isUserNameAuthenticationEnabled", (o,n) => { (o as B2cAuthenticationMethodsPolicy).IsUserNameAuthenticationEnabled = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("isEmailPasswordAuthenticationEnabled", IsEmailPasswordAuthenticationEnabled);
            writer.WriteBoolValue("isPhoneOneTimePasswordAuthenticationEnabled", IsPhoneOneTimePasswordAuthenticationEnabled);
            writer.WriteBoolValue("isUserNameAuthenticationEnabled", IsUserNameAuthenticationEnabled);
        }
    }
}
