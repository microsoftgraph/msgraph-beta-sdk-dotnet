using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.Security {
    public class TriggerTypesRoot : Entity, IParsable {
        /// <summary>The retentionEventTypes property</summary>
        public List<RetentionEventType> RetentionEventTypes {
            get { return BackingStore?.Get<List<RetentionEventType>>("retentionEventTypes"); }
            set { BackingStore?.Set("retentionEventTypes", value); }
        }
        /// <summary>
        /// Instantiates a new triggerTypesRoot and sets the default values.
        /// </summary>
        public TriggerTypesRoot() : base() {
            OdataType = "#microsoft.graph.security.triggerTypesRoot";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new TriggerTypesRoot CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TriggerTypesRoot();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"retentionEventTypes", n => { RetentionEventTypes = n.GetCollectionOfObjectValues<RetentionEventType>(RetentionEventType.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<RetentionEventType>("retentionEventTypes", RetentionEventTypes);
        }
    }
}
