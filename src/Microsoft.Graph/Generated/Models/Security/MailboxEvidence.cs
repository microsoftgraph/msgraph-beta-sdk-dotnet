using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class MailboxEvidence : AlertEvidence, IParsable {
        /// <summary>The name associated with the mailbox.</summary>
        public string DisplayName {
            get { return BackingStore?.Get<string>("displayName"); }
            set { BackingStore?.Set("displayName", value); }
        }
        /// <summary>The primary email address of the mailbox.</summary>
        public string PrimaryAddress {
            get { return BackingStore?.Get<string>("primaryAddress"); }
            set { BackingStore?.Set("primaryAddress", value); }
        }
        /// <summary>The user account of the mailbox.</summary>
        public Microsoft.Graph.Beta.Models.Security.UserAccount UserAccount {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.Security.UserAccount>("userAccount"); }
            set { BackingStore?.Set("userAccount", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new MailboxEvidence CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new MailboxEvidence();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"displayName", n => { DisplayName = n.GetStringValue(); } },
                {"primaryAddress", n => { PrimaryAddress = n.GetStringValue(); } },
                {"userAccount", n => { UserAccount = n.GetObjectValue<Microsoft.Graph.Beta.Models.Security.UserAccount>(Microsoft.Graph.Beta.Models.Security.UserAccount.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("displayName", DisplayName);
            writer.WriteStringValue("primaryAddress", PrimaryAddress);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.Security.UserAccount>("userAccount", UserAccount);
        }
    }
}
