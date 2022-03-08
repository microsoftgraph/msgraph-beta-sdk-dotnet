using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the compliance singleton.</summary>
    public class PasswordlessMicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod, IParsable {
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The timestamp when this method was registered to the user.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        public MicrosoftGraphSdk.Models.Microsoft.Graph.Device Device { get; set; }
        /// <summary>The display name of the mobile device as given by the user.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PasswordlessMicrosoftAuthenticatorAuthenticationMethod CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PasswordlessMicrosoftAuthenticatorAuthenticationMethod();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationDateTime", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).Device = n.GetObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Device>(MicrosoftGraphSdk.Models.Microsoft.Graph.Device.CreateFromDiscriminatorValue); } },
                {"displayName", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).DisplayName = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("createdDateTime", CreatedDateTime);
            writer.WriteDateTimeOffsetValue("creationDateTime", CreationDateTime);
            writer.WriteObjectValue<MicrosoftGraphSdk.Models.Microsoft.Graph.Device>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
