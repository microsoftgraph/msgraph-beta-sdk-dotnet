using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceConfigurationGroupAssignment : Entity, IParsable {
        /// <summary>The navigation link to the Device Configuration being targeted.</summary>
        public Microsoft.Graph.Beta.Models.DeviceConfiguration DeviceConfiguration { get; set; }
        /// <summary>Indicates if this group is should be excluded. Defaults that the group should be included</summary>
        public bool? ExcludeGroup { get; set; }
        /// <summary>The Id of the AAD group we are targeting the device configuration to.</summary>
        public string TargetGroupId { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceConfigurationGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"deviceConfiguration", (o,n) => { (o as DeviceConfigurationGroupAssignment).DeviceConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceConfiguration>(Microsoft.Graph.Beta.Models.DeviceConfiguration.CreateFromDiscriminatorValue); } },
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
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceConfiguration>("deviceConfiguration", DeviceConfiguration);
            writer.WriteBoolValue("excludeGroup", ExcludeGroup);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
        }
    }
}
