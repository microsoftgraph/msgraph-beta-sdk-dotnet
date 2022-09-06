using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models.IdentityGovernance {
    public class TimeBasedAttributeTrigger : WorkflowExecutionTrigger, IParsable {
        /// <summary>How many days before or after the time-based attribute specified the workflow should trigger. For example, if the attribute is employeeHireDate and offsetInDays is -1, then the workflow should trigger one day before the employee hire date.</summary>
        public int? OffsetInDays {
            get { return BackingStore?.Get<int?>("offsetInDays"); }
            set { BackingStore?.Set("offsetInDays", value); }
        }
        /// <summary>The timeBasedAttribute property</summary>
        public WorkflowTriggerTimeBasedAttribute? TimeBasedAttribute {
            get { return BackingStore?.Get<WorkflowTriggerTimeBasedAttribute?>("timeBasedAttribute"); }
            set { BackingStore?.Set("timeBasedAttribute", value); }
        }
        /// <summary>
        /// Instantiates a new TimeBasedAttributeTrigger and sets the default values.
        /// </summary>
        public TimeBasedAttributeTrigger() : base() {
            OdataType = "#microsoft.graph.identityGovernance.timeBasedAttributeTrigger";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TimeBasedAttributeTrigger CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TimeBasedAttributeTrigger();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"offsetInDays", n => { OffsetInDays = n.GetIntValue(); } },
                {"timeBasedAttribute", n => { TimeBasedAttribute = n.GetEnumValue<WorkflowTriggerTimeBasedAttribute>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteIntValue("offsetInDays", OffsetInDays);
            writer.WriteEnumValue<WorkflowTriggerTimeBasedAttribute>("timeBasedAttribute", TimeBasedAttribute);
        }
    }
}
