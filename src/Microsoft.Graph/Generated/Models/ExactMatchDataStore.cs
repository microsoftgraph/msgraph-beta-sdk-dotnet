using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class ExactMatchDataStore : ExactMatchDataStoreBase, IParsable {
        /// <summary>The sessions property</summary>
        public List<ExactMatchSession> Sessions {
            get { return BackingStore?.Get<List<ExactMatchSession>>("sessions"); }
            set { BackingStore?.Set("sessions", value); }
        }
        /// <summary>
        /// Instantiates a new ExactMatchDataStore and sets the default values.
        /// </summary>
        public ExactMatchDataStore() : base() {
            OdataType = "#microsoft.graph.exactMatchDataStore";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new ExactMatchDataStore CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new ExactMatchDataStore();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"sessions", n => { Sessions = n.GetCollectionOfObjectValues<ExactMatchSession>(ExactMatchSession.CreateFromDiscriminatorValue).ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<ExactMatchSession>("sessions", Sessions);
        }
    }
}
