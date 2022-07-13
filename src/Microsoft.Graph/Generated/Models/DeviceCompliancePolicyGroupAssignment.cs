using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    public class DeviceCompliancePolicyGroupAssignment : Entity, IParsable {
        /// <summary>The navigation link to the  device compliance polic targeted.</summary>
        public Microsoft.Graph.Beta.Models.DeviceCompliancePolicy DeviceCompliancePolicy {
            get { return BackingStore?.Get<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy>("deviceCompliancePolicy"); }
            set { BackingStore?.Set("deviceCompliancePolicy", value); }
        }
        /// <summary>Indicates if this group is should be excluded. Defaults that the group should be included</summary>
        public bool? ExcludeGroup {
            get { return BackingStore?.Get<bool?>("excludeGroup"); }
            set { BackingStore?.Set("excludeGroup", value); }
        }
        /// <summary>The Id of the AAD group we are targeting the device compliance policy to.</summary>
        public string TargetGroupId {
            get { return BackingStore?.Get<string>("targetGroupId"); }
            set { BackingStore?.Set("targetGroupId", value); }
        }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new DeviceCompliancePolicyGroupAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceCompliancePolicyGroupAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"deviceCompliancePolicy", n => { DeviceCompliancePolicy = n.GetObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy>(Microsoft.Graph.Beta.Models.DeviceCompliancePolicy.CreateFromDiscriminatorValue); } },
                {"excludeGroup", n => { ExcludeGroup = n.GetBoolValue(); } },
                {"targetGroupId", n => { TargetGroupId = n.GetStringValue(); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        /// </summary>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteObjectValue<Microsoft.Graph.Beta.Models.DeviceCompliancePolicy>("deviceCompliancePolicy", DeviceCompliancePolicy);
            writer.WriteBoolValue("excludeGroup", ExcludeGroup);
            writer.WriteStringValue("targetGroupId", TargetGroupId);
        }
    }
}
