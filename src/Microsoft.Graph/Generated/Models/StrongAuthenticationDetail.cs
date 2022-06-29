using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class StrongAuthenticationDetail : Entity, IParsable {
        /// <summary>The encryptedPinHashHistory property</summary>
        public byte[] EncryptedPinHashHistory {
            get { return BackingStore?.Get<byte[]>(nameof(EncryptedPinHashHistory)); }
            set { BackingStore?.Set(nameof(EncryptedPinHashHistory), value); }
        }
        /// <summary>The proofupTime property</summary>
        public long? ProofupTime {
            get { return BackingStore?.Get<long?>(nameof(ProofupTime)); }
            set { BackingStore?.Set(nameof(ProofupTime), value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new StrongAuthenticationDetail CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new StrongAuthenticationDetail();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"encryptedPinHashHistory", n => { EncryptedPinHashHistory = n.GetByteArrayValue(); } },
                {"proofupTime", n => { ProofupTime = n.GetLongValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteByteArrayValue("encryptedPinHashHistory", EncryptedPinHashHistory);
            writer.WriteLongValue("proofupTime", ProofupTime);
        }
    }
}
