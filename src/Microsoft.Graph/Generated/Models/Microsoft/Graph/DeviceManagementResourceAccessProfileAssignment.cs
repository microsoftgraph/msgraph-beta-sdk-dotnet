using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    public class DeviceManagementResourceAccessProfileAssignment : Entity, IParsable {
        /// <summary>The assignment intent for the resource access profile. Possible values are: apply, remove.</summary>
        public DeviceManagementResourceAccessProfileIntent? Intent { get; set; }
        /// <summary>The identifier of the source of the assignment.</summary>
        public string SourceId { get; set; }
        /// <summary>Base type for assignment targets.</summary>
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"intent", (o,n) => { (o as DeviceManagementResourceAccessProfileAssignment).Intent = n.GetEnumValue<DeviceManagementResourceAccessProfileIntent>(); } },
                {"sourceId", (o,n) => { (o as DeviceManagementResourceAccessProfileAssignment).SourceId = n.GetStringValue(); } },
                {"target", (o,n) => { (o as DeviceManagementResourceAccessProfileAssignment).Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceManagementResourceAccessProfileIntent>("intent", Intent);
            writer.WriteStringValue("sourceId", SourceId);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
