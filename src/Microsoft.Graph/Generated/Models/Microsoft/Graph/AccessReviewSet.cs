using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class AccessReviewSet : Entity, IParsable {
        /// <summary>Represents an Azure AD access review decision on an instance of a review.</summary>
        public List<AccessReviewInstanceDecisionItem> Decisions { get; set; }
        /// <summary>Represents the template and scheduling for an access review.</summary>
        public List<AccessReviewScheduleDefinition> Definitions { get; set; }
        /// <summary>Represents a collection of access review history data and the scopes used to collect that data.</summary>
        public List<AccessReviewHistoryDefinition> HistoryDefinitions { get; set; }
        /// <summary>Resource that enables administrators to manage directory-level access review policies in their tenant.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.AccessReviewPolicy Policy { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"decisions", (o,n) => { (o as AccessReviewSet).Decisions = n.GetCollectionOfObjectValues<AccessReviewInstanceDecisionItem>().ToList(); } },
                {"definitions", (o,n) => { (o as AccessReviewSet).Definitions = n.GetCollectionOfObjectValues<AccessReviewScheduleDefinition>().ToList(); } },
                {"historyDefinitions", (o,n) => { (o as AccessReviewSet).HistoryDefinitions = n.GetCollectionOfObjectValues<AccessReviewHistoryDefinition>().ToList(); } },
                {"policy", (o,n) => { (o as AccessReviewSet).Policy = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessReviewPolicy>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteCollectionOfObjectValues<AccessReviewInstanceDecisionItem>("decisions", Decisions);
            writer.WriteCollectionOfObjectValues<AccessReviewScheduleDefinition>("definitions", Definitions);
            writer.WriteCollectionOfObjectValues<AccessReviewHistoryDefinition>("historyDefinitions", HistoryDefinitions);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.AccessReviewPolicy>("policy", Policy);
        }
    }
}
