using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class SharedEmailDomainInvitation : Entity, IParsable {
        /// <summary>The expiryTime property</summary>
        public DateTimeOffset? ExpiryTime { get; set; }
        /// <summary>The invitationDomain property</summary>
        public string InvitationDomain { get; set; }
        /// <summary>The invitationStatus property</summary>
        public string InvitationStatus { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new SharedEmailDomainInvitation CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new SharedEmailDomainInvitation();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"expiryTime", n => { ExpiryTime = n.GetDateTimeOffsetValue(); } },
                {"invitationDomain", n => { InvitationDomain = n.GetStringValue(); } },
                {"invitationStatus", n => { InvitationStatus = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("expiryTime", ExpiryTime);
            writer.WriteStringValue("invitationDomain", InvitationDomain);
            writer.WriteStringValue("invitationStatus", InvitationStatus);
        }
    }
}
