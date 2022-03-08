using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace MicrosoftGraphSdk.Models.Microsoft.Graph {
    /// <summary>Provides operations to manage the deviceAppManagement singleton.</summary>
    public class TargetedManagedAppPolicyAssignment : Entity, IParsable {
        /// <summary>Type of resource used for deployment to a group, direct or parcel/policySet. Possible values are: direct, policySets.</summary>
        public DeviceAndAppManagementAssignmentSource? Source { get; set; }
        /// <summary>Identifier for resource used for deployment to a group</summary>
        public string SourceId { get; set; }
        /// <summary>Identifier for deployment to a group or app</summary>
        public DeviceAndAppManagementAssignmentTarget Target { get; set; }
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        /// </summary>
        public static new TargetedManagedAppPolicyAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new TargetedManagedAppPolicyAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<T, IParseNode>> GetFieldDeserializers<T>() {
            return new Dictionary<string, Action<T, IParseNode>>(base.GetFieldDeserializers<T>()) {
                {"source", (o,n) => { (o as TargetedManagedAppPolicyAssignment).Source = n.GetEnumValue<DeviceAndAppManagementAssignmentSource>(); } },
                {"sourceId", (o,n) => { (o as TargetedManagedAppPolicyAssignment).SourceId = n.GetStringValue(); } },
                {"target", (o,n) => { (o as TargetedManagedAppPolicyAssignment).Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
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
