using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Users.Item.Authentication.Methods.Item.ResetPassword {
    /// <summary>Provides operations to call the resetPassword method.</summary>
    public class ResetPasswordRequestBody : IAdditionalDataHolder, IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>The newPassword property</summary>
        public string NewPassword { get; set; }
        /// <summary>The requireChangeOnNextSignIn property</summary>
        public bool? RequireChangeOnNextSignIn { get; set; }
        /// <summary>
        /// Instantiates a new resetPasswordRequestBody and sets the default values.
        /// </summary>
        public ResetPasswordRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static ResetPasswordRequestBody CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ResetPasswordRequestBody();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>> {
                {"newPassword", n => { NewPassword = n.GetStringValue(); } },
                {"requireChangeOnNextSignIn", n => { RequireChangeOnNextSignIn = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteStringValue("newPassword", NewPassword);
            writer.WriteBoolValue("requireChangeOnNextSignIn", RequireChangeOnNextSignIn);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
