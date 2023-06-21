using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models.Networkaccess {
    public class Logs : Entity, IParsable {
        /// <summary>The traffic property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public List<NetworkAccessTraffic>? Traffic {
            get { return BackingStore?.Get<List<NetworkAccessTraffic>?>("traffic"); }
            set { BackingStore?.Set("traffic", value); }
        }
#nullable restore
#else
        public List<NetworkAccessTraffic> Traffic {
            get { return BackingStore?.Get<List<NetworkAccessTraffic>>("traffic"); }
            set { BackingStore?.Set("traffic", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new Logs CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new Logs();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"traffic", n => { Traffic = n.GetCollectionOfObjectValues<NetworkAccessTraffic>(NetworkAccessTraffic.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<NetworkAccessTraffic>("traffic", Traffic);
        }
    }
}
