using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class PlannerRoster : Entity, IParsable {
        /// <summary>Retrieves the members of the plannerRoster.</summary>
        public List<PlannerRosterMember> Members {
            get { return BackingStore?.Get<List<PlannerRosterMember>>("members"); }
            set { BackingStore?.Set("members", value); }
        }
        /// <summary>Retrieves the plans contained by the plannerRoster.</summary>
        public List<PlannerPlan> Plans {
            get { return BackingStore?.Get<List<PlannerPlan>>("plans"); }
            set { BackingStore?.Set("plans", value); }
        }
        /// <summary>
        /// Instantiates a new PlannerRoster and sets the default values.
        /// </summary>
        public PlannerRoster() : base() {
            OdataType = "#microsoft.graph.plannerRoster";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new PlannerRoster CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new PlannerRoster();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"members", n => { Members = n.GetCollectionOfObjectValues<PlannerRosterMember>(PlannerRosterMember.CreateFromDiscriminatorValue)?.ToList(); } },
                {"plans", n => { Plans = n.GetCollectionOfObjectValues<PlannerPlan>(PlannerPlan.CreateFromDiscriminatorValue)?.ToList(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<PlannerRosterMember>("members", Members);
            writer.WriteCollectionOfObjectValues<PlannerPlan>("plans", Plans);
        }
    }
}
