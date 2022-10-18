using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    /// <summary>Provides operations to manage the collection of activityStatistics entities.</summary>
    public class LifecycleManagementSettings : Entity, IParsable {
        /// <summary>The interval in hours at which all workflows running in the tenant should be scheduled for execution. This interval has a minimum value of 1 and a maximum value of 24. The default value is 3 hours.</summary>
        public int? WorkflowScheduleIntervalInHours {
            get { return BackingStore?.Get<int?>("workflowScheduleIntervalInHours"); }
            set { BackingStore?.Set("workflowScheduleIntervalInHours", value); }
        }
        /// <summary>
        /// Instantiates a new lifecycleManagementSettings and sets the default values.
        /// </summary>
        public LifecycleManagementSettings() : base() {
            OdataType = "#microsoft.graph.identityGovernance.lifecycleManagementSettings";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new LifecycleManagementSettings CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new LifecycleManagementSettings();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"workflowScheduleIntervalInHours", n => { WorkflowScheduleIntervalInHours = n.GetIntValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("workflowScheduleIntervalInHours", WorkflowScheduleIntervalInHours);
        }
    }
}
