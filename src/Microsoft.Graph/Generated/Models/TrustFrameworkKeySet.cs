using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class TrustFrameworkKeySet : Entity, IParsable {
        /// <summary>A collection of the keys.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<TrustFrameworkKey>? Keys {
            get { return BackingStore?.Get<List<TrustFrameworkKey>?>("keys"); }
            set { BackingStore?.Set("keys", value); }
        }
#nullable restore
#else
        public List<TrustFrameworkKey> Keys {
            get { return BackingStore?.Get<List<TrustFrameworkKey>>("keys"); }
            set { BackingStore?.Set("keys", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TrustFrameworkKeySet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TrustFrameworkKeySet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"keys", n => { Keys = n.GetCollectionOfObjectValues<TrustFrameworkKey>(TrustFrameworkKey.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<TrustFrameworkKey>("keys", Keys);
        }
    }
}
