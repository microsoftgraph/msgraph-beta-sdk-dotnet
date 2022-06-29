using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ChannelAddedEventMessageDetail : EventMessageDetail, IParsable {
        /// <summary>Display name of the channel.</summary>
        public string ChannelDisplayName {
            get { return BackingStore?.Get<string>(nameof(ChannelDisplayName)); }
            set { BackingStore?.Set(nameof(ChannelDisplayName), value); }
        }
        /// <summary>Unique identifier of the channel.</summary>
        public string ChannelId {
            get { return BackingStore?.Get<string>(nameof(ChannelId)); }
            set { BackingStore?.Set(nameof(ChannelId), value); }
        }
        /// <summary>Initiator of the event.</summary>
        public IdentitySet Initiator {
            get { return BackingStore?.Get<IdentitySet>(nameof(Initiator)); }
            set { BackingStore?.Set(nameof(Initiator), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ChannelAddedEventMessageDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ChannelAddedEventMessageDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"channelDisplayName", n => { ChannelDisplayName = n.GetStringValue(); } },
                {"channelId", n => { ChannelId = n.GetStringValue(); } },
                {"initiator", n => { Initiator = n.GetObjectValue<IdentitySet>(IdentitySet.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("channelDisplayName", ChannelDisplayName);
            writer.WriteStringValue("channelId", ChannelId);
            writer.WriteObjectValue<IdentitySet>("initiator", Initiator);
        }
    }
}
