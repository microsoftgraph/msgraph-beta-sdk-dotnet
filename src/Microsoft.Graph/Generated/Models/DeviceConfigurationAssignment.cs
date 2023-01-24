using Microsoft.Kiota.Abstractions.Serialization;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
namespace Microsoft.Graph.Beta.Models {
    /// <summary>
    /// The device configuration assignment entity assigns an AAD group to a specific device configuration.
    /// </summary>
    public class DeviceConfigurationAssignment : Entity, IParsable {
        /// <summary>The admin intent to apply or remove the profile. Possible values are: apply, remove.</summary>
        public DeviceConfigAssignmentIntent? Intent {
            get { return BackingStore?.Get<DeviceConfigAssignmentIntent?>("intent"); }
            set { BackingStore?.Set("intent", value); }
        }
        /// <summary>Represents source of assignment.</summary>
        public DeviceAndAppManagementAssignmentSource? Source {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentSource?>("source"); }
            set { BackingStore?.Set("source", value); }
        }
        /// <summary>The identifier of the source of the assignment. This property is read-only.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public string? SourceId {
            get { return BackingStore?.Get<string?>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#nullable restore
#else
        public string SourceId {
            get { return BackingStore?.Get<string>("sourceId"); }
            set { BackingStore?.Set("sourceId", value); }
        }
#endif
        /// <summary>The assignment target for the device configuration.</summary>
#if NETSTANDARD2_1_OR_GREATER || NETCOREAPP3_1_OR_GREATER
#nullable enable
        public DeviceAndAppManagementAssignmentTarget? Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget?>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#nullable restore
#else
        public DeviceAndAppManagementAssignmentTarget Target {
            get { return BackingStore?.Get<DeviceAndAppManagementAssignmentTarget>("target"); }
            set { BackingStore?.Set("target", value); }
        }
#endif
        /// <summary>
        /// Creates a new instance of the appropriate class based on discriminator value
        /// </summary>
        /// <param name="parseNode">The parse node to use to read the discriminator value and create the object</param>
        public static new DeviceConfigurationAssignment CreateFromDiscriminatorValue(IParseNode parseNode) {
            _ = parseNode ?? throw new ArgumentNullException(nameof(parseNode));
            return new DeviceConfigurationAssignment();
        }
        /// <summary>
        /// The deserialization information for the current model
        /// </summary>
        public new IDictionary<string, Action<IParseNode>> GetFieldDeserializers() {
            return new Dictionary<string, Action<IParseNode>>(base.GetFieldDeserializers()) {
                {"intent", n => { Intent = n.GetEnumValue<DeviceConfigAssignmentIntent>(); } },
                {"source", n => { Source = n.GetEnumValue<DeviceAndAppManagementAssignmentSource>(); } },
                {"sourceId", n => { SourceId = n.GetStringValue(); } },
                {"target", n => { Target = n.GetObjectValue<DeviceAndAppManagementAssignmentTarget>(DeviceAndAppManagementAssignmentTarget.CreateFromDiscriminatorValue); } },
            };
        }
        /// <summary>
        /// Serializes information the current object
        /// </summary>
        /// <param name="writer">Serialization writer to use to serialize this model</param>
        public new void Serialize(ISerializationWriter writer) {
            _ = writer ?? throw new ArgumentNullException(nameof(writer));
            base.Serialize(writer);
            writer.WriteEnumValue<DeviceConfigAssignmentIntent>("intent", Intent);
            writer.WriteEnumValue<DeviceAndAppManagementAssignmentSource>("source", Source);
            writer.WriteObjectValue<DeviceAndAppManagementAssignmentTarget>("target", Target);
        }
    }
}
