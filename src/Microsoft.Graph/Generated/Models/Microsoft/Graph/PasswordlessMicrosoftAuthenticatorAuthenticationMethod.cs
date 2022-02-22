using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class PasswordlessMicrosoftAuthenticatorAuthenticationMethod : AuthenticationMethod, IParsable {
        public DateTimeOffset? CreatedDateTime { get; set; }
        /// <summary>The timestamp when this method was registered to the user.</summary>
        public DateTimeOffset? CreationDateTime { get; set; }
        public MicrosoftGraph.Models.Microsoft.Graph.Device Device { get; set; }
        /// <summary>The display name of the mobile device as given by the user.</summary>
        public string DisplayName { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"createdDateTime", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).CreatedDateTime = n.GetDateTimeOffsetValue(); } },
                {"creationDateTime", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).CreationDateTime = n.GetDateTimeOffsetValue(); } },
                {"device", (o,n) => { (o as PasswordlessMicrosoftAuthenticatorAuthenticationMethod).Device = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Device>(); } },
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
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.Device>("device", Device);
            writer.WriteStringValue("displayName", DisplayName);
        }
    }
}
