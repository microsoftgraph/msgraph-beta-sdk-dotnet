using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceConfigurationAssignment : Entity, IParsable {
        /// <summary>The admin intent to apply or remove the profile. Possible values are: apply, remove.</summary>
        public DeviceConfigAssignmentIntent? Intent { get; set; }
        /// <summary>The assignment source for the device configuration, direct or parcel/policySet. This property is read-only. Possible values are: direct, policySets.</summary>
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
        /// <summary>The identifier of the source of the assignment. This property is read-only.</summary>
        public string SourceId { get; set; }
        /// <summary>The assignment target for the device configuration.</summary>
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"intent", (o,n) => { (o as DeviceConfigurationAssignment).Intent = n.GetEnumValue<DeviceConfigAssignmentIntent>(); } },
                {"source", (o,n) => { (o as DeviceConfigurationAssignment).Source = n.GetEnumValue<DeviceAndAppManagementAssignmentSource>(); } },
                {"sourceId", (o,n) => { (o as DeviceConfigurationAssignment).SourceId = n.GetStringValue(); } },
                {"target", (o,n) => { (o as DeviceConfigurationAssignment).Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceConfigAssignmentIntent>("intent", Intent);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentSource>("source", Source);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
