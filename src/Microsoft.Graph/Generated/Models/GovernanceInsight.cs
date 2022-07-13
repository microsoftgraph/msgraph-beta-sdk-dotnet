using Microsoft.Graph.Beta.Models;
using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Provides operations to manage the collection of accessReviewDecision entities.</summary>
    public class GovernanceInsight : Entity, IParsable {
        /// <summary>Indicates when the insight was created.</summary>
        public DateTimeOffset? InsightCreatedDateTime {
            get { return BackingStore?.Get<DateTimeOffset?>("insightCreatedDateTime"); }
            set { BackingStore?.Set("insightCreatedDateTime", value); }
        }
        /// <summary>
        /// Instantiates a new governanceInsight and sets the default values.
        /// </summary>
        public GovernanceInsight() : base() {
            Type = "#microsoft.graph.governanceInsight";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new GovernanceInsight CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            var mappingValueNode = parseNode.GetChildNode("@odata.type");
            var mappingValue = mappingValueNode?.GetStringValue();
            return mappingValue switch {
                "#microsoft.graph.membershipOutlierInsight" => new MembershipOutlierInsight(),
                "#microsoft.graph.userSignInInsight" => new UserSignInInsight(),
                _ => new GovernanceInsight(),
            };
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"insightCreatedDateTime", n => { InsightCreatedDateTime = n.GetDateTimeOffsetValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteDateTimeOffsetValue("insightCreatedDateTime", InsightCreatedDateTime);
        }
    }
}
