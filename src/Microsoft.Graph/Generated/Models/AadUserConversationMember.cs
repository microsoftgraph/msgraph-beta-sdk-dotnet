using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class AadUserConversationMember : ConversationMember, IParsable {
        /// <summary>The email address of the user.</summary>
        public string Email {
            get { return BackingStore?.Get<string>(nameof(Email)); }
            set { BackingStore?.Set(nameof(Email), value); }
        }
        /// <summary>TenantId which the Azure AD user belongs to.</summary>
        public string TenantId {
            get { return BackingStore?.Get<string>(nameof(TenantId)); }
            set { BackingStore?.Set(nameof(TenantId), value); }
        }
        /// <summary>The user property</summary>
        public Microsoft.Graph.Beta.Models.User User {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.User>(nameof(User)); }
            set { BackingStore?.Set(nameof(User), value); }
        }
        /// <summary>The GUID of the user.</summary>
        public string UserId {
            get { return BackingStore?.Get<string>(nameof(UserId)); }
            set { BackingStore?.Set(nameof(UserId), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AadUserConversationMember CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AadUserConversationMember();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"email", n => { Email = n.GetStringValue(); } },
                {"tenantId", n => { TenantId = n.GetStringValue(); } },
                {"user", n => { User = n.GetObjectValue<Microsoft.Graph.Beta.Models.User>(Microsoft.Graph.Beta.Models.User.CreateFromDiscriminatorValue); } },
                {"userId", n => { UserId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("email", Email);
            writer.WriteStringValue("tenantId", TenantId);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.User>("user", User);
            writer.WriteStringValue("userId", UserId);
        }
    }
}
