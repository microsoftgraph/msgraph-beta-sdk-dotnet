using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityContainer singleton.</summary>
    public class AuthenticationContextClassReference : Entity, IParsable {
        /// <summary>A short explanation of the policies that are enforced by authenticationContextClassReference. This value should be used to provide secondary text to describe the authentication context class reference when building user facing admin experiences. For example, selection UX.</summary>
        public string Description { get; set; }
        /// <summary>The display name is the friendly name of the authenticationContextClassReference. This value should be used to identify the authentication context class reference when building user facing admin experiences. For example, selection UX.</summary>
        public string DisplayName { get; set; }
        /// <summary>Indicates whether the authenticationContextClassReference has been published by the security admin and is ready for use by apps. When it is set to false it should not be shown in admin UX experiences because the value is not currently available for selection.</summary>
        public bool? IsAvailable { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AuthenticationContextClassReference CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AuthenticationContextClassReference();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"description", (o,n) => { (o as AuthenticationContextClassReference).Description = n.GetStringValue(); } },
                {"displayName", (o,n) => { (o as AuthenticationContextClassReference).DisplayName = n.GetStringValue(); } },
                {"isAvailable", (o,n) => { (o as AuthenticationContextClassReference).IsAvailable = n.GetBoolValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("description", Description);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteBoolValue("isAvailable", IsAvailable);
        }
    }
}
