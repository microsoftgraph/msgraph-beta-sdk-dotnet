using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Contains properties used to assign a device management script to a group.</summary>
    public class DeviceHealthScriptAssignment : Entity, IParsable {
        /// <summary>Determine whether we want to run detection script only or run both detection script and remediation script</summary>
        public bool? RunRemediationScript {
            get { return BackingStore?.Get<bool?>("runRemediationScript"); }
            set { BackingStore?.Set("runRemediationScript", value); }
        }
        /// <summary>Script run schedule for the target group</summary>
        public DeviceHealthScriptRunSchedule RunSchedule {
            get { return BackingStore?.Get<DeviceHealthScriptRunSchedule>("runSchedule"); }
            set { BackingStore?.Set("runSchedule", value); }
        }
        /// <summary>The Azure Active Directory group we are targeting the script to</summary>
        public DeviceAndAppManagementAssignmentTarget Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
        /// <summary>
        /// Instantiates a new deviceHealthScriptAssignment and sets the default values.
        /// </summary>
        public DeviceHealthScriptAssignment() : base() {
            OdataType = "#microsoft.graph.deviceHealthScriptAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceHealthScriptAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceHealthScriptAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"runRemediationScript", n => { RunRemediationScript = n.GetBoolValue(); } },
                {"runSchedule", n => { RunSchedule = n.GetObjectValue<DeviceHealthScriptRunSchedule>(DeviceHealthScriptRunSchedule.CreateFromDiscriminatorValue); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteBoolValue("runRemediationScript", RunRemediationScript);
            writer.WriteObjectValue<DeviceHealthScriptRunSchedule>("runSchedule", RunSchedule);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
