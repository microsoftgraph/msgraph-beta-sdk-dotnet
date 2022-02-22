using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceCompliancePolicyAssignment : Entity, IParsable {
        /// <summary>The assignment source for the device compliance policy, direct or parcel/policySet. Possible values are: direct, policySets.</summary>
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
        /// <summary>The identifier of the source of the assignment.</summary>
        public string SourceId { get; set; }
        /// <summary>Target for the compliance policy assignment.</summary>
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"source", (o,n) => { (o as DeviceCompliancePolicyAssignment).Source = n.GetEnumValue<DeviceAndAppManagementAssignmentSource>(); } },
                {"sourceId", (o,n) => { (o as DeviceCompliancePolicyAssignment).SourceId = n.GetStringValue(); } },
                {"target", (o,n) => { (o as DeviceCompliancePolicyAssignment).Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentSource>("source", Source);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
