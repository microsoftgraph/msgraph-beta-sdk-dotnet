using Microsoft.Kiota.Abstractions.Serialization;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System;
namespace Microsoft.Graph.Beta.Models {
    public class RedundantAssignmentAlertConfiguration : UnifiedRoleManagementAlertConfiguration, IParsable {
        /// <summary>The number of days without activation to look back on from current timestamp.</summary>
        public TimeSpan? Duration {
            get { return BackingStore?.Get<TimeSpan?>("duration"); }
            set { BackingStore?.Set("duration", value); }
        }
        /// <summary>
        /// Instantiates a new redundantAssignmentAlertConfiguration and sets the default values.
        /// </summary>
        public RedundantAssignmentAlertConfiguration() : base() {
            OdataType = "#microsoft.graph.redundantAssignmentAlertConfiguration";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new RedundantAssignmentAlertConfiguration CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new RedundantAssignmentAlertConfiguration();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"duration", n => { Duration = n.GetTimeSpanValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteTimeSpanValue("duration", Duration);
        }
    }
}
