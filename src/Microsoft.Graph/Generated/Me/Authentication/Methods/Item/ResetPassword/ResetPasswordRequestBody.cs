using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Me.Authentication.Methods.Item.ResetPassword {
    public class ResetPasswordRequestBody : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        public string NewPassword { get; set; }
        public bool? RequireChangeOnNextSignIn { get; set; }
        /// <summary>
        /// Instantiates a new resetPasswordRequestBody and sets the default values.
        /// </summary>
        public ResetPasswordRequestBody() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"newPassword", (o,n) => { (o as ResetPasswordRequestBody).NewPassword = n.GetStringValue(); } },
                {"requireChangeOnNextSignIn", (o,n) => { (o as ResetPasswordRequestBody).RequireChangeOnNextSignIn = n.GetBoolValue(); } },
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
