using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraph.Models.Microsoft.Graph {
    public class DeviceConfigurationGroupAssignment : Entity, IParsable {
        /// <summary>The navigation link to the Device Configuration being targeted.</summary>
        public MicrosoftGraph.Models.Microsoft.Graph.DeviceConfiguration DeviceConfiguration { get; set; }
        /// <summary>Indicates if this group is should be excluded. Defaults that the group should be included</summary>
        public bool? ExcludeGroup { get; set; }
        /// <summary>The Id of the AAD group we are targeting the device configuration to.</summary>
        public string TargetGroupId { get; set; }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceConfiguration", (o,n) => { (o as DeviceConfigurationGroupAssignment).DeviceConfiguration = n.GetObjectValue<MicrosoftGraph.Models.Microsoft.Graph.DeviceConfiguration>(); } },
                {"excludeGroup", (o,n) => { (o as DeviceConfigurationGroupAssignment).ExcludeGroup = n.GetBoolValue(); } },
                {"targetGroupId", (o,n) => { (o as DeviceConfigurationGroupAssignment).TargetGroupId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<MicrosoftGraph.Models.Microsoft.Graph.DeviceConfiguration>("deviceConfiguration", DeviceConfiguration);
            writer.WriteBoolValue("excludeGroup", ExcludeGroup);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
        }
    }
}
