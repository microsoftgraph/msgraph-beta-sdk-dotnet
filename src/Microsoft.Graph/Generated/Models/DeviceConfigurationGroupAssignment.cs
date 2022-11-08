using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>Device configuration group assignment.</summary>
    public class DeviceConfigurationGroupAssignment : Entity, IParsable {
        /// <summary>The navigation link to the Device Configuration being targeted.</summary>
        public Microsoft.Graph.Beta.Models.DeviceConfiguration DeviceConfiguration {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceConfiguration>("deviceConfiguration"); }
            set { BackingStore?.Set("deviceConfiguration", value); }
        }
        /// <summary>Indicates if this group is should be excluded. Defaults that the group should be included</summary>
        public bool? ExcludeGroup {
            get { return BackingStore?.Get<bool?>("excludeGroup"); }
            set { BackingStore?.Set("excludeGroup", value); }
        }
        /// <summary>The Id of the AAD group we are targeting the device configuration to.</summary>
        public string TargetGroupId {
            get { return BackingStore?.Get<string>("targetGroupId"); }
            set { BackingStore?.Set("targetGroupId", value); }
        }
        /// <summary>
        /// Instantiates a new deviceConfigurationGroupAssignment and sets the default values.
        /// </summary>
        public DeviceConfigurationGroupAssignment() : base() {
            OdataType = "#microsoft.graph.deviceConfigurationGroupAssignment";
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceConfigurationGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceConfiguration", n => { DeviceConfiguration = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceConfiguration>(Microsoft.Graph.Beta.Models.DeviceConfiguration.CreateFromDiscriminatorValue); } },
                {"excludeGroup", n => { ExcludeGroup = n.GetBoolValue(); } },
                {"targetGroupId", n => { TargetGroupId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceConfiguration>("deviceConfiguration", DeviceConfiguration);
            writer.WriteBoolValue("excludeGroup", ExcludeGroup);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
        }
    }
}
