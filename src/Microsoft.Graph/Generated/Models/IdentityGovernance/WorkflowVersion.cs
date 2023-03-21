using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class WorkflowVersion : WorkflowBase, IParsable {
        /// <summary>The OdataType property</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? OdataType {
            get { return BackingStore?.Get<string?>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#nullable restore
#else
        public string OdataType {
            get { return BackingStore?.Get<string>("@odata.type"); }
            set { BackingStore?.Set("@odata.type", value); }
        }
#endif
        /// <summary>The version of the workflow.Supports $filter(lt, le, gt, ge, eq, ne) and $orderby.</summary>
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
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new WorkflowVersion CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new WorkflowVersion();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"@odata.type", n => { OdataType = n.GetStringValue(); } },
                {"versionNumber", n => { VersionNumber = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteStringValue("@odata.type", OdataType);
            writer.WriteIntValue("versionNumber", VersionNumber);
        }
    }
}
