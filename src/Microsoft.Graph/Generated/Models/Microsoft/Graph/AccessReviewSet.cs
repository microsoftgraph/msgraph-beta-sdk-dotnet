using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the identityGovernance singleton.</summary>
    public class AccessReviewSet : Entity, IParsable {
        /// <summary>Represents an Azure AD access review decision on an instance of a review.</summary>
        public List<AccessReviewInstanceDecisionItem> Decisions { get; set; }
        /// <summary>Represents the template and scheduling for an access review.</summary>
        public List<AccessReviewScheduleDefinition> Definitions { get; set; }
        /// <summary>Represents a collection of access review history data and the scopes used to collect that data.</summary>
        public List<AccessReviewHistoryDefinition> HistoryDefinitions { get; set; }
        /// <summary>Resource that enables administrators to manage directory-level access review policies in their tenant.</summary>
        public AccessReviewPolicy Policy { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new AccessReviewSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new AccessReviewSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"decisions", (o,n) => { (o as AccessReviewSet).Decisions = n.GetCollectionOfObjectValues<AccessReviewInstanceDecisionItem>(AccessReviewInstanceDecisionItem.CreateFromDiscriminatorValue).ToList(); } },
                {"definitions", (o,n) => { (o as AccessReviewSet).Definitions = n.GetCollectionOfObjectValues<AccessReviewScheduleDefinition>(AccessReviewScheduleDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"historyDefinitions", (o,n) => { (o as AccessReviewSet).HistoryDefinitions = n.GetCollectionOfObjectValues<AccessReviewHistoryDefinition>(AccessReviewHistoryDefinition.CreateFromDiscriminatorValue).ToList(); } },
                {"policy", (o,n) => { (o as AccessReviewSet).Policy = n.GetObjectValue<AccessReviewPolicy>(AccessReviewPolicy.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<AccessReviewPolicy>("policy", Policy);
        }
    }
}
