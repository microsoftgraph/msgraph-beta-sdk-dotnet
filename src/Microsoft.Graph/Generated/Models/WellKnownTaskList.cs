using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class WellKnownTaskList : BaseTaskList, IParsable {
        /// <summary>The wellKnownListName property</summary>
        public WellKnownListName_v2? WellKnownListName {
            get { return BackingStore?.Get<WellKnownListName_v2?>("wellKnownListName"); }
            set { BackingStore?.Set("wellKnownListName", value); }
        }
        /// <summary>
        /// Instantiates a new WellKnownTaskList and sets the default values.
        /// </summary>
        public WellKnownTaskList() : base() {
            OdataType = "#microsoft.graph.wellKnownTaskList";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WellKnownTaskList CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WellKnownTaskList();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"wellKnownListName", n => { WellKnownListName = n.GetEnumValue<WellKnownListName_v2>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<WellKnownListName_v2>("wellKnownListName", WellKnownListName);
        }
    }
}
