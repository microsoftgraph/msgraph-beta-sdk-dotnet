using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class ChatMessageMentionedIdentitySet : IdentitySet, IParsable {
        /// <summary>If present, represents a conversation (for example, team or channel) @mentioned in a message.</summary>
        public TeamworkConversationIdentity Conversation { get; set; }
        /// <summary>If present, represents a tag @mentioned in a team message.</summary>
        public TeamworkTagIdentity Tag { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"conversation", (o,n) => { (o as ChatMessageMentionedIdentitySet).Conversation = n.GetObjectValue<TeamworkConversationIdentity>(); } },
                {"tag", (o,n) => { (o as ChatMessageMentionedIdentitySet).Tag = n.GetObjectValue<TeamworkTagIdentity>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<TeamworkConversationIdentity>("conversation", Conversation);
            writer.WriteObjectValue<TeamworkTagIdentity>("tag", Tag);
        }
    }
}
