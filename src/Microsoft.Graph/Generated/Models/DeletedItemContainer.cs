using Microsoft.Graph.Beta.Models.IdentityGovernance;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeletedItemContainer : Entity, IParsable {
        /// <summary>Deleted workflows that end up in the deletedItemsContainer.</summary>
        public List<Workflow> Workflows {
            get { return BackingStore?.Get<List<Workflow>>("workflows"); }
            set { BackingStore?.Set("workflows", value); }
        }
        /// <summary>
        /// Instantiates a new DeletedItemContainer and sets the default values.
        /// </summary>
        public DeletedItemContainer() : base() {
            OdataType = "#microsoft.graph.deletedItemContainer";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeletedItemContainer CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeletedItemContainer();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"workflows", n => { Workflows = n.GetCollectionOfObjectValues<Workflow>(Workflow.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<Workflow>("workflows", Workflows);
        }
    }
}
