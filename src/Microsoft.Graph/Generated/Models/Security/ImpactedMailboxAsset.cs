using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Security {
    public class ImpactedMailboxAsset : ImpactedAsset, IParsable {
        /// <summary>The identifier property</summary>
        public MailboxAssetIdentifier? Identifier {
            get { return BackingStore?.Get<MailboxAssetIdentifier?>("identifier"); }
            set { BackingStore?.Set("identifier", value); }
        }
        /// <summary>
        /// Instantiates a new impactedMailboxAsset and sets the default values.
        /// </summary>
        public ImpactedMailboxAsset() : base() {
            OdataType = "#microsoft.graph.security.impactedMailboxAsset";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new ImpactedMailboxAsset CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ImpactedMailboxAsset();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"identifier", n => { Identifier = n.GetEnumValue<MailboxAssetIdentifier>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<MailboxAssetIdentifier>("identifier", Identifier);
        }
    }
}
