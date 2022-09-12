using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>Provides operations to manage the collection of accessReview entities.</summary>
    public class WorkflowVersion : WorkflowBase, IParsable {
        /// <summary>The version of the workflow.</summary>
        public int? VersionNumber {
            get { return BackingStore?.Get<int?>("versionNumber"); }
            set { BackingStore?.Set("versionNumber", value); }
        }
        /// <summary>
        /// Instantiates a new workflowVersion and sets the default values.
        /// </summary>
        public WorkflowVersion() : base() {
            OdataType = "#microsoft.graph.identityGovernance.workflowVersion";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new WorkflowVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"versionNumber", n => { VersionNumber = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("versionNumber", VersionNumber);
        }
    }
}
