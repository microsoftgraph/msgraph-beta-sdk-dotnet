using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class AuthenticationContext : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Describes how the conditional access authentication context was triggered. A value of previouslySatisfied means the auth context was because the user already satisfied the requirements for that authentication context in some previous authentication event. A value of required means the user had to meet the authentication context requirement as part of the sign-in flow. The possible values are: required, previouslySatisfied, notApplicable, unknownFutureValue.</summary>
        public AuthenticationContextDetail? Detail { get; set; }
        /// <summary>The identifier of a authentication context in your tenant.</summary>
        public string Id { get; set; }
        /// <summary>
        /// Instantiates a new authenticationContext and sets the default values.
        /// </summary>
        public AuthenticationContext() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static AuthenticationContext CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationContext();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"detail", (o,n) => { (o as AuthenticationContext).Detail = n.GetEnumValue<AuthenticationContextDetail>(); } },
                {"id", (o,n) => { (o as AuthenticationContext).Id = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteEnumValue<AuthenticationContextDetail>("detail", Detail);
            writer.WriteStringValue("id", Id);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
