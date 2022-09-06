using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class RuleBasedSubjectSet : SubjectSet, IParsable {
        /// <summary>The rule for the subject set.</summary>
        public string Rule {
            get { return BackingStore?.Get<string>("rule"); }
            set { BackingStore?.Set("rule", value); }
        }
        /// <summary>
        /// Instantiates a new RuleBasedSubjectSet and sets the default values.
        /// </summary>
        public RuleBasedSubjectSet() : base() {
            OdataType = "#microsoft.graph.identityGovernance.ruleBasedSubjectSet";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new RuleBasedSubjectSet CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RuleBasedSubjectSet();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"rule", n => { Rule = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("rule", Rule);
        }
    }
}
