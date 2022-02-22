using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class ChatViewpoint : IParsable {
        /// <summary>Stores additional data not described in the OpenAPI description found when deserializing. Can be used for serialization as well.</summary>
        public IDictionary<string, object> AdditionalData { get; set; }
        /// <summary>Indicates whether the chat is hidden for the current user.</summary>
        public bool? IsHidden { get; set; }
        /// <summary>Represents the dateTime up until which the current user has read chatMessages in a specific chat.</summary>
        public DateTimeOffset? LastMessageReadDateTime { get; set; }
        /// <summary>
        /// Instantiates a new chatViewpoint and sets the default values.
        /// </summary>
        public ChatViewpoint() {
            AdditionalData = new Dictionary<string, object>();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>> {
                {"isHidden", (o,n) => { (o as ChatViewpoint).IsHidden = n.GetBoolValue(); } },
                {"lastMessageReadDateTime", (o,n) => { (o as ChatViewpoint).LastMessageReadDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            writer.WriteBoolValue("isHidden", IsHidden);
            writer.WriteDateTimeOffsetValue("lastMessageReadDateTime", LastMessageReadDateTime);
            writer.WriteAdditionalData(AdditionalData);
        }
    }
}
