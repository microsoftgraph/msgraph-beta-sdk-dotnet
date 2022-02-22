using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceHealthScriptAssignment : Entity, IParsable {
        /// <summary>Determine whether we want to run detection script only or run both detection script and remediation script</summary>
        public bool? RunRemediationScript { get; set; }
        /// <summary>Script run schedule for the target group</summary>
        public DeviceHealthScriptRunSchedule RunSchedule { get; set; }
        /// <summary>The Azure Active Directory group we are targeting the script to</summary>
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"runRemediationScript", (o,n) => { (o as DeviceHealthScriptAssignment).RunRemediationScript = n.GetBoolValue(); } },
                {"runSchedule", (o,n) => { (o as DeviceHealthScriptAssignment).RunSchedule = n.GetObjectValue<DeviceHealthScriptRunSchedule>(); } },
                {"target", (o,n) => { (o as DeviceHealthScriptAssignment).Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(); } },
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
